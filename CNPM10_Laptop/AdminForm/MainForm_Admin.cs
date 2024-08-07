using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM10_Laptop.AdminForm
{

    public partial class MainForm_Admin : Form
    {
        public static string MaTaiKhoanNV { get; set; }
        public static string TenDangNhapNV { get; set;}
        public MainForm_Admin()
        {
            InitializeComponent();
            this.Size = new Size(1055, 600);
        }

        private void MainForm_Admin_Load(object sender, EventArgs e)
        {
            TrangChu_Admin form = new TrangChu_Admin();
            ShowFormInPanel(form);
            Username.Text = TenDangNhapNV;
            Role.Text = LoginForm.MaTaiKhoan;
        }
        Form currentForm;
        private void ShowFormInPanel(Form form)
        {

            // Xóa form hiện tại khỏi panel (nếu có)
            if (currentForm != null)
            {
                currentForm.Hide();
                Main_Panel.Controls.Remove(currentForm);
                currentForm.Dispose();
            }

            // Thiết lập form mới
            currentForm = form;
            currentForm.TopLevel = false;
            currentForm.FormBorderStyle = FormBorderStyle.None;
            currentForm.Dock = DockStyle.Fill;

            // Thêm form mới vào panel
            Main_Panel.Controls.Add(currentForm);
            currentForm.BringToFront();
            currentForm.Show();
        }

        private void Logo_Pic_Click(object sender, EventArgs e)
        {
            TrangChu_Admin form = new TrangChu_Admin();
            ShowFormInPanel(form);
        }

        private void TrangChu_btn_Click(object sender, EventArgs e)
        {
            TrangChu_Admin form = new TrangChu_Admin();
            ShowFormInPanel(form);
        }

        private void TaiKhoan_btn_Click(object sender, EventArgs e)
        {
            QLTK_Admin form = new QLTK_Admin();
            ShowFormInPanel(form);
        }

        private void SanPham_btn_Click(object sender, EventArgs e)
        {
            SanPham_Admin form = new SanPham_Admin();
            ShowFormInPanel(form);
        }

        private void DoanhThu_btn_Click(object sender, EventArgs e)
        {
            DoanhThu_Admin form = new DoanhThu_Admin();
            ShowFormInPanel(form);
        }

        private void Kho_btn_Click(object sender, EventArgs e)
        {
            QuanLyKho_Admin form = new QuanLyKho_Admin();
            ShowFormInPanel(form);
        }

        private void HoTroKhachHang_bth_Click(object sender, EventArgs e)
        {
            HoTroKH_Admin form = new HoTroKH_Admin();
            ShowFormInPanel(form);
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại xác nhận
            if (result == DialogResult.Yes)
            {
                // Xử lý đăng xuất ở đây (ví dụ: đóng form hoặc thực hiện các hành động cần thiết)

                this.Hide();
                LoginForm form = new LoginForm();
                form.ShowDialog();
            }
        }

        private void Main_Panel_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Role_Click(object sender, EventArgs e)
        {

        }
    }
}
