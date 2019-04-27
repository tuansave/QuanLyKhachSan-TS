
using QuanLyKhachSan.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSK
{
    public partial class fLogin : MetroFramework.Forms.MetroForm
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string userName = tbUsername.Text;
            string passWord = tbPassword.Text;
            if (Login(userName,passWord))
            {
                fMain f = new fMain();
                this.Hide();
                f.ShowDialog();
            }
               else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
       
            }
        }
        bool Login(string userName, string passWord)
        {
            return LoginDAO.Instance.Login(userName, passWord);
        }
    }
}
