using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using MessV3Library.Ctrl;
using MessV3Server.db;
using MessV3Library.Util;

namespace MessV3Server {
    public partial class windowMain : Form {

        private static Dictionary<TcpClient, MessClient> clientList;
        private static Dictionary<TcpClient, MessClient> mutedUsers;

        private TcpListener serverSocket;
        private Thread serverThread;
        private readonly cDatos db;

        public windowMain() {  
            InitializeComponent();

            // Initializing
            int listenPort = Properties.Settings.Default.listenPort;

            serverSocket = new TcpListener(IPAddress.Any, listenPort);
            clientList = new Dictionary<TcpClient, MessClient>();

            lblLog.SelectionTabs = new int[] { 40, 80 };
            lblLog.AcceptsTab = true;

            // Initialize Database Manager
            db = new cDatos();
        }

        // ------------------------------------------------------------------------------ SERVER SOCKET MANAGER
        public void manageServer() {
            TcpClient clientSocket = default(TcpClient);

            log("Starting listen socket...", true);
            serverSocket.Start();
            log("Chat Server Started", true);
            while ( true ) {
                byte[] bytesFrom = new byte[65536];

                // Await until connection
                clientSocket = serverSocket.AcceptTcpClient();

                log("Connection attempt recieved!", true);
                try {
                    // Recieving handshake from client
                    NetworkStream networkStream = clientSocket.GetStream();
                    networkStream.Read(bytesFrom, 0, (int)clientSocket.ReceiveBufferSize);
                } catch (IOException e) {
                    log("Client left without handshake");
                    continue;
                }


                MessMessage inMessage, outMessage;
                string messageJSON;
                int token;
                dynamic content;

                // Decoding json from bytes
                messageJSON = Encoding.Unicode.GetString(bytesFrom);

                // Deserializing json
                inMessage = JsonConvert.DeserializeObject<MessMessage>(messageJSON);

                log("Handshake!", true);
                log("From: " + clientSocket.Client.RemoteEndPoint.ToString());
                log("Packet: " + inMessage.ToString());


                Thread handshakeThread = new Thread(() => {
                    // Parse data from JSON String
                    content = JsonConvert.DeserializeObject(inMessage.content);
                    token = content.token;
                    
                    // TODO Ban users
                    /* 
                    if () {

                    } else {

                    }
                    */
                    content = new JObject();
                    content.isValid = (token == "MessV3".GetHashCode());
                    content.message = (Boolean) content.isValid ? "Valid Token" : "Invalid Token";

                    outMessage = new MessMessage();
                    outMessage.type = MessageTypes.HandshakeData;
                    outMessage.content = JsonConvert.SerializeObject(content);

                    sendMessage(outMessage.toJSON(), clientSocket);

                    if ((Boolean) content.isValid) {
                        clientList.Add(clientSocket, new MessClient());
                    }

                    Thread clientThread = new Thread(() => { clientThreadFunction(clientSocket); });
                    clientThread.IsBackground = true;
                    clientThread.Start();
                });
                handshakeThread.IsBackground = true;
                handshakeThread.Start();
            }
        }



        // ------------------------------------------------------------------------------ GENERAL FUNCTIONS
        // ---------------------------------------------------------- INTERNAL LOGGING
        private void log(string content, bool isNew) {
            // Runs update UI on UI home thread
            this.Invoke((MethodInvoker)delegate {
                if (isNew) {
                    lblLog.Text += "\n\n";
                    lblLog.Text += "@"  + DateTime.UtcNow.ToString("dd-MM-yyyy HH:mm:ss");
                    lblLog.Text += "\n" + @content;
                } else {
                    lblLog.Text += "\n\t" + @content;
                }

            });
        }
        private void log(string content) {
            // Runs update UI on UI home thread
            this.Invoke((MethodInvoker)delegate {
                lblLog.Text += "\n\t" + @content;
            });
        }
        private void logMessage(MessMessage message) {
            /*
                Message Types:
                    0: Login Info
                    1: Text Message
                    2: Image
                    3: File
             */
            String typeMessage = "";
            switch (message.type) {
                case MessageTypes.TextMessage:
                    typeMessage = "Text";
                    break;
                case MessageTypes.ImageMessage:
                    typeMessage = "Image";
                    break;
                case MessageTypes.FileMessage:
                    typeMessage = "File";
                    break;
            }

            log(typeMessage + " Message Sent:", true);
            log(message.content);
        }

        // ---------------------------------------------------------- SENDING MESSAGES
        private void broadcast(string message) {
            foreach (KeyValuePair<TcpClient, MessClient> client in clientList) {
                sendMessage(message, client.Key);
            }
        }
        private static void sendMessage(string message, TcpClient client) {
            NetworkStream serverStream = client.GetStream();
            Byte[] broadcastBytes = null;

            broadcastBytes = Encoding.Unicode.GetBytes(message);

            serverStream.Write(broadcastBytes, 0, broadcastBytes.Length);
            serverStream.Flush();
            serverStream = null;
        }

        // ---------------------------------------------------------- CLIENT MANAGEMENT
        private MessMessage createUser(dynamic data) {
            Random random = new Random();
            MessMessage message;
            DataTable res = new DataTable();
            dynamic result = new JObject();
            int errorCode = 0;
            string dbMessage = "";

            log("Attempting to authorize user to create new user:", true);
            log("username: " + data.username + ", name: " + data.name);

            if ( ((String) data.username).Trim() == "") {
                errorCode = 3;
                dbMessage = "User needs username"; 
            } else if ( ((String) data.name).Trim() == "") {
                errorCode = 3;
                dbMessage = "Name needs to exist";
            } else if (data.password == "".GetHashCode()) {
                errorCode = 3;
                dbMessage = "Password needed";
            } else {
                try {
                    db.OpenConnection();

                    db.setPreparedStatement("call p_create_user(@val0, @val1, @val2, @val3)");
                    db.setPreparedVariables(new Dictionary<string, object> {
                        {"@val0", random.Next(0, 9999)},// id INT
                        {"@val1", data.name},       // name STRING
                        {"@val2", data.username},   // username STRING
                        {"@val3", data.password}    // password INT
                    });

                    res.Load(db.runPreparedStatement());

                    foreach (DataRow row in res.Rows) {
                        errorCode = (Int32) row["errorCode"];
                        dbMessage = (String) row["message"];
                    }
                } catch (MySqlException e) {
                    log("Exception occured!");
                    log(e.ToString());
                } finally {
                    db.CloseConnection();
                }
            }

            
            if (errorCode != 2) {
                result.isValid = (errorCode == 0);
                result.message = dbMessage;
            } else {
                result = createUser(data);
            }

            message = new MessMessage();
            message.type = MessageTypes.RegisterData;
            message.content = JsonConvert.SerializeObject(result);

            log("Result: " + dbMessage);

            return message;
        }
        private MessMessage validateUser(dynamic data) {
            MessMessage message;
            DataTable res = new DataTable();
            dynamic result = new JObject();
            bool isLogin = false;
            string dbMessage = "";
            string name = "";
            int id = 0;

            log("Attempting to authorize user:", true);
            log("username: " + data.username);

            try {
                db.OpenConnection();

                db.setPreparedStatement("call p_validate_user(@val0, @val1)");
                db.setPreparedVariables(new Dictionary<string, object> {
                    {"@val0", data.username},
                    {"@val1", data.password}
                });

                res.Load(db.runPreparedStatement());

                foreach (DataRow row in res.Rows) {
                    isLogin = ( (Int32) row["login"] == 1 );
                    id = ((Int32)row["id"]);
                    dbMessage = (String) row["message"];
                    name = (String) row["name"];
                }

            } catch (MySqlException e) {
                log("Exception occured!");
                log(e.ToString());
            } finally {
                db.CloseConnection();
            }

            result.login = isLogin;
            result.message = dbMessage;
            result.name = name;
            result.id = id;

            message = new MessMessage();
            message.type = MessageTypes.LoginData;
            message.content = JsonConvert.SerializeObject(result);

            log("Result: " + dbMessage);

            return message;
        }
        private MessMessage editUser(dynamic data) {
            MessMessage message;
            DataTable res = new DataTable();
            dynamic result = new JObject();
            bool isValid = false;
            string dbMessage = "";

            log("Attempting to edit user:", true);
            log("Old Name: " + data.oldName );
            log("New Name: " + data.newName );

            if ( ((String) data.newName).Trim() != "" ) {
                try {
                    db.OpenConnection();

                    db.setPreparedStatement("call p_edit_user(@val0, @val1)");
                    db.setPreparedVariables(new Dictionary<string, object> {
                        {"@val0", data.id},
                        {"@val1", data.newName}
                    });

                    res.Load(db.runPreparedStatement());

                    foreach (DataRow row in res.Rows) {
                        isValid = ((Int32)row["isValid"] == 1);
                        dbMessage = (String)row["message"];
                    }

                }
                catch (MySqlException e) {
                    log("Exception occured!");
                    log(e.ToString());
                }
                finally {
                    db.CloseConnection();
                }
            } else {
                isValid = false;
                dbMessage = "Name needs to be real";
            }

            result.isValid = isValid;
            result.message = dbMessage;
            result.newName = data.newName;

            message = new MessMessage();
            message.type = MessageTypes.EditName;
            message.content = JsonConvert.SerializeObject(result);

            log("Result: " + dbMessage);

            return message;
        }

        // ---------------------------------------------------------- GUI UPDATING
        private void updateClientList() {
            MessMessage outMessage;
            List<String> userList;

            log("Updating user list...", true);

            // Create user list from the dictionary
            userList = new List<string>();
            foreach (KeyValuePair<TcpClient, MessClient> client in clientList) {
                if (client.Value.isLogin) {
                    userList.Add(client.Value.name);
                }
            }

            // Generate user list message
            outMessage = new MessMessage();
            outMessage.type = MessageTypes.UserListUpdate;
            outMessage.content = JsonConvert.SerializeObject(userList);

            broadcast(outMessage.toJSON());
            log("Sent user list to current users");

            updateUserList(userList);
            log("Current user list updated");
        }
        private void updateUserList(List<string> userList) {
            this.Invoke((MethodInvoker)delegate {
                listOnlineUsers.Items.Clear();

                foreach (string user in userList) {
                    listOnlineUsers.Items.Add(user);
                }
            });
        }



        // ------------------------------------------------------------------------------ CLIENT THREAD FUNCTION
        public void clientThreadFunction(TcpClient socket) {
            int buffSize = 0;
            byte[] inBytes;
            string JSONMessage;
            string authorName = "";
            int id = 0;
            MessMessage inMessage, outMessage;

            TcpClient clientSocket = socket;
            NetworkStream serverStream;

            try {
                while (true) {
                    // Resetting variables
                    outMessage = new MessMessage();
                    inBytes = new byte[65536];

                    serverStream = clientSocket.GetStream();

                    buffSize = clientSocket.ReceiveBufferSize;
                    serverStream.Read(inBytes, 0, buffSize);

                    JSONMessage = Encoding.Unicode.GetString(inBytes);
                    inMessage = JsonConvert.DeserializeObject<MessMessage>(JSONMessage);

                    dynamic content = JsonConvert.DeserializeObject(inMessage.content);
                    authorName = clientList[clientSocket].name;
                    id = clientList[clientSocket].id;

                    
                    
                    // Check for message type
                    switch (inMessage.type) {
                        case MessageTypes.Terminate:
                            log("User disconnecting...", true);
                            log("Info: " + clientSocket.Client.RemoteEndPoint.ToString());
                            log("Name: " + authorName);

                            // Remove user from client list
                            clientList.Remove(clientSocket);
                            clientSocket.Close();
                            log("User disconnected");
                            return;
                        case MessageTypes.RegisterData:
                            // Create new user
                            outMessage = createUser(content);
                            sendMessage(outMessage.toJSON(), clientSocket);
                            break;
                        case MessageTypes.LoginData:
                            // Authenticate credentials
                            outMessage = validateUser(content);

                            dynamic result = JsonConvert.DeserializeObject(outMessage.content);

                            // Update client information
                            clientList[clientSocket].name = result.name;
                            clientList[clientSocket].isLogin = result.login;
                            clientList[clientSocket].id = result.id;

                            sendMessage(outMessage.toJSON(), clientSocket);
                            if ((Boolean) result.login) {
                                updateClientList();
                            }
                            break;
                        case MessageTypes.EditName:
                            // Modify user's name
                            content.oldName = authorName;
                            content.id = id;

                            outMessage = editUser(content);

                            content = JsonConvert.DeserializeObject(outMessage.content);

                            if ((Boolean) content.isValid) {
                                clientList[clientSocket].name = content.newName;
                                updateClientList();
                            }

                            sendMessage(outMessage.toJSON(), clientSocket);
                            break;
                        case MessageTypes.TextMessage:
                            // Text message
                            if (!mutedUsers.ContainsValue(clientList[clientSocket])) {

                                if (clientList[clientSocket].isLogin) {
                                    // Adding author
                                    content.author = authorName;

                                    // Setting message up
                                    outMessage.type = inMessage.type;
                                    outMessage.time = Utilities.DateTime2UnixTimeStamp(DateTime.UtcNow);
                                    outMessage.content = JsonConvert.SerializeObject(content);

                                    // Logging message
                                    logMessage(outMessage);
                                    // Sending message to all
                                    broadcast(outMessage.toJSON());
                                } else {
                                    // User hasn't logged in
                                    // TODO Add generic "Server response" message type
                                    // Highjacking registering data because of client's internal response to it

                                    // Setting message up
                                    outMessage.type = MessageTypes.RegisterData;
                                    outMessage.content = "Cannot send messages, user hasn't logged in!";

                                    // Sending message
                                    sendMessage(outMessage.toJSON(), clientSocket);
                                }
                            } else {
                                // User is muted
                                // Same as before

                                // Setting message up
                                outMessage.type = MessageTypes.RegisterData;
                                outMessage.content = "User is muted";

                                // Sending message
                                sendMessage(outMessage.toJSON(), clientSocket);
                            }
                            break;

                    }
                }
            } catch (IOException e) {
                log("User disconnected forcefully", true);
                log("Name: " + authorName);

                // Remove user from client list
                clientList.Remove(clientSocket);
                clientSocket.Close();
                return;
            } catch (Exception e) {
                // Catch ALL Exceptions just in case
                log(e.ToString());
            }
        }



        // ------------------------------------------------------------------------------ LISTENERS
        private void windowMain_Load(object sender, EventArgs e) {
            numServerPort.Value = Properties.Settings.Default.listenPort;


            serverThread = new Thread(new ThreadStart(manageServer));
            serverThread.IsBackground = true;
            serverThread.Name = "Client Reciever";
            serverThread.Start();
        }
        private void numServerPort_ValueChanged(object sender, EventArgs e) {
            Properties.Settings.Default.listenPort = (Int32) numServerPort.Value;
            Properties.Settings.Default.Save();
        }
        private void btnResetServerPort_Click(object sender, EventArgs e) {
            numServerPort.Value = Properties.Settings.Default.defaultListenPort;
        }

        private void lblLog_TextChanged(object sender, EventArgs e) {
            lblLog.SelectionStart = lblLog.Text.Length;
            lblLog.ScrollToCaret();
        }
    }
}