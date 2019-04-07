namespace _2nd_project
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label7 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.date_cbox = new System.Windows.Forms.ComboBox();
            this.metascore_cbox = new System.Windows.Forms.ComboBox();
            this.rating_cbox = new System.Windows.Forms.ComboBox();
            this.platform_cbox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.log_lbox = new System.Windows.Forms.ListBox();
            this.dic_btn = new System.Windows.Forms.PictureBox();
            this.close_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dic_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(339, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "추가1";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.Window;
            this.search_btn.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.search_btn.Location = new System.Drawing.Point(448, 412);
            this.search_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(152, 59);
            this.search_btn.TabIndex = 17;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(327, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "제작년도";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(320, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "메타스코어";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(327, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "심의등급";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(336, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "플랫폼";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(420, 336);
            this.comboBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(292, 23);
            this.comboBox5.TabIndex = 7;
            // 
            // date_cbox
            // 
            this.date_cbox.FormattingEnabled = true;
            this.date_cbox.Items.AddRange(new object[] {
            "최신(2019)",
            "2015~2018",
            "2010~2015",
            "2005~2010",
            "2000~2005",
            "1995~2000"});
            this.date_cbox.Location = new System.Drawing.Point(420, 274);
            this.date_cbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.date_cbox.Name = "date_cbox";
            this.date_cbox.Size = new System.Drawing.Size(292, 23);
            this.date_cbox.TabIndex = 8;
            // 
            // metascore_cbox
            // 
            this.metascore_cbox.FormattingEnabled = true;
            this.metascore_cbox.Items.AddRange(new object[] {
            "90이상",
            "80이상",
            "70이상",
            "60이상",
            "50이상"});
            this.metascore_cbox.Location = new System.Drawing.Point(420, 211);
            this.metascore_cbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.metascore_cbox.Name = "metascore_cbox";
            this.metascore_cbox.Size = new System.Drawing.Size(292, 23);
            this.metascore_cbox.TabIndex = 9;
            // 
            // rating_cbox
            // 
            this.rating_cbox.FormattingEnabled = true;
            this.rating_cbox.Items.AddRange(new object[] {
            "AO",
            "E",
            "M",
            "T"});
            this.rating_cbox.Location = new System.Drawing.Point(420, 148);
            this.rating_cbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rating_cbox.Name = "rating_cbox";
            this.rating_cbox.Size = new System.Drawing.Size(292, 23);
            this.rating_cbox.TabIndex = 10;
            // 
            // platform_cbox
            // 
            this.platform_cbox.FormattingEnabled = true;
            this.platform_cbox.Items.AddRange(new object[] {
            "DS",
            "PS",
            "PSP",
            "VITA",
            "Switch",
            "Will",
            "XONE"});
            this.platform_cbox.Location = new System.Drawing.Point(420, 86);
            this.platform_cbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.platform_cbox.Name = "platform_cbox";
            this.platform_cbox.Size = new System.Drawing.Size(292, 23);
            this.platform_cbox.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.log_lbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 587);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 40);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "최근 검색";
            // 
            // log_lbox
            // 
            this.log_lbox.FormattingEnabled = true;
            this.log_lbox.ItemHeight = 15;
            this.log_lbox.Location = new System.Drawing.Point(11, 90);
            this.log_lbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.log_lbox.Name = "log_lbox";
            this.log_lbox.Size = new System.Drawing.Size(169, 454);
            this.log_lbox.TabIndex = 0;
            // 
            // dic_btn
            // 
            this.dic_btn.Image = ((System.Drawing.Image)(resources.GetObject("dic_btn.Image")));
            this.dic_btn.Location = new System.Drawing.Point(651, 412);
            this.dic_btn.Name = "dic_btn";
            this.dic_btn.Size = new System.Drawing.Size(61, 59);
            this.dic_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dic_btn.TabIndex = 18;
            this.dic_btn.TabStop = false;
            this.dic_btn.Click += new System.EventHandler(this.dic_pbox_Click);
            // 
            // close_lbl
            // 
            this.close_lbl.AutoSize = true;
            this.close_lbl.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close_lbl.Location = new System.Drawing.Point(754, 9);
            this.close_lbl.Name = "close_lbl";
            this.close_lbl.Size = new System.Drawing.Size(23, 20);
            this.close_lbl.TabIndex = 19;
            this.close_lbl.Text = "X";
            this.close_lbl.Click += new System.EventHandler(this.close_lbl_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(789, 587);
            this.Controls.Add(this.close_lbl);
            this.Controls.Add(this.dic_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.date_cbox);
            this.Controls.Add(this.metascore_cbox);
            this.Controls.Add(this.rating_cbox);
            this.Controls.Add(this.platform_cbox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dic_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox dic_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox date_cbox;
        private System.Windows.Forms.ComboBox metascore_cbox;
        private System.Windows.Forms.ComboBox rating_cbox;
        private System.Windows.Forms.ComboBox platform_cbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox log_lbox;
        private System.Windows.Forms.Label close_lbl;
    }
}