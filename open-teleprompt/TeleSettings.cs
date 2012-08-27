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
        static List<reporter_bgcolor> reporter_bgc;

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

        public static List<reporter_bgcolor> reporter_bgcolor_array
        {
            get { return reporter_bgc; }
            set { reporter_bgc = value; }
        }

        public static void LoadSettings()
        {
            bgc = Color.Blue;
            tc = Color.White;
            f = new Font("Arial", 30);
            reporter_bgc = new List<reporter_bgcolor>();
            reporter_bgc.Add(new reporter_bgcolor("A:", Color.Blue));
            reporter_bgc.Add(new reporter_bgcolor("B:", Color.GreenYellow));
            reporter_bgc.Add(new reporter_bgcolor("C:", Color.Pink));
        }
    }
}
