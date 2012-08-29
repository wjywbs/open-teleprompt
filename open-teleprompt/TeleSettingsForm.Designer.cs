namespace open_teleprompt
{
    partial class TeleSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.telecolorDialog = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.telefontDialog = new System.Windows.Forms.FontDialog();
            this.fontchooser = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.colorchooser = new System.Windows.Forms.Label();
            this.bok = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.textflip = new System.Windows.Forms.CheckBox();
            this.showstatus = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "演播字体";
            // 
            // telefontDialog
            // 
            this.telefontDialog.FontMustExist = true;
            this.telefontDialog.ShowColor = true;
            // 
            // fontchooser
            // 
            this.fontchooser.AutoSize = true;
            this.fontchooser.Location = new System.Drawing.Point(131, 27);
            this.fontchooser.Name = "fontchooser";
            this.fontchooser.Size = new System.Drawing.Size(44, 17);
            this.fontchooser.TabIndex = 1;
            this.fontchooser.TabStop = true;
            this.fontchooser.Text = "font";
            this.fontchooser.UseMnemonic = false;
            this.fontchooser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fontchooser_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "演播背景色";
            // 
            // colorchooser
            // 
            this.colorchooser.AutoSize = true;
            this.colorchooser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colorchooser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorchooser.Location = new System.Drawing.Point(136, 63);
            this.colorchooser.Name = "colorchooser";
            this.colorchooser.Size = new System.Drawing.Size(26, 17);
            this.colorchooser.TabIndex = 3;
            this.colorchooser.Text = "  ";
            this.colorchooser.Click += new System.EventHandler(this.colorchooser_Click);
            // 
            // bok
            // 
            this.bok.Location = new System.Drawing.Point(370, 307);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(75, 27);
            this.bok.TabIndex = 4;
            this.bok.Text = "确定";
            this.bok.UseVisualStyleBackColor = true;
            this.bok.Click += new System.EventHandler(this.bok_Click);
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(471, 307);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(75, 27);
            this.bcancel.TabIndex = 5;
            this.bcancel.Text = "取消";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // textflip
            // 
            this.textflip.AutoSize = true;
            this.textflip.Location = new System.Drawing.Point(32, 97);
            this.textflip.Name = "textflip";
            this.textflip.Size = new System.Drawing.Size(132, 21);
            this.textflip.TabIndex = 6;
            this.textflip.Text = "文字水平翻转";
            this.textflip.UseVisualStyleBackColor = true;
            // 
            // showstatus
            // 
            this.showstatus.AutoSize = true;
            this.showstatus.Location = new System.Drawing.Point(32, 129);
            this.showstatus.Name = "showstatus";
            this.showstatus.Size = new System.Drawing.Size(115, 21);
            this.showstatus.TabIndex = 7;
            this.showstatus.Text = "显示状态栏";
            this.showstatus.UseVisualStyleBackColor = true;
            // 
            // TeleSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 355);
            this.Controls.Add(this.showstatus);
            this.Controls.Add(this.textflip);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bok);
            this.Controls.Add(this.colorchooser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fontchooser);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeleSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "演播设置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog telecolorDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog telefontDialog;
        private System.Windows.Forms.LinkLabel fontchooser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label colorchooser;
        private System.Windows.Forms.Button bok;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.CheckBox textflip;
        private System.Windows.Forms.CheckBox showstatus;
    }
}