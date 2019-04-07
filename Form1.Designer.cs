namespace _2nd_project
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.id_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.login_btn = new System.Windows.Forms.Button();
            this.reg_btn = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.close_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_txt
            // 
            this.id_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.id_txt.Font = new System.Drawing.Font("굴림체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_txt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.id_txt.Location = new System.Drawing.Point(70, 209);
            this.id_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(259, 22);
            this.id_txt.TabIndex = 2;
            this.id_txt.Text = "ID";
            this.id_txt.Click += new System.EventHandler(this.txtbox_click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(35, 239);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 1);
            this.panel1.TabIndex = 3;
            // 
            // pass_txt
            // 
            this.pass_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pass_txt.Font = new System.Drawing.Font("굴림체", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pass_txt.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pass_txt.Location = new System.Drawing.Point(70, 272);
            this.pass_txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.Size = new System.Drawing.Size(259, 22);
            this.pass_txt.TabIndex = 2;
            this.pass_txt.Text = "Password";
            this.pass_txt.Click += new System.EventHandler(this.txtbox_click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(35, 302);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 1);
            this.panel2.TabIndex = 3;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.White;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_btn.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.login_btn.Location = new System.Drawing.Point(85, 341);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(161, 44);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // reg_btn
            // 
            this.reg_btn.BackColor = System.Drawing.Color.White;
            this.reg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reg_btn.Font = new System.Drawing.Font("돋움", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reg_btn.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.reg_btn.Location = new System.Drawing.Point(85, 392);
            this.reg_btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(161, 44);
            this.reg_btn.TabIndex = 4;
            this.reg_btn.Text = "신규 가입";
            this.reg_btn.UseVisualStyleBackColor = false;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::_2nd_project.Properties.Resources.images__1_;
            this.pictureBox3.Location = new System.Drawing.Point(35, 265);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 30);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(35, 201);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 30);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(135, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // close_lbl
            // 
            this.close_lbl.AutoSize = true;
            this.close_lbl.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close_lbl.Location = new System.Drawing.Point(323, -2);
            this.close_lbl.Name = "close_lbl";
            this.close_lbl.Size = new System.Drawing.Size(23, 20);
            this.close_lbl.TabIndex = 5;
            this.close_lbl.Text = "X";
            this.close_lbl.Click += new System.EventHandler(this.close_lbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(345, 539);
            this.ControlBox = false;
            this.Controls.Add(this.close_lbl);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.form_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.Label close_lbl;
    }
}

