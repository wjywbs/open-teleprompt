using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Diagnostics;

namespace open_teleprompt
{
    public partial class Teleprompter : Form
    {
        int line_height, start_X;
        int img_current_Y, speed, delta, img_height, hmax;
        string txt, line_end = "\r\n";
        List<string> splines = new List<string>();
        List<Color> splc = new List<Color>();
        Image img;
        Size scr;

        public Teleprompter()
        {
            InitializeComponent();
            scr = Screen.FromControl(this).Bounds.Size;
            this.Size = scr;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
            this.MouseWheel += new MouseEventHandler(Teleprompter_MouseWheel);
        }

        public string TeleText
        {
            set { value += " "; txt = value; sptxt.Text = value; }
        }

        private void Teleprompter_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            else if (e.KeyCode == Keys.Home)
                ResetState(0, 0);
            else if (e.KeyCode == Keys.End)
                ResetState(0, hmax);
        }

        void ProcessText()
        {
            List<reporter_bgcolor> rb = TeleSettings.reporter_bgcolor_array;
            string[] lines = sptxt.Lines;
            List<Color> lc = new List<Color>();
            for (int i = 0; i < lines.Length; i++)
            {
                lc.Add(TeleSettings.BackGroundColor);
                for (int j = 0; j < rb.Count; j++)
                {
                    if (lines[i].StartsWith(rb[j].prefix))
                        lc[i] = rb[j].color;
                }
            }

            string ls;
            int length = txt.Length, pos = 0, line = 0;
            Point current, last = new Point(-1, -1);
            sptxt.Font = TeleSettings.TextFont;
            for (int i = 0; i < length; i++)
            {
                current = sptxt.GetPositionFromCharIndex(i);
                if (current.X < last.X) //new line detected
                {
                    ls = txt.Substring(pos, i - pos);
                    splines.Add(ls);
                    splc.Add(lc[line]);
                    if (ls.EndsWith(line_end))
                        line++;
                    pos = i;
                    line_height = current.Y - last.Y;
                    start_X = current.X;
                }
                last = current;
            }
            splines.Add(txt.Substring(pos, length - pos));
            splc.Add(lc[line]);
        }

        void DrawText()
        {
            int start_Y = scr.Height / 4 * 3, y = start_Y;
            img_height = start_Y + (line_height + 20) * splines.Count + start_Y;
            img = new Bitmap(scr.Width, img_height);
            Graphics g = Graphics.FromImage(img);
            g.FillRectangle(new SolidBrush(TeleSettings.BackGroundColor), 0, 0, img.Width, img.Height);
            for (int i = 0; i < splines.Count; i++)
            {
                g.FillRectangle(new SolidBrush(splc[i]), 0, y, img.Width, line_height);
                g.DrawString(splines[i], TeleSettings.TextFont, new SolidBrush(TeleSettings.TextColor), start_X, y);
                y += line_height;
            }
            if (TeleSettings.TextFlip)
                img.RotateFlip(RotateFlipType.RotateNoneFlipX);
        }

        void SetParams()
        {
            img_current_Y = 0;
            hmax = img_height - scr.Height;
            delta = scr.Height / 10 / (1000 / teletimer.Interval); //one tenth of screen per second
        }

        void ResetState(int cspeed, int imgY)
        {
            speed = cspeed;
            img_current_Y = imgY;
        }

        public new DialogResult ShowDialog()
        {
            ProcessText();
            DrawText();
            SetParams();

            this.Controls.Remove(sptxt);
            Invalidate();
            teletimer.Start();
            return base.ShowDialog();
        }

        private void Teleprompter_Paint(object sender, PaintEventArgs e)
        {
            if (img_current_Y > hmax)
                ResetState(0, hmax);
            else if (img_current_Y < 0)
                ResetState(0, 0);
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            e.Graphics.DrawImage(img, 0, -img_current_Y); // takes 7ms
            //sw.Stop();
        }

        private void teletimer_Tick(object sender, EventArgs e)
        {
            img_current_Y += speed * delta;
            Invalidate();
        }

        void Teleprompter_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                speed++;
            else if (e.Button == MouseButtons.Right)
                speed--;
        }

        void Teleprompter_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
                speed++;
            else
                speed--;
        }
    }
}
