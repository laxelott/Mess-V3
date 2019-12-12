namespace MessV3Library.Ctrl {
    public class MessClient {

        // TODO: Add variable getter and setters and make variables private
        public int id { get; set; } = -1;
        public string name { get; set; } = "";
        public bool isLogin { get; set; } = false;
        public bool isMuted { get; set; } = false;


        public override string ToString() {
            return name + (isMuted ? " [muted]" : "");
        }
    }
}
