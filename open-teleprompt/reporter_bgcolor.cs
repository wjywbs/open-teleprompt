using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Xml;

namespace open_teleprompt
{
    public class reporter_bgcolor
    {
        string rprefix;
        Color c;

        public reporter_bgcolor(string prefix, Color color)
        {
            rprefix = prefix;
            c = color;
        }

        public reporter_bgcolor(XmlReader reader)
        {
            rprefix = XmlHelper.ReadStringAttribute(reader, "prefix");
            c = Color.FromArgb(int.Parse(reader.GetAttribute("color")));
        }

        public string prefix
        {
            get { return rprefix; }
            set { rprefix = value; }
        }

        public Color color
        {
            get { return c; }
            set { c = value; }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("reporter_bgcolor");
            writer.WriteAttributeString("prefix", rprefix);
            writer.WriteAttributeString("color", c.ToArgb().ToString());
            writer.WriteEndElement();
        }
    }
}
