using Newtonsoft.Json;

namespace MessV3Library.Ctrl {
    public class MessMessage {
        public int type { get; set; } = MessageTypes.Invalid;
        public double time { get; set; } = 0;
        public string content { get; set; } = "{ }";

        public string toJSON() {
            return JsonConvert.SerializeObject(this);
        }
        public override string ToString() {
            return string.Format(
            "Type: {0}, Time: {1}, Content: {2}",
            type, time, content);
        }
    }
}
