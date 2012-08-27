using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace open_teleprompt
{
    public partial class Teleprompter : Form
    {
        int line_height, start_X;
        string txt;
        List<string> splines = new List<string>();
        //Font tfont;

        public Teleprompter()
        {
            InitializeComponent();
            this.Size = Screen.FromControl(this).Bounds.Size;
        }

        public string TeleText
        {
            set { value += " \r\n \r\n \r\n \r\n "; txt = value; sptxt.Text = value; }
        }

        public Font TeleFont
        {
            set { sptxt.Font = value; }
        }

        private void Teleprompter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
                this.Close();
        }

        void ProcessText()
        {
            int length = txt.Length, pos = 0;
            Point current, last = new Point(-1, -1);
            for (int i = 0; i < length; i++)
            {
                current = sptxt.GetPositionFromCharIndex(i);
                if (current.X < last.X) //new line detected
                {
                    splines.Add(txt.Substring(pos, i - pos));
                    pos = i;
                    line_height = current.Y - last.Y;
                    start_X = current.X;
                }
                last = current;
            }
            splines.Add(txt.Substring(pos, length - pos));
        }

        public new DialogResult ShowDialog()
        {
            ProcessText();

            this.Controls.Remove(sptxt);
            teletimer.Start();
            return base.ShowDialog();
        }

        private void Teleprompter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void teletimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
