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
            this.telefontDialog = new System.Windows.Forms.FontDialog();
            this.bok = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabgeneral = new System.Windows.Forms.TabPage();
            this.drawinterval = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.showstatus = new System.Windows.Forms.CheckBox();
            this.textflip = new System.Windows.Forms.CheckBox();
            this.colorchooser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fontchooser = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabreporter = new System.Windows.Forms.TabPage();
            this.brdel = new System.Windows.Forms.LinkLabel();
            this.bradd = new System.Windows.Forms.LinkLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lrset = new System.Windows.Forms.ListView();
            this.lprefix = new System.Windows.Forms.ColumnHeader();
            this.lcolor = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tabgeneral.SuspendLayout();
            this.tabreporter.SuspendLayout();
            this.SuspendLayout();
            // 
            // telecolorDialog
            // 
            this.telecolorDialog.FullOpen = true;
            // 
            // telefontDialog
            // 
            this.telefontDialog.FontMustExist = true;
            this.telefontDialog.ShowColor = true;
            // 
            // bok
            // 
            this.bok.Location = new System.Drawing.Point(370, 319);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(75, 27);
            this.bok.TabIndex = 4;
            this.bok.Text = "确定";
            this.bok.UseVisualStyleBackColor = true;
            this.bok.Click += new System.EventHandler(this.bok_Click);
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(482, 319);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(75, 27);
            this.bcancel.TabIndex = 5;
            this.bcancel.Text = "取消";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabgeneral);
            this.tabControl1.Controls.Add(this.tabreporter);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(582, 313);
            this.tabControl1.TabIndex = 14;
            // 
            // tabgeneral
            // 
            this.tabgeneral.Controls.Add(this.drawinterval);
            this.tabgeneral.Controls.Add(this.label3);
            this.tabgeneral.Controls.Add(this.showstatus);
            this.tabgeneral.Controls.Add(this.textflip);
            this.tabgeneral.Controls.Add(this.colorchooser);
            this.tabgeneral.Controls.Add(this.label2);
            this.tabgeneral.Controls.Add(this.fontchooser);
            this.tabgeneral.Controls.Add(this.label1);
            this.tabgeneral.Location = new System.Drawing.Point(4, 27);
            this.tabgeneral.Name = "tabgeneral";
            this.tabgeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tabgeneral.Size = new System.Drawing.Size(574, 282);
            this.tabgeneral.TabIndex = 0;
            this.tabgeneral.Text = "基本";
            this.tabgeneral.UseVisualStyleBackColor = true;
            // 
            // drawinterval
            // 
            this.drawinterval.Location = new System.Drawing.Point(219, 92);
            this.drawinterval.MaxLength = 3;
            this.drawinterval.Name = "drawinterval";
            this.drawinterval.Size = new System.Drawing.Size(57, 27);
            this.drawinterval.TabIndex = 17;
            this.drawinterval.Text = "15";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "屏幕刷新间隔（毫秒）";
            // 
            // showstatus
            // 
            this.showstatus.AutoSize = true;
            this.showstatus.Location = new System.Drawing.Point(30, 162);
            this.showstatus.Name = "showstatus";
            this.showstatus.Size = new System.Drawing.Size(115, 21);
            this.showstatus.TabIndex = 15;
            this.showstatus.Text = "显示状态栏";
            this.showstatus.UseVisualStyleBackColor = true;
            // 
            // textflip
            // 
            this.textflip.AutoSize = true;
            this.textflip.Location = new System.Drawing.Point(30, 130);
            this.textflip.Name = "textflip";
            this.textflip.Size = new System.Drawing.Size(132, 21);
            this.textflip.TabIndex = 14;
            this.textflip.Text = "文字水平翻转";
            this.textflip.UseVisualStyleBackColor = true;
            // 
            // colorchooser
            // 
            this.colorchooser.AutoSize = true;
            this.colorchooser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.colorchooser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorchooser.Location = new System.Drawing.Point(221, 60);
            this.colorchooser.Name = "colorchooser";
            this.colorchooser.Size = new System.Drawing.Size(26, 17);
            this.colorchooser.TabIndex = 13;
            this.colorchooser.Text = "  ";
            this.colorchooser.Click += new System.EventHandler(this.colorchooser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "演播背景色";
            // 
            // fontchooser
            // 
            this.fontchooser.AutoSize = true;
            this.fontchooser.Location = new System.Drawing.Point(217, 24);
            this.fontchooser.Name = "fontchooser";
            this.fontchooser.Size = new System.Drawing.Size(44, 17);
            this.fontchooser.TabIndex = 11;
            this.fontchooser.TabStop = true;
            this.fontchooser.Text = "font";
            this.fontchooser.UseMnemonic = false;
            this.fontchooser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.fontchooser_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "演播字体";
            // 
            // tabreporter
            // 
            this.tabreporter.Controls.Add(this.brdel);
            this.tabreporter.Controls.Add(this.bradd);
            this.tabreporter.Controls.Add(this.textBox1);
            this.tabreporter.Controls.Add(this.lrset);
            this.tabreporter.Location = new System.Drawing.Point(4, 27);
            this.tabreporter.Name = "tabreporter";
            this.tabreporter.Padding = new System.Windows.Forms.Padding(3);
            this.tabreporter.Size = new System.Drawing.Size(574, 282);
            this.tabreporter.TabIndex = 1;
            this.tabreporter.Text = "播音员";
            this.tabreporter.UseVisualStyleBackColor = true;
            // 
            // brdel
            // 
            this.brdel.AutoSize = true;
            this.brdel.Location = new System.Drawing.Point(147, 245);
            this.brdel.Name = "brdel";
            this.brdel.Size = new System.Drawing.Size(42, 17);
            this.brdel.TabIndex = 19;
            this.brdel.TabStop = true;
            this.brdel.Text = "删除";
            this.brdel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.brdel_LinkClicked);
            // 
            // bradd
            // 
            this.bradd.AutoSize = true;
            this.bradd.Location = new System.Drawing.Point(73, 245);
            this.bradd.Name = "bradd";
            this.bradd.Size = new System.Drawing.Size(42, 17);
            this.bradd.TabIndex = 18;
            this.bradd.TabStop = true;
            this.bradd.Text = "添加";
            this.bradd.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bradd_LinkClicked);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(14, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(261, 210);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "可以为每一名播音员设置文字背景色。以设置的前缀开头的段落将显示特定背景色。\r\n\r\n操作说明：\r\n    点击添加按钮新建一条播音员背景色设置。\r\n    点击需要" +
                "修改的前缀，再点击一次该前缀进行修改。点击颜色名称可修改背景色。\r\n    点击需要删除的一条设置的前缀，再点击删除按钮删除设置。";
            // 
            // lrset
            // 
            this.lrset.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lprefix,
            this.lcolor});
            this.lrset.GridLines = true;
            this.lrset.LabelEdit = true;
            this.lrset.Location = new System.Drawing.Point(284, 17);
            this.lrset.MultiSelect = false;
            this.lrset.Name = "lrset";
            this.lrset.Size = new System.Drawing.Size(269, 245);
            this.lrset.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lrset.TabIndex = 15;
            this.lrset.UseCompatibleStateImageBehavior = false;
            this.lrset.View = System.Windows.Forms.View.Details;
            this.lrset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lrset_MouseUp);
            // 
            // lprefix
            // 
            this.lprefix.Text = "前缀";
            this.lprefix.Width = 155;
            // 
            // lcolor
            // 
            this.lcolor.Text = "背景色";
            this.lcolor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lcolor.Width = 110;
            // 
            // TeleSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 355);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bok);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeleSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "演播设置";
            this.tabControl1.ResumeLayout(false);
            this.tabgeneral.ResumeLayout(false);
            this.tabgeneral.PerformLayout();
            this.tabreporter.ResumeLayout(false);
            this.tabreporter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog telecolorDialog;
        private System.Windows.Forms.FontDialog telefontDialog;
        private System.Windows.Forms.Button bok;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabgeneral;
        private System.Windows.Forms.TextBox drawinterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox showstatus;
        private System.Windows.Forms.CheckBox textflip;
        private System.Windows.Forms.Label colorchooser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel fontchooser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabreporter;
        private System.Windows.Forms.ListView lrset;
        private System.Windows.Forms.ColumnHeader lprefix;
        private System.Windows.Forms.ColumnHeader lcolor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.LinkLabel brdel;
        private System.Windows.Forms.LinkLabel bradd;
    }
}