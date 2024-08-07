using CNPM10_Laptop.BLLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM10_Laptop.UserForm
{
    public partial class GioHang_User : Form
    {
        int SoLuong;
        int SoLuongNhap;

        decimal DonGia;

        string MaSP;
        string tensp;

        public MainForm_User ParentForm { get; set; }

        string MaTaiKhoan = LoginForm.MaTaiKhoan;

        //string TongTien = " ";
        string err;
        string maghid;
        string MaGH;

        DataTable DTGH = null;
        BLGioHang DBGH = new BLGioHang();
        BLSanPham sp = new BLSanPham();
        public GioHang_User()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                DTGH = new DataTable();
                DTGH.Clear();
                DataSet ds = DBGH.GetGioHang(MaTaiKhoan);
                DTGH = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvGioHang.DataSource = DTGH;
                // Thay đổi độ rộng cột
                dgvGioHang.AutoResizeColumns();

                //TongTien = DBGH.TinhTong(MaTaiKhoan, ref err);
                //string CVT = AddDots(TongTien);
                //lblGia.Text = CVT + " VND"; 
                tong.Text = "Tổng Tiền: " + sp.tonggt(LoginForm.maKh, ref err).ToString() + "VNĐ";
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table DONHANG Lỗi rồi!!!");
            }


        }
        public void load()
        {
            //SoLuongNhap = Int32.Parse(this.txtSoLuong.Text);

        }

        private void GioHang_User_Load(object sender, EventArgs e)
        {
            //LoadData();
            load();
            loaddg();
            tong.Text = $"Tổng Tiền:   {Convert.ToDecimal(sp.tonggt(LoginForm.maKh, ref err)):c} VNĐ";
        }
     
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có dòng nào được chọn không
            if (dgvGioHang.SelectedRows.Count > 0)
            {
                string MaKH = LoginForm.maKh;
                string MaNV = "NV004";
                string tenDV = "Bán hàng";
                string TrangThai = "Chờ xác nhận";
                BLAccountLogin ac = new BLAccountLogin();
                string DiaChi = ac.TimDiaChiKH(MaTaiKhoan);
                string HinhThuc = "Online";
                BLGioHang sp = new BLGioHang();
                string NgayThanhToan = sp.TimeNow();

                int SoLuong = 1;

                BLSanPham SanPham = new BLSanPham();
                bool re = SanPham.ThanhToanSP(MaKH, MaSP, MaNV, tenDV, TrangThai, DiaChi, HinhThuc, NgayThanhToan, DonGia, SoLuongNhap, ref err);
                if (re)
                {
                    MessageBox.Show("Đã Thanh Toán sản phẩm " + tensp + " Thành Công!!!");
                    DBGH.XoaChiTietGH(MaSP);

                    LoadData();
                }
                else
                {
                    MessageBox.Show("Lỗi thanh toán: " + err);
                }
            }
            else
            {

                BLSanPham sanpham = new BLSanPham();
                DataTable dt = sanpham.GioHang(MaTaiKhoan);

                // Đặt DataTable vào DataSource của DataGridView
                dgvGioHang.DataSource = dt;

                // Tự động điều chỉnh kích thước cột
                dgvGioHang.AutoResizeColumns();
                int rowIndex = 0;
                if (dt.Rows.Count > 0)
                {
                    BLGioHang sp = new BLGioHang();
                    BLSanPham sanPham = new BLSanPham();
                    ////Thêm vào DonHang
                    //Đếm MaDH
                    string count = sp.DemSoLuongMaDonHang();
                    int count1 = int.Parse(count) + 2;
                    string matk1 = count1.ToString();
                    string maDonHang = "DH" + matk1;


                    BLAccountLogin ac = new BLAccountLogin();
                    string DiaChi = ac.TimDiaChiKH(MaTaiKhoan);
                    string MaNV = "NV009";
                    string TrangThai = "Chờ xác nhận";
                    string HinhThuc = "Online";


                    string NgayDat = sp.TimeNow();
                    DateTime ngayDatDateTime = DateTime.ParseExact(NgayDat, "yyyy/MM/dd", CultureInfo.InvariantCulture);
                    DateTime ngayGiaoDateTime = ngayDatDateTime.AddDays(7);

                    string NgayGiao = ngayGiaoDateTime.ToString("yyyy/MM/dd");

                    /////thêm vào hoadon
                    /////đếm mahd
                    // //đếm madh
                    string counthd = sp.DemSoLuongHoaDon();
                    int counthd1 = int.Parse(counthd) + 2;
                    string mahd1 = counthd1.ToString();
                    string mahoadon = "HD" + mahd1;


                    //MessageBox.Show(count + " " + counthd);

                    string tendichvu = "Bán hàng";
                    string makh = LoginForm.maKh;
                    string ngaythanhtoan = sp.TimeNow();
                    string madonhang = maDonHang;

                    string TongTien1 = sanPham.tonggt(LoginForm.maKh, ref err);


                    sp.themDonHang(maDonHang, TrangThai, DiaChi, TongTien1, HinhThuc, NgayDat, NgayGiao, MaNV, ref err);

                    bool re = sp.themHoaDon(mahoadon, tendichvu, TongTien1, MaNV, makh, ngaythanhtoan, madonhang, ref err);
                    if (!re)
                    {
                        MessageBox.Show(err);
                    }
                    bool res = false;
                    foreach (DataRow row in dt.Rows)
                    {
                        DataGridViewRow selectedRow = dgvGioHang.Rows[rowIndex];
                        string Masp = row["MaSP"].ToString();
                        string Dongia = row["DonGia"].ToString();
                        string soluong = row["SoLuong"].ToString();
                        double tongTien = double.Parse(Dongia) * int.Parse(soluong);
                        string TongTien = tongTien.ToString();
                        res = sanPham.themChiTietHoaDon(Masp, mahoadon, Dongia, soluong, TongTien, ref err);
                        DBGH.XoaChiTietGH(Masp);
                    }
                    if (res)
                    {
                        MessageBox.Show("Thanh toán giỏ hàng thành công!!!");
                        loaddg();

                        MainForm_User mainForm = ParentForm;
                        if (mainForm != null)
                        {
                            mainForm.ThanhToanShow();
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Lỗi " + err);
                    }
                }
                else
                {
                    MessageBox.Show("Giỏ hàng đang trống, vui lòng thêm sản phẩm vào giỏ hàng");
                }


            }
        }

        private void LSMH_lb_Click(object sender, EventArgs e)
        {
            MainForm_User mainForm = ParentForm;
            if (mainForm != null)
            {
                mainForm.ThanhToanShow();
            }
        }

        private void btnXoaChiTiet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn muốn xóa sản phẩm " + tensp, "Xóa sản phẩm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string maKH = LoginForm.maKh;
                    BLGioHangAD gh = new BLGioHangAD();
                    bool re = gh.XoaSP(MaGH, MaSP, ref err);
                    MessageBox.Show(err);
                    if (re)
                    {
                        load();
                        loaddg();
                        tong.Text = $"Tổng Tiền:   {Convert.ToDecimal(sp.tonggt(LoginForm.maKh, ref err)):c} VNĐ";
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnTang1_Click(object sender, EventArgs e)
        {
            if (SoLuongNhap < SoLuong)
            {
                SoLuongNhap += 1; ;
                txtSoLuong.Text = SoLuongNhap.ToString();
            }
            else
            {
                MessageBox.Show("Không đủ số lượng trong kho!");
            }
        }

        private void btnGiam1_Click(object sender, EventArgs e)
        {
            if (SoLuongNhap > 1)
            {
                SoLuongNhap -= 1;
                txtSoLuong.Text = SoLuongNhap.ToString();
            }
            else
            {
                SoLuongNhap = 1;
            }
        }
        void loaddg()
        {
            BLSanPham sanpham = new BLSanPham();
            DataTable dt = sanpham.GioHang(MaTaiKhoan);

            // Đặt DataTable vào DataSource của DataGridView
            dgvGioHang.DataSource = dt;

            // Tự động điều chỉnh kích thước cột
            dgvGioHang.AutoResizeColumns();
        }

        private void dgvGioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                // Lấy giá trị từ ô số lượng của dòng đã click
                DataGridViewRow selectedRow = dgvGioHang.Rows[e.RowIndex];
                string soLuong = selectedRow.Cells["SoLuong"].Value.ToString();
                tensp = selectedRow.Cells["TenSP"].Value.ToString();
                DonGia = Convert.ToDecimal(selectedRow.Cells["DonGia"].Value);
                MaSP = selectedRow.Cells["MaSP"].Value.ToString();
                MaGH = selectedRow.Cells["MaGH"].Value.ToString();
                SoLuongNhap = int.Parse(soLuong);

                // Hiển thị giá trị số lượng lên TextBox
                txtSoLuong.Text = SoLuongNhap.ToString();


                SoLuong = int.Parse(sp.tim_SLSP(MaSP, ref err));

                BLChiTiet db = new BLChiTiet();
                byte[] img = null;
                DataTable SP = null;
                SP = db.getImage(MaSP);
                DataRow row = SP.Rows[0];
                img = (byte[])row["Image"];
                pictureBox1.Image = byteArrayToImage(img);

            }
        }
        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            Image returnImage = null;
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                returnImage = Image.FromStream(ms);
            }
            return returnImage;
        }
    }
}
