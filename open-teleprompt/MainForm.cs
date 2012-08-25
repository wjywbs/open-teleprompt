using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace open_teleprompt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainForm_Resize(null, null);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            speechtxt.Size = new Size(this.Size.Width - speechtxt.Location.X - 15, this.Size.Height - speechtxt.Location.Y - 40);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Teleprompter tp = new Teleprompter();
            tp.TeleText = speechtxt.Text;
            tp.ShowDialog();
            Point str = speechtxt.GetPositionFromCharIndex(50);

            this.Show();
        }
    }
}
