using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Drawing;

namespace open_teleprompt
{
    public static class XmlHelper
    {
        public static void move_reader(XmlReader reader)
        {
            reader.Read();
            while (reader.NodeType != XmlNodeType.Element)
                reader.Read();
        }

        public static string ReadStringValue(XmlReader reader)
        {
            move_reader(reader);
            reader.Read();
            return reader.Value;
        }

        public static string ReadStringAttribute(XmlReader reader, string name)
        {
            move_reader(reader);
            return reader.GetAttribute(name);
        }

        public static Color ReadColor(XmlReader reader)
        {
            move_reader(reader);
            return ReadColorAttribute(reader);
        }

        public static Color ReadColorAttribute(XmlReader reader)
        {
            if (reader.GetAttribute("name") != null)
                return Color.FromName(reader.GetAttribute("name"));
            int result = 0;
            int.TryParse(reader.GetAttribute("argb"), out result);
            return Color.FromArgb(result);
        }

        public static Font ReadFont(XmlReader reader)
        {
            move_reader(reader);
            float num;
            string attribute = reader.GetAttribute("Name");
            float.TryParse(reader.GetAttribute("Size"), out num);
            FontStyle style = (FontStyle)Enum.Parse(typeof(FontStyle), reader.GetAttribute("Style"));
            return new Font(attribute, num, style, (GraphicsUnit)Enum.Parse(typeof(GraphicsUnit), reader.GetAttribute("Unit")));
        }

        public static void WriteColor(XmlWriter writer, string name, Color c)
        {
            writer.WriteStartElement(name);
            WriteColorAttribute(writer, c);
            writer.WriteEndElement();
        }

        public static void WriteColorAttribute(XmlWriter writer, Color c)
        {
            if (c.IsKnownColor)
                writer.WriteAttributeString("name", c.Name);
            else
                writer.WriteAttributeString("argb", c.ToArgb().ToString());
        }

        public static void WriteFont(XmlWriter writer, string name, Font f)
        {
            writer.WriteStartElement(name);
            writer.WriteAttributeString("Name", f.Name);
            writer.WriteAttributeString("Size", f.Size.ToString());
            writer.WriteAttributeString("Style", f.Style.ToString());
            writer.WriteAttributeString("Unit", f.Unit.ToString());
            writer.WriteEndElement();
        }
    }
}
