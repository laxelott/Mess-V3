using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MessV3Server.db {
    public class cDatos {

        private MySqlConnection connection;

        private string server;
        private string database;
        private string username;
        private string password;

        private string errorMessage;
        private MySqlCommand preparedCommand;

        //Constructor
        public cDatos() {
            Initialize();
        }

        //Initialize values
        private void Initialize() {
            server = "localhost";
            database = "messv3";
            username = "root";
            password = "n0m3l0";

            string connectionString =
                "SERVER=" + server +";" +
                "DATABASE=" + database + ";" +
                "UID=" + username + ";" +
                "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        // Connection
        public bool OpenConnection() {
            try {
                connection.Open();
                return true;
            }
            catch (MySqlException ex) {
                //When handling errors, you can your application's response based on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number) {
                    case 0:
                        errorMessage = "Cannot connect to database";
                        break;

                    case 1045:
                        errorMessage = "Invalid username/password";
                        break;
                }
                return false;
            }
        }
        public bool CloseConnection() {
            try {
                connection.Close();
                return true;
            }
            catch (MySqlException ex) {
                errorMessage = ex.Message;
                return false;
            }
        }

        // Statements
        public MySqlDataReader Query(string query) {
            return new MySqlCommand(query, connection).ExecuteReader();
        }
        public void Update(string update) {
            new MySqlCommand(update, connection).ExecuteNonQuery();
        }

        // ------------------------------------------------------------- PREPARED STATEMENTS
        // ------------------------------------ SET UP
        public void setPreparedStatement(string statement) {
            preparedCommand = new MySqlCommand(statement, connection);
        }
        public void setPreparedVariables(Dictionary<string, object> variables) {
            foreach (KeyValuePair<string, object> variable in variables) {
                preparedCommand.Parameters.AddWithValue(variable.Key, variable.Value);
            }
        }

        // ------------------------------------ EXECUTE 
        public MySqlDataReader runPreparedStatement() {
            return preparedCommand.ExecuteReader();
        }
        public void runPreparedUpdate() {
            preparedCommand.ExecuteNonQuery();
        }

    }
}
