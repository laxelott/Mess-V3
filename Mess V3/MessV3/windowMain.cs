using System;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Threading;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

using MessV3Library.Util;
using MessV3Library.Ctrl;
using System.Text;
using System.IO;
using System.Media;

namespace MessV3 {
    public partial class windowMain : Form {
        TcpClient clientSocket;
        Thread messageThread;

        SoundPlayer messageSoundPlayer;

        string name;

        bool isConnected;
        bool isLogin;
        bool isFirst;
        int rowIndex = 0;

        public windowMain() {
            InitializeComponent();
            this.CenterToScreen();

            isLogin = false;
            isConnected = false;
            isFirst = true;

            // Tabs Initialization
            loginTabInit();
            settingsTabInit();
            messagingTabInit();

            messageSoundPlayer = new SoundPlayer(Properties.Resources.ding);
        }



        // ------------------------------------------------------------------------------ INITIALIZATIONS
        // ---------------------------------------------------------- TABS
        private void messagingTabInit() {
            txtMessage.Enabled = false;
            btnSendMessage.Enabled = false;
            menuStripSend.Enabled = false;

            if (isConnected) {
                if(isLogin) {
                    txtMessage.Enabled = true;
                    btnSendMessage.Enabled = true;
                    menuStripSend.Enabled = true;

                    logInfo("Awaiting Input");
                    lblMessagingLoggedinName.Text = "Logged in as " + name;
                } else {
                    logInfo("Not logged in");
                    lblMessagingLoggedinName.Text = "Not logged in";
                }
            } else {
                logInfo("Not Connected");
                lblMessagingLoggedinName.Text = "Not connected";
            }
        }
        private void loginTabInit() {
            Utilities.centerControl(tableLayoutLoginMain);

            if (isConnected) {
                if (isLogin) {
                    tableLayoutLoginMain.Enabled = false;
                    lblLoginLoggedinName.Text = "Logged in as " + name;
                } else {
                    tableLayoutLoginMain.Enabled = true;
                    lblLoginLoggedinName.Text = "Not logged in";
                }
            } else {
                tableLayoutLoginMain.Enabled = false;

                logInfo("Not Connected");
                lblLoginLoggedinName.Text = "Not connected";

                txtLoginUsername.Text = "";
                txtLoginDisplayName.Text = "";
                txtLoginPassword.Text = "";
                txtLoginPassword2.Text = "";

            }
        }
        private void settingsTabInit() {
            txtSettingsServerLocation.Text = Properties.Settings.Default.serverLocation;
            numSettingsPort.Value = Properties.Settings.Default.clientPort;
            lblInfo.Text = "Awaiting Input";

            if(isLogin) {
                groupBoxUserSettings.Visible = true;

                txtSettingsDisplayName.Text = name;
            } else {
                groupBoxUserSettings.Visible = false;
            }
        }

        // ---------------------------------------------------------- SOCKETS
        private void socketsInit() {
            clientSocket = new TcpClient();
            String serverLocation = Properties.Settings.Default.serverLocation;
            int clientPort = Properties.Settings.Default.clientPort;

            // Check if Server Location is empty
            if (serverLocation == "") {
                lblInfo.Text = "Please set Server Location in Settings Tab.";
                return;
            }
            if (clientSocket.Connected) {
                logInfo("Connected to Server");
                return;
            }


            messageThread = new Thread(new ThreadStart(recieveMessagesThread));
            messageThread.IsBackground = true;
            Thread socketCreationThread = new Thread(() => {
                try {
                    // Connect socket
                    clientSocket.Connect(serverLocation, clientPort);

                    logInfo("Conneciton established! Sending handshake");
                    MessMessage outMessage = new MessMessage();
                    dynamic content = new JObject();
                    content.token = "MessV3".GetHashCode();

                    // Get message contents
                    outMessage.type = MessageTypes.HandshakeData;
                    outMessage.content = JsonConvert.SerializeObject(content);

                    sendToServer(outMessage.toJSON());

                    isConnected = true;

                    messageThread.Start();
                    this.Invoke((MethodInvoker)delegate {
                        btnConnect.Text = "Disconnect";
                        tabControlMain.SelectedIndex = 1;
                    });
                }
                catch (SocketException e) {
                    logInfo(e.Message);
                }
            });

            socketCreationThread.IsBackground = true;
            socketCreationThread.Start();
        }

        // ---- END INITIALIZATIONS



        // ------------------------------------------------------------------------------ GENERAL FUNCTIONS
        // ---------------------------------------------------------- USER MANAGEMENT
        private void Login() {
            MessMessage outMessage;
            dynamic credentials;

            credentials = new JObject();
            credentials.type = MessageTypes.LoginData;
            credentials.username = txtLoginUsername.Text;
            credentials.password = txtLoginPassword.Text.GetHashCode();

            lblInfo.Text = "Attempting login...";

            outMessage = new MessMessage();
            outMessage.type = MessageTypes.LoginData;
            outMessage.content = JsonConvert.SerializeObject(credentials);
            
            sendToServer(outMessage.toJSON());
            lblInfo.Text = "Credentials sent";
        }
        private void Register() {
            MessMessage outMessage;
            dynamic details;

            details = new JObject();
            details.name = txtLoginDisplayName.Text;
            details.username = txtLoginUsername.Text;
            details.password = txtLoginPassword2.Text.GetHashCode();

            lblInfo.Text = "Attempting registration...";

            outMessage = new MessMessage();
            outMessage.type = MessageTypes.RegisterData;
            outMessage.content = JsonConvert.SerializeObject(details);

            sendToServer(outMessage.toJSON());
            lblInfo.Text = "User details sent";
        }
        private void changeDisplayName() {
            MessMessage outMessage;
            dynamic content;

            content = new JObject();
            content.newName = txtSettingsDisplayName.Text.Trim();
            
            lblInfo.Text = "Attempting modification...";

            outMessage = new MessMessage();
            outMessage.type = MessageTypes.EditName;
            outMessage.content = JsonConvert.SerializeObject(content);

            sendToServer(outMessage.toJSON());
            lblInfo.Text = "Updated name sent";
        }

        // ---------------------------------------------------------- SEND STRING TO SERVER
        private void sendToServer(String data) {
            NetworkStream serverStream = clientSocket.GetStream();
            Byte[] broadcastBytes = null;

            broadcastBytes = Encoding.Unicode.GetBytes(data);

            serverStream.Write(broadcastBytes, 0, broadcastBytes.Length);
            serverStream.Flush();
            serverStream = null;
        }

        // ---------------------------------------------------------- UPDATE USER LIST
        private void updateUserList(List<string> userList) {
            this.Invoke((MethodInvoker)delegate {
                listOnlineUsers.Items.Clear();

                foreach (string user in userList) {
                    listOnlineUsers.Items.Add(user);
                }
            });
        }

        // ---------------------------------------------------------- INITIALIZE TABS
        private void initializeSelectedTab() {
            this.Invoke((MethodInvoker)delegate {
                switch (tabControlMain.SelectedIndex) {
                    case 0:
                        // Message
                        messagingTabInit();
                        break;
                    case 1:
                        // Login
                        loginTabInit();
                        break;
                    case 2:
                        // Settings
                        settingsTabInit();
                        break;
                    default:
                        MessageBox.Show("What? How?", "Error?");
                        break;
                }
            });
        }

        // ---------------------------------------------------------- WRITE TO MESSAGE LOG
        private void logMessage(string message) {
            this.Invoke((MethodInvoker)delegate {
                Label lblMessage = new Label();
                isFirst = false;

                // Creating label that contains message
                lblMessage.Text = message;
                lblMessage.AutoSize = true;
                lblMessage.Padding = new Padding(5);

                // Adding label to table
                tableMessages.Controls.Add(lblMessage, 0, rowIndex);
                ++rowIndex;
            });
        }

        // ---------------------------------------------------------- WRITE TO INFO LABEL
        private void logInfo(string info) {
            // Runs update UI on UI home thread
            this.Invoke((MethodInvoker)delegate {
                lblInfo.Text = info;
            });
        }

        // ---------------------------------------------------------- LOG OUT
        private void logout() {
            string displayMessage;
            MessMessage outMessage;

            if (clientSocket != null) {
                if (clientSocket.Connected) {
                    outMessage = new MessMessage();
                    outMessage.type = MessageTypes.Terminate;
                    sendToServer(outMessage.toJSON());

                    messageThread.Abort();
                    clientSocket.Close();

                    displayMessage = String.Format("[{0}] You have disconnected",
                        DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
                    );
                    logMessage(displayMessage);
                }
            }

            reset();
        }

        // ---------------------------------------------------------- RESET
        private void reset() {
            isConnected = false;
            isLogin = false;
            name = "";

            this.Invoke((MethodInvoker)delegate {
                btnConnect.Text = "Connect to Server";

                listOnlineUsers.Items.Clear();
            });

            initializeSelectedTab();
        }

        // ---------------------------------------------------------- PLAY MESSAGE DING
        private void playMessageSound() {
            if (chkSettingsSound.Checked && false) {

                MessageBox.Show("Playing sound...");
                MessageBox.Show(messageSoundPlayer.IsLoadCompleted.ToString());
                
                messageSoundPlayer.PlaySync();
            }
        }

        // ---- END GENERAL FUNCTIONS



        // ------------------------------------------------------------------------------ MESSAGE THREAD FUNCTION
        private void recieveMessagesThread() {
            while (true) {
                int buffSize = 0;
                byte[] inBytes = new byte[65536];
                string messageJSON = "";
                MessMessage message;
                NetworkStream serverStream;

                try {

                    serverStream = clientSocket.GetStream();
                    buffSize = clientSocket.ReceiveBufferSize;
                    serverStream.Read(inBytes, 0, buffSize);

                    // Getting JSON string from bytes
                    messageJSON = Encoding.Unicode.GetString(inBytes);

                    // Getting message from raw JSON string
                    message = JsonConvert.DeserializeObject<MessMessage>(messageJSON);

                    // Getting content from message
                    dynamic content = JsonConvert.DeserializeObject(message.content);
                    String displayMessage;



                    switch (message.type) {
                        // GENERIC TYPELESS RESPONSE
                        case MessageTypes.GenericData:
                            logInfo("Server Response: " + content.message);
                            break;
                        // HANDSHAKE RESPONSE
                        case MessageTypes.HandshakeData:
                            if ((Boolean)content.isValid) {
                                initializeSelectedTab();
                            } else {
                                clientSocket.Close();
                            }

                            logInfo("Server Handshake Response: " + content.message);
                            break;

                        // REGISTERING RETURN DATA
                        case MessageTypes.RegisterData:
                            logInfo((String)content.message);
                            break;

                        // LOGIN RETURN DATA
                        case MessageTypes.LoginData:
                            isLogin = content.login;

                            if (isLogin) {
                                name = content.name;
                            }

                            logInfo((String)content.message);
                            initializeSelectedTab();
                            break;

                        // EDIT NAME
                        case MessageTypes.EditName:
                            logInfo((String)content.message);

                            if ((Boolean)content.isValid) {
                                name = (String)content.newName;
                            }
                            break;

                        // USER LIST
                        case MessageTypes.UserListUpdate:
                            List<string> userList = JsonConvert.DeserializeObject<List<string>>(message.content);
                            updateUserList(userList);
                            break;

                        // TEXT MESSAGE
                        case MessageTypes.TextMessage:
                            displayMessage = String.Format("[{0}] {1} >> {2}",
                                Utilities.UnixTimeStamp2DateTime(message.time).ToString("dd-MM-yyyy HH:mm:ss"),
                                content.author,
                                content.message
                            );

                            playMessageSound();

                            logMessage(displayMessage);
                            break;

                        // IMAGE MESSAGE
                        case MessageTypes.ImageMessage:
                            displayMessage = String.Format("[{0}] {1} IMAGE (TBA)>> {2}",
                                Utilities.UnixTimeStamp2DateTime(message.time).ToString("dd-MM-yyyy HH:mm:ss"),
                                content.author,
                                content.message
                                );
                            logMessage(displayMessage);
                            break;

                        // FILE MESSAGE
                        case MessageTypes.FileMessage:
                            displayMessage = String.Format("[{0}] {1} FILE (TBA)>> {2}",
                                Utilities.UnixTimeStamp2DateTime(message.time).ToString("dd-MM-yyyy HH:mm:ss"),
                                content.author,
                                content.message
                                );
                            logMessage(displayMessage);
                            break;
                        default:
                            logInfo("Unrecognized Server Response: " + content.message);
                            break;
                    }
                } catch (IOException) {
                    string displayMessage = String.Format("[{0}] Server has probably Shut Down...",
                        DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")
                    );
                    logMessage(displayMessage);

                    reset();
                    return;
                } catch (ObjectDisposedException) {
                    string displayMessage = "Server has terminated the connection: " + messageJSON;
                    logMessage(displayMessage);
                } catch (JsonReaderException) {
                    string displayMessage = "Server's response nonparseable: " + messageJSON;
                    logMessage(displayMessage);
                }
            }
        }

        // ---- END MESSAGE THREAD FUNCTION



        // ------------------------------------------------------------------------------ LISTENERS
        // ---------------------------------------------------------- WINDOW
        private void windowMain_FormClosing(object sender, FormClosingEventArgs e) {
            logout();
        }

        // ---------------------------------------------------------- CONNECT BUTTON
        private void btnConnect_Click(object sender, EventArgs e) {
            if (!isConnected) {
                socketsInit();
            } else {
                logout();
            }
        }

        // ---------------------------------------------------------- TABS
        private void tabControlMain_Selected(object sender, TabControlEventArgs e) {
            initializeSelectedTab();
        }

        // ---------------------------------------------------------- MESSAGING
        private void btnSendMessage_Click(object sender, EventArgs e) {
            txtMessage.Text = txtMessage.Text.Trim();
            if (txtMessage.Text == "") {
                return;
            }

            lblInfo.Text = "Sending Message...";

            dynamic content;
            MessMessage outMessage;

            content = new JObject();
            content.message = txtMessage.Text;

            outMessage = new MessMessage();
            outMessage.type = MessageTypes.TextMessage;
            outMessage.content = JsonConvert.SerializeObject(content);

            sendToServer(outMessage.toJSON());

            txtMessage.Text = "";

            lblInfo.Text = "Message sent";
        }
        private void menuStripItemSendImage_Click(object sender, EventArgs e) {
            // TODO Upload Image to server and then send link
            lblInfo.Text = "Image Attempt!";
        }
        private void menuStripItemSendFile_Click(object sender, EventArgs e) {
            // TODO Upload File to server and then send link
            lblInfo.Text = "File Attempt!";
        }
        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e) {
            if ((int)e.KeyChar == (int)Keys.Enter) {
                e.Handled = true;
                btnSendMessage_Click(sender, e);
            }
        }

        // ---------------------------------------------------------- LOGIN
        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter) {
                e.Handled = true;
                btnLogin_Click(sender, e);
            }
        }
        private void btnLogin_Click(object sender, EventArgs e) {
            txtLoginUsername.Text = txtLoginUsername.Text.Trim();
            txtLoginDisplayName.Text = txtLoginDisplayName.Text.Trim();
            txtLoginPassword.Text = txtLoginPassword.Text.Trim();
            txtLoginPassword2.Text = txtLoginPassword2.Text.Trim();

            if (!chkLoginRegistration.Checked) {
                Login();
            } else {
                Register();
            }
        }
        private void chkLoginRegistration_CheckedChanged(object sender, EventArgs e) {
            // Stop drawing login table
            DrawControl.SuspendDrawing(tabLogin);

            if (chkLoginRegistration.Checked) {
                foreach (RowStyle style in tableLayoutLoginDetails.RowStyles) {
                    style.Height = 20;
                }

                tableLayoutDisplayName.Height = 50;
                tableLayoutPassword2.Height = 50;

                tableLayoutDisplayName.Enabled = true;
                tableLayoutPassword2.Enabled = true;

                tableLayoutUsername.TabIndex = 1;
                tableLayoutDisplayName.TabIndex = 2;
                tableLayoutPassword.TabIndex = 3;
                tableLayoutPassword2.TabIndex = 4;

                groupBoxLogin.Text = "Registration";
                btnLogin.Text = "Register";

                btnLogin.Image = Properties.Resources.plus_32;
            } else {
                tableLayoutLoginDetails.RowStyles[1].Height = 0;
                tableLayoutLoginDetails.RowStyles[3].Height = 0;

                tableLayoutDisplayName.Enabled = false;
                tableLayoutPassword2.Enabled = false;

                groupBoxLogin.Text = "Login";
                btnLogin.Text = "Login";

                btnLogin.Image = Properties.Resources.key_32;
            }

            // Draw login table
            DrawControl.ResumeDrawing(tabLogin);
            Utilities.centerControl(tableLayoutLoginMain);
        }
        private void txtLoginPassword2_TextChanged(object sender, EventArgs e) {
            if(txtLoginPassword.Text == txtLoginPassword2.Text) {
                btnLogin.Enabled = true;
                logInfo("Passwords  match");
            } else {
                btnLogin.Enabled = false;
                logInfo("Passwords do not match!");
            }
        }

        // ---------------------------------------------------------- SETTINGS
        private void inputSettings_Changed(object sender, EventArgs e) {
            lblInfo.Text = "Settings changed, you may want to save";
        }
        private void btnSettingsRecievePortDefault_Click(object sender, EventArgs e) {
            numSettingsPort.Value = Properties.Settings.Default.clientPort;
        }
        private void inputSettings_KeyPress(object sender, KeyPressEventArgs e) {
            if ((int)e.KeyChar == (int)Keys.Enter) {
                e.Handled = true;

                btnSettingsSave_Click(sender, e);
            }
        }
        private void btnSettingsSave_Click(object sender, EventArgs e) {
            Properties.Settings.Default.serverLocation = txtSettingsServerLocation.Text;
            Properties.Settings.Default.clientPort = Decimal.ToInt32( numSettingsPort.Value );

            Properties.Settings.Default.Save();

            lblInfo.Text = "Settings saved correctly";
        }

        private void txtSettingsNameSave_KeyPress(object sender, KeyPressEventArgs e) {
            if ((int)e.KeyChar == (int)Keys.Enter) {
                e.Handled = true;

                btnSettingsNameSave_Click(sender, e);
            }
        }
        private void btnSettingsNameSave_Click(object sender, EventArgs e) {
            changeDisplayName();
        }
        
        // ---- END LISTENERS

    }
}
