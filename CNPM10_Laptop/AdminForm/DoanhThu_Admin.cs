using CNPM10_Laptop.BLLayers;
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

namespace CNPM10_Laptop.AdminForm
{
    public partial class DoanhThu_Admin : Form
    {
        BLDoanhThu blDT = new BLDoanhThu();
        public DoanhThu_Admin()
        {
            InitializeComponent();
        }
        public void LoadData()
        {
            try
            {
                string tongDT;

                if (cmbLoai.SelectedItem.ToString() == "Hóa đơn")
                {
                    try
                    {
                        DataTable dt = blDT.GetThongKeHoaDon(Convert.ToInt16(cmbThang.SelectedItem.ToString()), Convert.ToInt16(cmbNam.SelectedItem.ToString()));

                        dgvDT.DataSource = dt;
                        dgvDT.AutoResizeColumns();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Có lỗi xảy ra" + e.Message);
                    }

                    tongDT = blDT.TongGiaTriHoaDonTheoThangNam(Convert.ToInt16(cmbThang.Text), Convert.ToInt16(cmbNam.Text));
                    if (tongDT == "")
                    {
                        lbTongDT.Text = "Không có dữ liệu";
                    }
                    else
                    {
                        lbTongDT.Text = tongDT + " vnd";
                    }
                }
                else if (cmbLoai.SelectedItem.ToString() == "Đơn nhập")
                {
                    try
                    {
                        DataTable dt = blDT.GetThongKeDonNhap(Convert.ToInt16(cmbThang.SelectedItem.ToString()), Convert.ToInt16(cmbNam.SelectedItem.ToString()));

                        dgvDT.DataSource = dt;
                        dgvDT.AutoResizeColumns();
                    }
                    catch (SqlException e)
                    {
                        MessageBox.Show("Có lỗi xảy ra" + e.Message);
                    }

                    tongDT = blDT.TongGiaTriDonNhapTheoThangNam(Convert.ToInt16(cmbThang.Text), Convert.ToInt16(cmbNam.Text));
                    if (tongDT == "")
                    {
                        lbTongDT.Text = "Không có dữ liệu";
                    }
                    else
                    {
                        lbTongDT.Text = tongDT + " vnd";
                    }
                }

            }
            catch (SqlException e)
            {
                MessageBox.Show("Có lỗi" + e.Message);
            }
        }

        private void DoanhThu_Admin_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void cmbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
