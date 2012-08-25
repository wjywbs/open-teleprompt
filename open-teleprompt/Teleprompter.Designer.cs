namespace open_teleprompt
{
    partial class Teleprompter
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
            this.sptxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // sptxt
            // 
            this.sptxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptxt.Location = new System.Drawing.Point(0, 0);
            this.sptxt.Multiline = true;
            this.sptxt.Name = "sptxt";
            this.sptxt.Size = new System.Drawing.Size(800, 600);
            this.sptxt.TabIndex = 0;
            this.sptxt.Visible = false;
            // 
            // Teleprompter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.sptxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Teleprompter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Teleprompter";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Teleprompter_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sptxt;
    }
}