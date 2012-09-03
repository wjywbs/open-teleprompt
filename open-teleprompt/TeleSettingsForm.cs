using System;
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
            textflip.Checked = TeleSettings.TextFlip;
            showstatus.Checked = TeleSettings.ShowStatus;
            drawinterval.Text = TeleSettings.DrawInterval.ToString();
            List<reporter_bgcolor> rbl = TeleSettings.reporter_bgcolor_array;
            foreach (reporter_bgcolor rb in rbl)
                AddReporterBgcItem(rb.prefix, rb.color);
            if (Environment.OSVersion.Version.Major >= 6)
                rintro.BackColor = Color.White;
        }

        void AddReporterBgcItem(string prefix, Color color)
        {
            ListViewItem lvi = new ListViewItem(prefix);
            lvi.UseItemStyleForSubItems = false;
            ListViewItem.ListViewSubItem lvsi = new ListViewItem.ListViewSubItem();
            lvsi.Font = new Font(lvsi.Font, FontStyle.Bold);
            lvsi.Text = color.Name;
            lvsi.ForeColor = color;
            lvi.SubItems.Add(lvsi);
            lrset.Items.Add(lvi);
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
            TeleSettings.TextColor = ctmp;
            TeleSettings.BackGroundColor = colorchooser.BackColor;
            TeleSettings.TextFlip = textflip.Checked;
            TeleSettings.ShowStatus = showstatus.Checked;
            int dwi; int.TryParse(drawinterval.Text, out dwi);
            if (dwi < 0 || dwi > 300)
            {
                dwi = 15;
                MessageBox.Show("屏幕刷新间隔不可小于0或大于300，将恢复为默认值15。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TeleSettings.DrawInterval = dwi;
            List<reporter_bgcolor> rbl = new List<reporter_bgcolor>();
            foreach (ListViewItem lvi in lrset.Items)
                rbl.Add(new reporter_bgcolor(lvi.Text, lvi.SubItems[1].ForeColor));
            TeleSettings.reporter_bgcolor_array = rbl;
            TeleSettings.SaveSettings();
            this.Close();
        }

        private void bcancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bradd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddReporterBgcItem("New", Color.Blue);
        }

        private void brdel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lrset.SelectedIndices.Count == 1)
                lrset.Items.RemoveAt(lrset.SelectedIndices[0]);
        }

        private void lrset_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            foreach (ListViewItem lvi in lrset.Items)
            {
                ListViewItem.ListViewSubItem lvsi = lvi.SubItems[1];
                Rectangle r = lvsi.Bounds; // get the bound of the color subitem
                if (e.X >= r.X && e.X <= r.X + r.Width && e.Y >= r.Y && e.Y <= r.Y + r.Height)
                    rbgcolor_Click(lvsi);
            }
        }

        void rbgcolor_Click(ListViewItem.ListViewSubItem lvsi)
        {
            telecolorDialog.Color = lvsi.ForeColor;
            telecolorDialog.ShowDialog();
            lvsi.ForeColor = telecolorDialog.Color;
            lvsi.Text = telecolorDialog.Color.Name;
        }
    }
}
