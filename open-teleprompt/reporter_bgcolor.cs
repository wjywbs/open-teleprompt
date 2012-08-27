using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

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
    }
}
