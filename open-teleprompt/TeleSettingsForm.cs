﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace open_teleprompt
{
    public partial class TeleSettingsForm : Form
    {
        Font ftmp;
        Color ctmp;

        public TeleSettingsForm()
        {
            InitializeComponent();
            colorchooser.BackColor = TeleSettings.BackGroundColor;
            ftmp = TeleSettings.TextFont;
            ctmp = TeleSettings.TextColor;
            SetFontString(ftmp, ctmp);
        }

        void SetFontString(Font f, Color c)
        {
            fontchooser.Text = f.FontFamily.Name + ", " + f.SizeInPoints.ToString() + "pt, " + c.ToString();
        }

        private void colorchooser_Click(object sender, EventArgs e)
        {
            telecolorDialog.Color = colorchooser.BackColor;
            telecolorDialog.ShowDialog();
            colorchooser.BackColor = telecolorDialog.Color;
        }

        private void fontchooser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            telefontDialog.Font = ftmp;
            telefontDialog.Color = ctmp;
            try
            {
                telefontDialog.ShowDialog();
            }
            catch { MessageBox.Show("不支持本字体", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            ftmp = telefontDialog.Font;
            ctmp = telefontDialog.Color;
            SetFontString(ftmp, ctmp);
        }

        private void bok_Click(object sender, EventArgs e)
        {
            TeleSettings.TextFont = ftmp;
            TeleSettings.BackGroundColor = colorchooser.BackColor;
            this.Close();
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}