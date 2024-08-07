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
    public partial class QuanLyGioHang_Admin : Form
    {
        BLGioHangAD gh = new BLGioHangAD();
        bool checkclicksp = false;

        int SoLuong;
        int SoLuongNhap;
        string err;
        string MaKH;
        string MaSP;
        string MaGH;
        string TenKH;
        public QuanLyGioHang_Admin()
        {
            InitializeComponent();
        }

        void LoadKH()
        {
            DataTable dt = gh.KH_GH();
            dg_KH.DataSource = dt;

            dg_KH.AutoResizeColumns();

        }

        void LoadGH_MaKH(string MaKH)
        {
            DataTable dt = gh.CTGH(MaKH);
            dg_GH.DataSource = dt;
            dg_GH.AutoResizeColumns();
            label3.Text = "Giỏ hàng tương ứng của khách hàng " + TenKH + ": ";
        }
        private void QuanLyGioHang_Admin_Load(object sender, EventArgs e)
        {
            LoadKH();
            visiblebtn();
        }

        private void dg_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dg_KH.Rows[e.RowIndex];
                MaKH = row.Cells["MaKH"].Value.ToString();
                MaGH = row.Cells["MaGH"].Value.ToString();
                TenKH = row.Cells["HoTen"].Value.ToString();
                LoadGH_MaKH(MaKH);
            }
        }
        void visiblebtn()
        {
            btnDelete.Visible = false;
            btnLuu.Visible = false;
            btnGiam.Visible = false;
            btnTang.Visible = false;
            textBox1.Visible = false;
            btnHuy.Visible = false;
            label4.Visible = false;
        }

        void Unvisiblebtn()
        {
            btnDelete.Visible = true;
            btnLuu.Visible = true;
            btnGiam.Visible = true;
            btnTang.Visible = true;
            textBox1.Visible = true;
            btnHuy.Visible = true;
            label4.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (checkclicksp)
            {
                Unvisiblebtn();
                btnEdit.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần chỉnh sửa");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool re = gh.XoaSP(MaGH, MaSP, ref err);
                if (re)
                {
                    LoadGH_MaKH(MaKH);
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
            visiblebtn();
            btnEdit.Enabled = true;
        }

        private void btnGiam_Click(object sender, EventArgs e)
        {
            if (SoLuongNhap > 1)
            {
                SoLuongNhap -= 1;
                textBox1.Text = SoLuongNhap.ToString();
            }
            else
            {
                SoLuongNhap = 1;
            }
        }

        private void btnTang_Click(object sender, EventArgs e)
        {
            if (SoLuongNhap < SoLuong)
            {
                SoLuongNhap += 1; ;
                textBox1.Text = SoLuongNhap.ToString();
            }
            else
            {
                MessageBox.Show("Không đủ số lượng trong kho!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            visiblebtn();
            btnEdit.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int sl = int.Parse(textBox1.Text);
            bool re = gh.doiSLSP(MaGH, MaSP, sl, ref err);
            if (re)
            {
                MessageBox.Show("Đã thay đổi thành công");
                LoadKH();
                LoadGH_MaKH(MaKH);
            }
            else
            {
                MessageBox.Show("Không đổi được. Lỗi rồi!");
            }
            visiblebtn();
            btnEdit.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadKH();
            LoadGH_MaKH(MaKH);
        }

        private void dg_GH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dg_GH.RowCount != 0)
                {
                    BLSanPham sp = new BLSanPham();
                    // Lấy giá trị từ ô số lượng của dòng đã click
                    DataGridViewRow selectedRow = dg_GH.Rows[e.RowIndex];
                    MaSP = selectedRow.Cells["MaSP"].Value.ToString();

                    SoLuong = int.Parse(sp.tim_SLSP(MaSP, ref err));
                    string soLuongCellValue = selectedRow.Cells["SoLuong"].Value.ToString();
                    if (int.TryParse(soLuongCellValue, out SoLuongNhap))
                    {
                        textBox1.Text = SoLuongNhap.ToString();
                        checkclicksp = true;

                    }
                    else
                    {
                        checkclicksp = false;
                        //MessageBox.Show("Giá trị số lượng không hợp lệ.");
                    }


                    textBox1.Text = SoLuongNhap.ToString();


                }
                else if (dg_GH.RowCount == 0)
                {
                    MessageBox.Show("Không có sản phẩm nào trong giỏ hàng");
                }
            }
        }
    }
}
