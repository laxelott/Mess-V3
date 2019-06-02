namespace MessV3Library.Ctrl {
    public class MessageTypes {
        public const int Invalid = -10;

        public const int EditName = -4;

        public const int RegisterData = -2;
        public const int LoginData = -1;
        public const int HandshakeData = 0;

        public const int TextMessage = 1;
        public const int ImageMessage = 2;
        public const int FileMessage = 3;
        public const int UserListUpdate = 4;

        public const int Terminate = 10;

    }
}