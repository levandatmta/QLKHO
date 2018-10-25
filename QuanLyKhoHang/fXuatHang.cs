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
    public partial class fXuatHang : Form
    {
        public fXuatHang()
        {
            InitializeComponent();
            Load();
        }

        #region Method

        List<Xuathang> SearchXuathangByName(string Tenhang)
        {
            List<Xuathang> xuathang = XuathangDAO.Instance.SearchXuathangByName(Tenhang);

            return xuathang;
        }

        void AddXuathangBinding()
        {
            txbIDxuat.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Idphieux"));
            txbIDhang.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Idhang"));
            txbTenHang.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Tenhang"));
            txbDvt.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Dvt"));
            txbLuongXuat.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Luongxuat"));
            txbGiaXuat.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "Giaxuat"));
            txbThanhTien.DataBindings.Add(new Binding("Text", dataxuat.DataSource, "ThanhTien"));
        }



        void Load()
        {
            LoadListXuathang();
            AddXuathangBinding();
        }

        void LoadListXuathang()
        {
            dataxuat.DataSource = XuathangDAO.Instance.GetListXuathang();
            //dataNCC.DataSource = NCCDAO.Instance.GetListNCC();
        }


        #endregion

        #region events
#endregion

        private void fXuatHang_Load(object sender, EventArgs e)
        {

        }

        private void btnInPhieux_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadListXuathang();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string Idphieux = txbIDxuat.Text;
            string Idhang = txbIDhang.Text;
            string Tenhang = txbTenHang.Text;
            string Dvt = txbDvt.Text;
            string Luongxuat = txbLuongXuat.Text;
            string Giaxuat = txbGiaXuat.Text;
            string ThanhTien = txbThanhTien.Text;


            if (XuathangDAO.Instance.InsertXuathang(Idphieux, Idhang, Tenhang, Dvt, Luongxuat, Giaxuat, ThanhTien))
            {
                MessageBox.Show("Thêm Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm");
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string Idphieux = txbIDxuat.Text;
            //string Idhang = txbIDhang.Text;
            //string Tenhang = txbTenHang.Text;
            //string Dvt = txbDvt.Text;
            //string Luongxuat = txbLuongXuat.Text;
            //string Giaxuat = txbGiaXuat.Text;
            //string ThanhTien = txbThanhTien.Text;


            if (XuathangDAO.Instance.DeleteXuathang(Idphieux))
            {
                MessageBox.Show("Xoá Hàng Hóa Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xóa Hàng Hóa");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            dataxuat.DataSource = SearchXuathangByName(txbTim.Text);
        }
    }
}
