using QuanLiQuanCaPhe.DAO;
using QuanLiQuanCaPhe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiQuanCaPhe
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        
        private void btt_dangnhap_Click(object sender, EventArgs e)
        {
            string userName = tbx_name.Text;
            string passWord = tbx_mk.Text;
            if (userName == "" || passWord == "") MessageBox.Show("Ban chua nhap ten tai khoan, mat khau :(((");
            else if (_Login(userName, passWord))
            {
                quanli q = new quanli();
                this.Hide();
                q.ShowDialog();
                this.Show();
            }
            else            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }
        }
            
        bool _Login(string userName, string passWord)
        {
            return AccountDAO.Instance._Login(userName, passWord);
        }


       
        private void btt_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", 
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void label1_Click(object sender, EventArgs e){}
        private void Login_Load(object sender, EventArgs e) { }
    }
}
