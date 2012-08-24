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
            speechtxt.Size = new Size(this.Size.Width - speechtxt.Location.X, this.Size.Height - speechtxt.Location.Y);
        }
    }
}
