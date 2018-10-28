using QuanLyKhoHang.DAO;
using QuanLyKhoHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhoHang
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            Load();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        public SqlCommand command { get; set; }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void AddTaikhoanBinding()
        {
            txbMa.DataBindings.Add(new Binding("Text", dataAdmin.DataSource, "idLogin"));
            txbTen.DataBindings.Add(new Binding("Text", dataAdmin.DataSource, "TenHienThi"));
            txbPass.DataBindings.Add(new Binding("Text", dataAdmin.DataSource, "Pass"));
            txbPhanquyen.DataBindings.Add(new Binding("Text", dataAdmin.DataSource, "LoaiTK"));
            
        }
        void Load()
        {
            LoadListTaikhoan();
            AddTaikhoanBinding();

        }
        void LoadListTaikhoan()
        {
            dataAdmin.DataSource = AccountDAO.Instance.GetListAccount();
        }

        private void btnXem_Click_1(object sender, EventArgs e)
        {
            dataAdmin.DataSource = AccountDAO.Instance.GetListAccount();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Id = txbMa.Text;
            string Ten = txbTen.Text;
            string Pass = txbPass.Text;
            string pq = txbPhanquyen.Text;
            int loaitk = int.Parse(pq);
            if (AccountDAO.Instance.InsertTK(Id, Ten, Pass, loaitk))
            {
                MessageBox.Show("Thêm Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string Id = txbMa.Text;
            string Ten = txbTen.Text;
            string Pass = txbPass.Text;
            string pq = txbPhanquyen.Text;
            int loaitk = int.Parse(pq);
            if (AccountDAO.Instance.UpdateTk(Id, Ten, Pass, loaitk))
            {
                MessageBox.Show("Sửa Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Sửa");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string Id = txbMa.Text;

            if (AccountDAO.Instance.DeleteTK(Id))
            {
                MessageBox.Show("Xóa Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xóa");
            }
        }
    }
}
