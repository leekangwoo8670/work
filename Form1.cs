using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;    //use accdb


namespace _2nd_project
{
    
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// _btn, _txt, _lbox, _cbox, _pbox, _lbl
        /// login, reg_btn
        /// id, pass_txt
        /// 
        /// </summary>

        public static string username { get; set; }  // 자동 구현 Properties

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Select();
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
          
        }

        private Point mousePoint;
        private void form_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }
        // 마우스 클릭시 먼저 선언된 mousePoint변수에 현재 마우스 위치값이 들어갑니다.

        private void form_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }



        private void reg_btn_Click(object sender, EventArgs e)  // 신규가입from2로 전환
        {
            //디자인- 이전 창을 보이지 않게 함
            new Form2().ShowDialog();
            new Form2().Activate();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            //디자인- 로그인 성공시 from3로 전환

            Select_01();

        }
        public void txtbox_click(object sender, EventArgs e) //txtbox클릭 쿼리
        {
            if (this.ActiveControl.Text == "ID" || this.ActiveControl.Text == "Password")
            {
                this.ActiveControl.Text = "";
            }
            if (this.ActiveControl != id_txt)
            {
                if (id_txt.Text == "")
                {
                    id_txt.Text = "ID";
                }

            }
            if (this.ActiveControl != pass_txt)
            {
                if (pass_txt.Text == "")
                {
                    pass_txt.Text = "Password";
                }
            }

        }

        private void close_lbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램을 종료합니다");
            Application.Exit();
        }


        public void Select_01()
        {//login checker가 옳다면 지정된 동작을 수행합니다
            bool checker = login_checker(id_txt.Text, pass_txt.Text);
            if (checker == true)
            {//로그인
                this.Visible = false;
                new Form3().Show();
                new Form1().Close();
            }

        }


        public bool login_checker(string in_uid, string in_password)
        {
            //id, pw를 입력했는지 확인합니다
            if (in_uid != "" && in_password != "")
            {
                //id, pw가 올바른지 확인합니다
                bool aa;
                aa = idpw_checker(in_uid, in_password);

                if (aa == true)
                {
                    MessageBox.Show($"안녕하세요 {username}님");
                    return true;
                }
                else
                {//다르다면 메세지와 false를 출력합니다
                    MessageBox.Show("아이디나 비밀번호가 다릅니다");
                    return false;
                }
                
            }
            else
            {//입력하지 않았다면 메세지와 false를 출력합니다
                MessageBox.Show("아이디나 비밀번호를 입력하세요");
                return false;
            }
        }


        public bool idpw_checker(string in_uid, string in_password)
        {

            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\userdb.accdb";
            string sql = "select password, uname from sheet1 where uid =?";
            string password_str = "";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                // The insertSQL string contains a SQL statement that
                // inserts a new row in the source table.
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;

                // Set the Connection to the new OleDbConnection.
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("uid", in_uid);                
                
                // Open the connection and execute the insert command.
                try
                {
                    conn.Open();
                    OleDbDataReader rdr = cmd.ExecuteReader();
                    
                    // 다음 레코드 계속 가져와서 루핑
                    while (rdr.Read())
                    {
                        // C# 인덱서를 사용하여
                        // 필드 데이타 엑세스
                        password_str = rdr["password"] as string;
                        username = rdr["uname"] as string;
                    }
                 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // The connection is automatically closed when the
                // code exits the using block.
            }

            if (password_str == in_password)
            {
                return true;
            } else
            {
                return false;
            }


        }
    }
}


