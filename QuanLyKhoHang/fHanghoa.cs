﻿using QuanLyKhoHang.DAO;
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
    public partial class fHanghoa : Form
    {
        public fHanghoa()
        {
            InitializeComponent();
            Load();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        #region Methods

        List<Hanghoa> SearchHanghoaByName(string Tenhang)
        {
            List<Hanghoa> hanghoa = HanghoaDAO.Instance.SearchHanghoaByName(Tenhang);

            return hanghoa;
        }

        void AddHangHoaBinding()
        {
            txbMahang.DataBindings.Add(new Binding("Text", dataHangHoa.DataSource, "Idhang"));
            txbTenHang.DataBindings.Add(new Binding("Text", dataHangHoa.DataSource, "Tenhang"));
            txbDvt.DataBindings.Add(new Binding("Text", dataHangHoa.DataSource,"Dvt"));
            txbSoLuong.DataBindings.Add(new Binding("Text", dataHangHoa.DataSource, "SoLuong"));
            txbGiaNhap.DataBindings.Add(new Binding("Text", dataHangHoa.DataSource, "Gianhap"));
            txbGiaxuat.DataBindings.Add(new Binding("Text", dataHangHoa.DataSource, "Giaxuat"));
        }

        void Load()
        {
            LoadListHanghoa();
            AddHangHoaBinding();

        }

        void LoadListHanghoa()
        {
            dataHangHoa.DataSource = HanghoaDAO.Instance.GetListHanghoa();
        }



        #endregion


        #region events

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            LoadListHanghoa();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string Idhang = txbMahang.Text;
            string Tenhang = txbTenHang.Text;
            string Dvt = txbDvt.Text;
            string SoLuong = txbSoLuong.Text;
            string Gianhap = txbGiaNhap.Text;
            string Giaxuat = txbGiaxuat.Text;

            if (HanghoaDAO.Instance.InsertHanghoa(Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat))
            {
                MessageBox.Show("Thêm Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Thêm");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            string Idhang = txbMahang.Text;
            string Tenhang = txbTenHang.Text;
            string Dvt = txbDvt.Text;
            string SoLuong = txbSoLuong.Text;
            string Gianhap = txbGiaNhap.Text;
            string Giaxuat = txbGiaxuat.Text;

            if (HanghoaDAO.Instance.UpdateHanghoa(Idhang, Tenhang, Dvt, SoLuong, Gianhap, Giaxuat))
            {
                MessageBox.Show("Sửa Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Sửa");
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string Idhang = txbMahang.Text;
            //string Tenhang = txbTenHang.Text;
            //string Dvt = txbDvt.Text;
            //string SoLuong = txbSoLuong.Text;
            //string Gianhap = txbGiaNhap.Text;
            //string Giaxuat = txbGiaXuat.Text;

            if (HanghoaDAO.Instance.DeleteHanghoa(Idhang))
            {
                MessageBox.Show("Xóa Thàng Công");
            }
            else
            {
                MessageBox.Show("Có Lỗi Khi Xóa");
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            dataHangHoa.DataSource = SearchHanghoaByName(txbTim.Text);
        }
        #endregion
    }

}
