using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace open_teleprompt
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void bok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void website_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!TeleSettings.UsingMono)
                System.Diagnostics.Process.Start("explorer.exe", "http://code.google.com/p/open-teleprompt/");
            else
                MessageBox.Show("http://code.google.com/p/open-teleprompt/", "Website", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
