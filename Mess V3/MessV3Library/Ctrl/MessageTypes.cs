using System.Collections.Generic;

namespace MessV3Library.Ctrl {
    public class MessageTypes {
        public Dictionary<int, string> typeNames = new Dictionary<int, string>() {
            { -10, "Invalid"},
            { -5 , "Edit Name"},
            { -3 , "Register"},
            { -2 , "Login"},
            { -1 , "Handshake"},
            {  0 , "Generic"},
            {  1 , "Text Message"},
            {  2 , "Image Message"},
            {  3 , "File Message"},
            {  4 , "User List Update"},
            {  10, "Terminate"}
        };

        // INTENDED USE: negatives are logic based, positives are message based
        public const int Invalid = -10;

        public const int EditName = -5;

        public const int RegisterData = -3;
        public const int LoginData = -2;
        public const int HandshakeData = -1;

        public const int GenericData = 0;

        public const int TextMessage = 1;
        public const int ImageMessage = 2;
        public const int FileMessage = 3;
        public const int UserListUpdate = 4;

        public const int Terminate = 10;
    }
}