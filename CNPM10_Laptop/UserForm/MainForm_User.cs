using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM10_Laptop.UserForm
{
    public partial class MainForm_User : Form
    {
        string MaTaiKhoan = LoginForm.MaTaiKhoan;
        string err;
        Form currentForm;
        public MainForm_User()
        {
            InitializeComponent();
            this.Size = new Size(1055, 570);
        }

        private void MainForm_User_Load(object sender, EventArgs e)
        {
            Username.Text = LoginForm.TenDangNhap;
            Role.Text = LoginForm.maKh;
            TrangChu_User form = new TrangChu_User();
            ShowFormInPanel(form);
        }
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

        private void TrangChu_btn_Click(object sender, EventArgs e)
        {
            TrangChu_User form = new TrangChu_User();
            ShowFormInPanel(form);
         
        }

        private void TaiKhoan_btn_Click(object sender, EventArgs e)
        {
            TaiKhoan_User form = new TaiKhoan_User();
            ShowFormInPanel(form);
            form.ParentForm = this;
        }

        private void SanPham_btn_Click(object sender, EventArgs e)
        {
            sp_user form1 = new sp_user();
            
            ShowFormInPanel(form1);
        }

        private void GioHang_btn_Click(object sender, EventArgs e)
        {
            GioHang_User form = new GioHang_User();
            ShowFormInPanel(form);
            form.ParentForm = this;
        }

        private void vanChuyen_btn_Click(object sender, EventArgs e)
        {
            VanChuyen_User form = new VanChuyen_User();
            ShowFormInPanel(form);
        }

        private void TroGiup_btn_Click(object sender, EventArgs e)
        {
            TroGiup_User form = new TroGiup_User();
            ShowFormInPanel(form);
        
        }

        private void Logo_Pic_Click(object sender, EventArgs e)
        {
            TrangChu_User form = new TrangChu_User();
            ShowFormInPanel(form);
        }

        private void GioHang_Pic_Click(object sender, EventArgs e)
        {
            GioHang_User form = new GioHang_User();
            ShowFormInPanel(form);
        }
        public void ThanhToanShow()
        {
            ThanhToan_User form = new ThanhToan_User();
            ShowFormInPanel(form);
   
        }
        public void GioHangShow()
        {
            GioHang_User form = new GioHang_User();
            ShowFormInPanel(form);
            form.ParentForm = this;
        }
        public void LSMH()
        {
            CTHD_User form = new CTHD_User();
            ShowFormInPanel(form);
            form.ParentForm = this;
        }
        public void ChangePass()
        {
            ChangePassword_User form = new ChangePassword_User();
            ShowFormInPanel(form);
            form.ParentForm = this;
        }
        public void ThongTinTK()
        {
            TaiKhoan_User form = new TaiKhoan_User();
            ShowFormInPanel(form);
            form.ParentForm = this;
        }

        public void ShowSP()
        {
            sp_user form = new sp_user();
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
    }
}
