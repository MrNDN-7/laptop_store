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

namespace CNPM10_Laptop.UserForm
{
    public partial class ChangePassword_User : Form
    {
        public MainForm_User ParentForm { get; set; }

        string err;

        string passOld = LoginForm.getMK;
        string MaTaiKhoan = LoginForm.MaTaiKhoan;
        string CheckTaiKhoan = LoginForm.check_tk;
        BLAccountLogin DBAC = new BLAccountLogin();

        private Timer timer;
        private const int DisplayTimeInSeconds = 5;
        public ChangePassword_User()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            if (MaTaiKhoan != "" && CheckTaiKhoan == "US")
            {
                txtUserName.Text = MaTaiKhoan;
            }
            txtPassHint.Text = null;
            txtPassOld.Text = null;
            txtPassNew.Text = null;
            txtUserName.Enabled = false;
            txtPassNew.Enabled = false;
            txtPassHint.Enabled = false;
            btnSavePass.Enabled = false;
            nhapmatkhau.Visible = false;
            matkhautrung.Visible = false;


        }

        private void ChangePassword_User_Load(object sender, EventArgs e)
        {
            LoadData();
          
        }

        private void seenpass_old_Click(object sender, EventArgs e)
        {
            txtPassOld.PasswordChar = '\0'; // Hiển thị mật khẩu

            timer = new Timer();
            timer.Interval = DisplayTimeInSeconds * 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void seenpass_new_Click(object sender, EventArgs e)
        {
            txtPassNew.PasswordChar = '\0'; // Hiển thị mật khẩu

            timer = new Timer();
            timer.Interval = DisplayTimeInSeconds * 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void seenpass_hint_Click(object sender, EventArgs e)
        {
            txtPassHint.PasswordChar = '\0'; // Hiển thị mật khẩu

            timer = new Timer();
            timer.Interval = DisplayTimeInSeconds * 1000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            txtPassOld.PasswordChar = '●';
            txtPassNew.PasswordChar = '●';
            txtPassHint.PasswordChar = '●';
        }

        private void txtPassOld_TextChanged(object sender, EventArgs e)
        {
            txtPassOld.PasswordChar = '●';
            if (!string.IsNullOrWhiteSpace(txtPassOld.Text) && txtPassOld.Text == passOld)
            {
                txtPassNew.Enabled = true;
                txtPassHint.Enabled = true;
                nhapmatkhau.Visible = false;
                matkhautrung.Visible = false;
                btnSavePass.Enabled = true;
            }
            else if (!string.IsNullOrWhiteSpace(txtPassOld.Text) && txtPassOld.Text != passOld)
            {
                txtPassNew.Enabled = false;
                txtPassHint.Enabled = false;
                btnSavePass.Enabled = false;
                nhapmatkhau.Visible = true;
                matkhautrung.Visible = false;
            }
            else
            {
                // Mật khẩu cũ trống hoặc null
                txtPassNew.Enabled = false;
                txtPassHint.Enabled = false;
                btnSavePass.Enabled = false;
                nhapmatkhau.Visible = false;
                matkhautrung.Visible = false;
            }
        }

        private void txtPassNew_TextChanged(object sender, EventArgs e)
        {
            txtPassNew.PasswordChar = '●';
            if (txtPassHint.Text == txtPassNew.Text)
            {
                btnSavePass.Enabled = true;
            }
            else
            {
                btnSavePass.Enabled = false;
            }
        }

        private void txtPassHint_TextChanged(object sender, EventArgs e)
        {
            txtPassHint.PasswordChar = '●';
            if (txtPassHint.Text == txtPassNew.Text)
            {
                btnSavePass.Enabled = true;
                matkhautrung.Visible = false;
            }
            else
            {
                btnSavePass.Enabled = false;
                matkhautrung.Visible = true;
            }
        }

        private void txtPassOld_Click(object sender, EventArgs e)
        {
            if (txtPassOld.Text == "Mật khẩu Cũ")
            {
                txtPassOld.Text = string.Empty;
                txtPassOld.PasswordChar = '●';
            }
            seenpass_old.Visible = true;
        }

        private void txtPassNew_Click(object sender, EventArgs e)
        {
            if (txtPassNew.Text == "Mật khẩu Mới")
            {
                txtPassNew.Text = string.Empty;
                txtPassNew.PasswordChar = '●';
            }
            seenpass_new.Visible = true;
        }

        private void txtPassHint_Click(object sender, EventArgs e)
        {
            if (txtPassHint.Text == "Nhập Lại Pass")
            {
                txtPassHint.Text = string.Empty;
                txtPassHint.PasswordChar = '●';
            }
            seenpass_hint.Visible = true;
        }

        private void btnSavePass_Click(object sender, EventArgs e)
        {
            if (txtPassHint.Text == txtPassNew.Text)
            {
                try
                {
                    string matKhauMoi = txtPassHint.Text;


                    bool result = DBAC.CapNhatMatKhau(MaTaiKhoan, matKhauMoi, ref err);

                    if (result)
                    {

                        LoadData();

                        MessageBox.Show("Đã thay đổi mật khẩu thành công!");
                    }
                    else
                    {

                        MessageBox.Show("Lỗi khi thay đổi mật khẩu: " + err, "Lỗi");
                    }
                }
                catch (Exception ex)
                {
                    // Bắt lỗi ngoại lệ
                    MessageBox.Show("Lỗi không mong muốn: " + ex.Message, "Lỗi");
                }
                LoadData();
            }
        }

        private void quayLai_lb_Click(object sender, EventArgs e)
        {
            MainForm_User mainForm = ParentForm;
            if (mainForm != null)
            {
                mainForm.ThongTinTK();
            }
        }
    }
}
