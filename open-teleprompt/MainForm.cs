using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace open_teleprompt
{
    public partial class MainForm : Form
    {
        string file_current = "";

        public MainForm()
        {
            InitializeComponent();
            TeleSettings.LoadSettings();
            MainForm_Resize(null, null);
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (TeleSettings.UsingMono || Environment.OSVersion.Version.Major < 6)
            {
                speechtxt.Size = new Size(this.Size.Width - speechtxt.Location.X - 5, this.Size.Height - speechtxt.Location.Y - 25);
            }
            else
                speechtxt.Size = new Size(this.Size.Width - speechtxt.Location.X - 15, this.Size.Height - speechtxt.Location.Y - 40);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            Teleprompter tp = new Teleprompter();
            tp.TeleText = speechtxt.Text;
            tp.ShowDialog();
            tp.Dispose();
            GC.Collect();

            this.Show();
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeleSettingsForm tsf = new TeleSettingsForm();
            tsf.ShowDialog();
        }

        void handle_new()
        {
            if (asksave())
            {
                speechtxt.Text = "";
                file_current = "";
                speechtxt.ClearUndo();
            }
        }

        bool asksave()
        {
            if (speechtxt.CanUndo)
            {
                DialogResult dr = MessageBox.Show("文档已改变，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    if (save())
                        return true;
                    else
                        return false;
                }
                else if (dr == DialogResult.No)
                    return true;
                else
                    return false;
            }
            return true;
        }

        bool save()
        {
            if (file_current == "")
            {
                saveFileDialog1.FileName = "";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName == "")
                    return false;
                file_current = saveFileDialog1.FileName;
            }
            savefile();
            speechtxt.ClearUndo();
            return true;
        }

        void savefile()
        {
            StreamWriter sw = new StreamWriter(file_current, false);
            sw.Write(speechtxt.Text);
            sw.Close();
        }

        void open()
        {
            if (asksave())
            {
                openFileDialog1.FileName = "";
                openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "" && File.Exists(openFileDialog1.FileName))
                {
                    file_current = openFileDialog1.FileName;
                    openfile();
                }
            }
        }

        void openfile()
        {
            StreamReader sr = new StreamReader(file_current);
            speechtxt.Text = sr.ReadToEnd();
            sr.Close();
            speechtxt.ClearUndo();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!asksave())
                e.Cancel = true;
        }

        private void newtoolStripButton_Click(object sender, EventArgs e)
        {
            handle_new();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            handle_new();
        }

        private void opentoolStripButton_Click(object sender, EventArgs e)
        {
            open();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void savetoolStripButton_Click(object sender, EventArgs e)
        {
            save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fold = file_current;
            file_current = "";
            if (!save())
                file_current = fold;
        }

        AboutForm af;
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (af == null || af.IsDisposed)
            {
                af = new AboutForm();
                af.Show();
            }
        }
    }
}
