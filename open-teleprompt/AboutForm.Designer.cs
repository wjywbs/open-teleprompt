namespace open_teleprompt
{
    partial class AboutForm
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
            this.bok = new System.Windows.Forms.Button();
            this.softtitle = new System.Windows.Forms.Label();
            this.intro = new System.Windows.Forms.TextBox();
            this.website = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // bok
            // 
            this.bok.Location = new System.Drawing.Point(105, 216);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(94, 31);
            this.bok.TabIndex = 0;
            this.bok.Text = "确定";
            this.bok.UseVisualStyleBackColor = true;
            this.bok.Click += new System.EventHandler(this.bok_Click);
            // 
            // softtitle
            // 
            this.softtitle.AutoSize = true;
            this.softtitle.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.softtitle.Location = new System.Drawing.Point(42, 15);
            this.softtitle.Name = "softtitle";
            this.softtitle.Size = new System.Drawing.Size(221, 26);
            this.softtitle.TabIndex = 1;
            this.softtitle.Text = "open-teleprompt";
            // 
            // intro
            // 
            this.intro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.intro.Font = new System.Drawing.Font("Arial", 10F);
            this.intro.Location = new System.Drawing.Point(41, 54);
            this.intro.Multiline = true;
            this.intro.Name = "intro";
            this.intro.ReadOnly = true;
            this.intro.Size = new System.Drawing.Size(222, 123);
            this.intro.TabIndex = 3;
            this.intro.Text = "An open source teleprompter software for TV stations.\r\n\r\nLicense: GNU GPL v3\r\n\r\nA" +
                "uthor: wjywbss";
            // 
            // website
            // 
            this.website.AutoSize = true;
            this.website.Font = new System.Drawing.Font("宋体", 10F);
            this.website.Location = new System.Drawing.Point(81, 184);
            this.website.Name = "website";
            this.website.Size = new System.Drawing.Size(143, 17);
            this.website.TabIndex = 4;
            this.website.TabStop = true;
            this.website.Text = "Project Website";
            this.website.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.website_LinkClicked);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 259);
            this.Controls.Add(this.website);
            this.Controls.Add(this.intro);
            this.Controls.Add(this.softtitle);
            this.Controls.Add(this.bok);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "关于 open-teleprompt v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bok;
        private System.Windows.Forms.Label softtitle;
        private System.Windows.Forms.TextBox intro;
        private System.Windows.Forms.LinkLabel website;
    }
}