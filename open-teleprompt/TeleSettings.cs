using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;
using System.Windows.Forms;

namespace open_teleprompt
{
    public static class TeleSettings
    {
        static Color bgc, tc;
        static Font f;
        static bool bflip, bstatus, using_mono;
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

        public static bool UsingMono
        {
            get { return using_mono; }
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
            f = new Font("Arial", 120);
            bflip = false;
            bstatus = true;
            draw_interval = 15;
            using_mono = (Type.GetType("Mono.Runtime") != null);
            reporter_bgc = new List<reporter_bgcolor>();
            // Add sample patterns
            reporter_bgc.Add(new reporter_bgcolor("A:", Color.Blue));
            reporter_bgc.Add(new reporter_bgcolor("B:", Color.DarkGreen));
            reporter_bgc.Add(new reporter_bgcolor("C:", Color.DeepPink));

            try
            {
                XmlReader reader = XmlReader.Create("open-teleprompt.xml");
                reader.ReadToFollowing("TeleSettings");
                bgc = XmlHelper.ReadColor(reader);
                tc = XmlHelper.ReadColor(reader);
                f = XmlHelper.ReadFont(reader);
                bflip = bool.Parse(XmlHelper.ReadStringValue(reader));
                bstatus = bool.Parse(XmlHelper.ReadStringValue(reader));
                draw_interval = int.Parse(XmlHelper.ReadStringValue(reader));
                int c = int.Parse(XmlHelper.ReadStringAttribute(reader, "count"));
                reporter_bgc.Clear();
                for (int i = 0; i < c; i++)
                    reporter_bgc.Add(new reporter_bgcolor(reader));
                reader.Close();
            }
            catch (Exception) { }
        }

        public static void SaveSettings()
        {
            XmlWriterSettings xws = new XmlWriterSettings();
            xws.Indent = true;
            xws.IndentChars = "\t";
            xws.Encoding = Encoding.UTF8;

            XmlWriter writer = XmlWriter.Create("open-teleprompt.xml", xws);
            writer.WriteStartDocument();
            writer.WriteStartElement("TeleSettings");

            XmlHelper.WriteColor(writer, "BackGroundColor", bgc);
            XmlHelper.WriteColor(writer, "TextColor", tc);
            XmlHelper.WriteFont(writer, "TextFont", f);

            writer.WriteStartElement("TextFlip");
            writer.WriteValue(bflip);
            writer.WriteEndElement();

            writer.WriteStartElement("ShowStatus");
            writer.WriteValue(bstatus);
            writer.WriteEndElement();

            writer.WriteStartElement("DrawInterval");
            writer.WriteValue(draw_interval);
            writer.WriteEndElement();

            writer.WriteStartElement("reporter_bgcolor_list");
            writer.WriteAttributeString("count", reporter_bgc.Count.ToString());
            foreach (reporter_bgcolor rb in reporter_bgc)
                rb.WriteXml(writer);
            writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Close();
        }
    }
}
