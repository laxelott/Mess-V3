using System;
using System.Windows.Forms;

namespace MessV3Library.Util
{
    public class Utilities
    {
        // Control Utilities
        public static void centerControl(Control ctrlToCenter) {
            centerVertically(ctrlToCenter);
            centerHorizontally(ctrlToCenter);
        }

        public static void centerVertically(Control ctrlToCenter) {
            ctrlToCenter.Top = (ctrlToCenter.Parent.Height - ctrlToCenter.Height) / 2;
        }
        public static void centerHorizontally(Control ctrlToCenter) {
            ctrlToCenter.Left = (ctrlToCenter.Parent.Width - ctrlToCenter.Width) / 2;
        }

        // Time Utilities
        public static DateTime UnixTimeStamp2DateTime(double unixTimeStamp)
        {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTimeStamp).ToLocalTime();
        }
        public static double DateTime2UnixTimeStamp(DateTime dateTime) {
            DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            return (dateTime.Subtract(epoch)).TotalSeconds;
        }
    }
}
