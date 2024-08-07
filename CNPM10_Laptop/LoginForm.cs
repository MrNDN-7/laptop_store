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
    using CNPM10_Laptop.AdminForm;
    using CNPM10_Laptop.BLLayers;
    using CNPM10_Laptop.UserForm;
    
    using System.Data.SqlClient;
    public partial class LoginForm : Form
    {
        private Timer timer;
        private const int DisplayTimeInSeconds = 5;
        string err;
        string hoTen;
        string maKH;




        //int check_tk; //( 1 : Khachs hangf, 2 : Nhaan viene)

        public static string getMK { get; set; }
        public static string check_tk { get; set; }

        public static string MaTaiKhoan { get; set; }
        public static string maKh { get; set; }
        public static string TenDangNhap { get; set; }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            KhachHang_rb.Checked = true;
        }

        private void txtTenDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text == "Tên đăng nhập")
            {
                txtTenDangNhap.Text = string.Empty;
                txtTenDangNhap.ForeColor = Color.LightGray;
            }
        }

        private void txtMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "Mật khẩu")
            {
                txtMatKhau.Text = string.Empty;
                txtMatKhau.PasswordChar = '●';
            }
            picPass.Visible = true;
        }

        private void picPass_Click(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '\0'; // Hiển thị mật khẩu

            timer = new Timer();
            timer.Interval = DisplayTimeInSeconds * 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            txtMatKhau.PasswordChar = '●';
        }
        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = '●';
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Register register = new Register();
            register.ShowDialog();
            this.Close();

        }
        public void DangNhap()
        {

            BLTaiKhoan acc = new BLTaiKhoan();
            BLAccountLogin db = new BLAccountLogin();
            MainForm_Admin formAdmin = new MainForm_Admin();
            MainForm_User formUser = new MainForm_User();
            string username = txtTenDangNhap.Text;
            string pass = txtMatKhau.Text;
            string passSQL = "";
            if (Admin_rb.Checked)
            {
                check_tk = "NV";
            }
            else if (KhachHang_rb.Checked)
            {
                check_tk = "US";
            }
            try
            {
                bool re = acc.DangNhap(username, pass, check_tk, ref err);



                if (re)
                {

                    MaTaiKhoan = db.TimMaTK(username);
                    if (check_tk == "NV")
                    {
                        MainForm_Admin.TenDangNhapNV = username;
                        //MainForm_Admin.MaTaiKhoanNV 

                        this.Hide();
                        formAdmin.ShowDialog();
                        this.Close();
                    }
                    else if (check_tk == "US")
                    {
                        acc.Info(username, ref hoTen, ref maKH, ref err);
                        TenDangNhap = hoTen;
                        maKh = maKH;
                        MaTaiKhoan = db.TimMaTK(username);
                        getMK = db.GetMatKhauUs(MaTaiKhoan, ref err);

                        this.Hide();
                        formUser.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    noti_lb.Text = err;
                    txtMatKhau.Text = "";
                    txtTenDangNhap.Text = "Tên đăng nhập";
                }
            }
            catch (SqlException ex)
            {
                noti_lb.Text = err;
            }
        }
    }
}
