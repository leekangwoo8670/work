namespace _2nd_project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.glist_lbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.select_btn = new System.Windows.Forms.Button();
            this.backform3_pbox = new System.Windows.Forms.PictureBox();
            this.close_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.backform3_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // glist_lbox
            // 
            this.glist_lbox.FormattingEnabled = true;
            this.glist_lbox.ItemHeight = 15;
            this.glist_lbox.Location = new System.Drawing.Point(12, 83);
            this.glist_lbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.glist_lbox.Name = "glist_lbox";
            this.glist_lbox.Size = new System.Drawing.Size(916, 364);
            this.glist_lbox.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(350, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "GAME  LIST";
            // 
            // select_btn
            // 
            this.select_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.select_btn.ForeColor = System.Drawing.Color.DarkCyan;
            this.select_btn.Location = new System.Drawing.Point(418, 472);
            this.select_btn.Name = "select_btn";
            this.select_btn.Size = new System.Drawing.Size(105, 54);
            this.select_btn.TabIndex = 11;
            this.select_btn.Text = "select";
            this.select_btn.UseVisualStyleBackColor = true;
            this.select_btn.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // backform3_pbox
            // 
            this.backform3_pbox.Image = ((System.Drawing.Image)(resources.GetObject("backform3_pbox.Image")));
            this.backform3_pbox.Location = new System.Drawing.Point(16, 470);
            this.backform3_pbox.Name = "backform3_pbox";
            this.backform3_pbox.Size = new System.Drawing.Size(70, 54);
            this.backform3_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backform3_pbox.TabIndex = 9;
            this.backform3_pbox.TabStop = false;
            this.backform3_pbox.Click += new System.EventHandler(this.backform3_pbox_Click);
            // 
            // close_lbl
            // 
            this.close_lbl.AutoSize = true;
            this.close_lbl.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close_lbl.Location = new System.Drawing.Point(908, 9);
            this.close_lbl.Name = "close_lbl";
            this.close_lbl.Size = new System.Drawing.Size(23, 20);
            this.close_lbl.TabIndex = 12;
            this.close_lbl.Text = "X";
            this.close_lbl.Click += new System.EventHandler(this.close_lbl_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(943, 547);
            this.Controls.Add(this.close_lbl);
            this.Controls.Add(this.select_btn);
            this.Controls.Add(this.backform3_pbox);
            this.Controls.Add(this.glist_lbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.backform3_pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox backform3_pbox;
        private System.Windows.Forms.ListBox glist_lbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select_btn;
        private System.Windows.Forms.Label close_lbl;
    }
}