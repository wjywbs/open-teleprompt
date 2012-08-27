using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace open_teleprompt
{
    public static class TeleSettings
    {
        static Color bgc, tc;
        static Font f;

        public static Color BackGroundColor
        {
            get { return bgc; }
            set { bgc = value; }
        }

        public static Color TextColor
        {
            get { return tc; }
            set { tc = value; }
        }

        public static Font TextFont
        {
            get { return f; }
            set { f = value; }
        }

        public static void LoadSettings()
        {
            bgc = Color.Blue;
            tc = Color.White;
            f = new Font("Arial", 30);
        }
    }
}
