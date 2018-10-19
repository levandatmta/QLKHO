using QuanLyKhoHang.DAO;
using QuanLyKhoHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class flogin : Form
    {
        private int pq = 0;
        private string name = "";
        private string id = "";
        private string pass = "";
        public flogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (Login (userName, passWord))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByIdLogin(userName);
                if (loginAccount.loaitk == 1) pq = 1;
                else pq = 0;
                name = loginAccount.tenhienthi;
                id = loginAccount.idlogin;
                pass = loginAccount.pass;
                fTableManager f = new fTableManager(pq,name,id,pass);
                this.Hide();
                f.ShowDialog();
                this.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai Tên Tài Khoản Hoặc Mật Khẩu");
            }
        }
        bool Login(string userName, string passWord)
        {
            return AccountDAO.Instance.Login(userName, passWord);
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn thoát chương trình","Thông Báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        public string idLogin { get; set; }
    }
}
