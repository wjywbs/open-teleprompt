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
        static bool bflip, bstatus;
        static int draw_interval;
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

        public static bool TextFlip
        {
            get { return bflip; }
            set { bflip = value; }
        }

        public static bool ShowStatus
        {
            get { return bstatus; }
            set { bstatus = value; }
        }

        /// <summary>
        /// value in ms
        /// </summary>
        public static int DrawInterval
        {
            get { return draw_interval; }
            set { draw_interval = value; }
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
            f = new Font("黑体", 120); //new Font("Arial", 30);
            bflip = false;
            bstatus = true;
            draw_interval = 15;
            reporter_bgc = new List<reporter_bgcolor>();
            reporter_bgc.Add(new reporter_bgcolor("A:", Color.Blue));
            reporter_bgc.Add(new reporter_bgcolor("B:", Color.DarkGreen));
            reporter_bgc.Add(new reporter_bgcolor("C:", Color.DeepPink));
        }
    }
}
