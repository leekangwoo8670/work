using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2nd_project
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
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


        //private void label2_Click(object sender, EventArgs e)
        //{
        //   Application.ExitThread();
        //}





        private void backform3_pbox_Click(object sender, EventArgs e)
        {
            this.Close();
            new Form3().Show();
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            new sugestform1().Show();
        }

        private void close_lbl_Click(object sender, EventArgs e)
        {
            MessageBox.Show("프로그램을 종료합니다");
            Application.Exit();
        }
    }
}
