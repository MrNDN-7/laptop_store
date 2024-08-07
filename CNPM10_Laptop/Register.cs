using CNPM10_Laptop.BLLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM10_Laptop
{
    public partial class Register : Form
    {

        private Timer timer;
        private const int DisplayTimeInSeconds = 5;
        string err;

        bool checkSign = false;
        public Register()
        {
            InitializeComponent();
        }
        public void dangky()
        {
            BLTaiKhoan acc = new BLTaiKhoan();
            string ten = txtTen.Text;
            string Sdt = txtSDT.Text;
            string email = txtEmail.Text;
            string diachi = txtDiaChi.Text;
            string gioitinh = "";
            if (rbNam.Checked)
            {
                gioitinh = "Nam";
            }
            else if (rbNu.Checked)
            {
                gioitinh = "Nữ";
            }
            string username = txtUsername.Text;
            string pass = txtMatKhau.Text;
            string repass = txtNhapLaiMatKhau.Text;

            bool re = acc.DangKy(ten, gioitinh, Sdt, email, diachi, username, pass, repass, ref err);
            if (re)
            {
                DialogResult result = MessageBox.Show("Đăng ký thành công, đăngg nhập ngay", "Xác nhận đăng nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Kiểm tra kết quả của hộp thoại xác nhận
                if (result == DialogResult.Yes)
                {
                    // Xử lý đăng xuất ở đây (ví dụ: đóng form hoặc thực hiện các hành động cần thiết)

                    this.Hide();
                    LoginForm form = new LoginForm();
                    form.ShowDialog();
                }
            }
            else
            {
                noti_lb.Text = err;

            }
        }

        private void txtMatKhau_TextChanged_1(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '●';
        }

        private void txtNhapLaiMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtNhapLaiMatKhau.PasswordChar = '●';
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            dangky();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.Size = new Size(900, 700);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm form = new LoginForm();
            form.ShowDialog();
            this.Close();
        }



        private void picPass_Click(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '\0'; // Hiển thị mật khẩu

            timer = new Timer();
            timer.Interval = DisplayTimeInSeconds * 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            timer.Stop();
            txtMatKhau.PasswordChar = '●';
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer.Stop();
            txtMatKhau.PasswordChar = '●';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            txtMatKhau.PasswordChar = '●';
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

            timer.Stop();
            txtMatKhau.PasswordChar = '●';
        }

        private void PicRepass_Click(object sender, EventArgs e)
        {
            txtNhapLaiMatKhau.PasswordChar = '\0'; // Hiển thị mật khẩu

            timer = new Timer();
            timer.Interval = DisplayTimeInSeconds * 1000;
            timer.Tick += timer2_Tick;
            timer.Start();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }
    }
}
