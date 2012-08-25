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
        string txt;
        //Font tfont;

        public Teleprompter()
        {
            InitializeComponent();
            this.Size = Screen.FromControl(this).Bounds.Size;
        }

        public string TeleText
        {
            set { txt = value; sptxt.Text = value; }
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

        public DialogResult ShowDialog()
        {

            return base.ShowDialog();
        }
    }
}
