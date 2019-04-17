using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nd_project
{
    /// <summary>
    /// _btn
    /// regconfirm, backform1
    /// 
    /// 
    /// </summary>
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

     // 주석추가
        private void backform1_Click(object sender, EventArgs e)  //뒤로가기 from1으로 전환
        {
            backform();
        }

        public void backform()  //뒤로가기 from1으로 전환
        {
            this.Close();
            new Form1().Activate();
        }

        private void regconfirm_btn_Click(object sender, EventArgs e)
        {
            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\temp\userdb.accdb";
            string sql = "INSERT INTO SHEET1 VALUES(?,?,?)";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            {
                // The insertSQL string contains a SQL statement that
                // inserts a new row in the source table.
                //OleDbCommand cmd = new OleDbCommand(sql);
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = sql;

                // Set the Connection to the new OleDbConnection.
                cmd.Connection = conn;

                cmd.Parameters.AddWithValue("uid", idreg_txt.Text);
                cmd.Parameters.AddWithValue("password", passreg_txt.Text);
                cmd.Parameters.AddWithValue("uname", namereg_txt.Text);

                // Open the connection and execute the insert command.
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("신규등록이 완료되었습니다");
                    backform();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("신규등록중 오류가 발생되었습니다" + ex.Message);
                }
                // The connection is automatically closed when the
                // code exits the using block.
            }
        }
    }
}
