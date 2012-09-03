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
            this.components = new System.ComponentModel.Container();
            this.sptxt = new System.Windows.Forms.TextBox();
            this.teletimer = new System.Windows.Forms.Timer(this.components);
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
            // 
            // teletimer
            // 
            this.teletimer.Interval = 15;
            this.teletimer.Tick += new System.EventHandler(this.teletimer_Tick);
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
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Teleprompter_MouseUp);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Teleprompter_Paint);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Teleprompter_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Teleprompter_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sptxt;
        private System.Windows.Forms.Timer teletimer;
    }
}