namespace open_teleprompt
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainmenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.setToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintoolStrip = new System.Windows.Forms.ToolStrip();
            this.newtoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.opentoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.savetoolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.speechtxt = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainmenuStrip.SuspendLayout();
            this.maintoolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainmenuStrip
            // 
            this.mainmenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.teleToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainmenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainmenuStrip.Name = "mainmenuStrip";
            this.mainmenuStrip.Size = new System.Drawing.Size(782, 28);
            this.mainmenuStrip.TabIndex = 0;
            this.mainmenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveasToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.newToolStripMenuItem.Text = "新建";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saveToolStripMenuItem.Text = "保存";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveasToolStripMenuItem
            // 
            this.saveasToolStripMenuItem.Name = "saveasToolStripMenuItem";
            this.saveasToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saveasToolStripMenuItem.Text = "另存为";
            this.saveasToolStripMenuItem.Click += new System.EventHandler(this.saveasToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.quitToolStripMenuItem.Text = "退出";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // teleToolStripMenuItem
            // 
            this.teleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.toolStripSeparator2,
            this.setToolStripMenuItem});
            this.teleToolStripMenuItem.Name = "teleToolStripMenuItem";
            this.teleToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.teleToolStripMenuItem.Text = "提词";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.runToolStripMenuItem.Text = "开始";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(105, 6);
            // 
            // setToolStripMenuItem
            // 
            this.setToolStripMenuItem.Name = "setToolStripMenuItem";
            this.setToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.setToolStripMenuItem.Text = "设置";
            this.setToolStripMenuItem.Click += new System.EventHandler(this.setToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.helpToolStripMenuItem.Text = "帮助";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // maintoolStrip
            // 
            this.maintoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtoolStripButton,
            this.opentoolStripButton,
            this.savetoolStripButton,
            this.toolStripSeparator3});
            this.maintoolStrip.Location = new System.Drawing.Point(0, 28);
            this.maintoolStrip.Name = "maintoolStrip";
            this.maintoolStrip.Size = new System.Drawing.Size(782, 25);
            this.maintoolStrip.TabIndex = 1;
            this.maintoolStrip.Text = "maintoolStrip";
            // 
            // newtoolStripButton
            // 
            this.newtoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newtoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newtoolStripButton.Image")));
            this.newtoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newtoolStripButton.Name = "newtoolStripButton";
            this.newtoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newtoolStripButton.Text = "toolStripButton1";
            this.newtoolStripButton.Click += new System.EventHandler(this.newtoolStripButton_Click);
            // 
            // opentoolStripButton
            // 
            this.opentoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.opentoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("opentoolStripButton.Image")));
            this.opentoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.opentoolStripButton.Name = "opentoolStripButton";
            this.opentoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.opentoolStripButton.Text = "toolStripButton2";
            this.opentoolStripButton.Click += new System.EventHandler(this.opentoolStripButton_Click);
            // 
            // savetoolStripButton
            // 
            this.savetoolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.savetoolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("savetoolStripButton.Image")));
            this.savetoolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.savetoolStripButton.Name = "savetoolStripButton";
            this.savetoolStripButton.Size = new System.Drawing.Size(23, 22);
            this.savetoolStripButton.Text = "toolStripButton3";
            this.savetoolStripButton.Click += new System.EventHandler(this.savetoolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // speechtxt
            // 
            this.speechtxt.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.speechtxt.Location = new System.Drawing.Point(0, 53);
            this.speechtxt.Multiline = true;
            this.speechtxt.Name = "speechtxt";
            this.speechtxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.speechtxt.Size = new System.Drawing.Size(782, 500);
            this.speechtxt.TabIndex = 2;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "文本文档|*.txt|所有文件|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "文本文档|*.txt|所有文件|*.*";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.speechtxt);
            this.Controls.Add(this.maintoolStrip);
            this.Controls.Add(this.mainmenuStrip);
            this.MainMenuStrip = this.mainmenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "open-teleprompt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainmenuStrip.ResumeLayout(false);
            this.mainmenuStrip.PerformLayout();
            this.maintoolStrip.ResumeLayout(false);
            this.maintoolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainmenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip maintoolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton newtoolStripButton;
        private System.Windows.Forms.ToolStripButton opentoolStripButton;
        private System.Windows.Forms.ToolStripButton savetoolStripButton;
        private System.Windows.Forms.TextBox speechtxt;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem setToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

