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
    public partial class TaiKhoan_User : Form
    {
        public MainForm_User ParentForm { get; set; }

        string MaTaiKhoan = LoginForm.MaTaiKhoan;
        string CheckTaiKhoan = LoginForm.check_tk;
        BLAccountLogin DBAC = new BLAccountLogin();
        string err = string.Empty; // Declare 'err' variable
        public TaiKhoan_User()
        {
            InitializeComponent();
        }
        void LoadData()
        {

            string err = string.Empty; // Declare 'err' variable
            if (MaTaiKhoan != "" && CheckTaiKhoan == "US")
            {
                txtTen.Text = DBAC.TimTenKH(MaTaiKhoan);
                txtMaTaiKhoan.Text = MaTaiKhoan;
                txtSDT.Text = DBAC.TimSDTKH(MaTaiKhoan);
                txtEmail.Text = DBAC.TimEmailKH(MaTaiKhoan);
                txtDiaChi.Text = DBAC.TimDiaChiKH(MaTaiKhoan);
                txtMaKH.Text = DBAC.TimMaKH(MaTaiKhoan);
            }
            //this.btnLuu.Enabled = false;

            this.btnLuu.Enabled = false;
            this.txtTen.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtSDT.Enabled = false;

            this.btnSua.Enabled = true;

        }

        private void TaiKhoan_User_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.btnSua.Enabled = false;
            this.btnLuu.Enabled = true;
            this.txtTen.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.txtEmail.Enabled = true;
            this.txtSDT.Enabled = true;

            this.btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string ten = txtTen.Text;
            string sdt = txtSDT.Text;
            string diachi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string makh = LoginForm.maKh;

            this.btnSua.Enabled = true;
            this.btnLuu.Enabled = false;
            this.txtTen.Enabled = false;
            this.txtDiaChi.Enabled = false;
            this.txtEmail.Enabled = false;
            this.txtSDT.Enabled = false;


            //DBAC.capNhatKhachHang(this.txtTen.Text, this.txtDiaChi.Text, this.txtEmail.Text, this.txtSDT.Text);
            bool re = DBAC.updateinfoKH(makh, ten, diachi, email, sdt, ref err);
            if (re)
            {
                // Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong! " + err);
            }
            else
            {
                MessageBox.Show("lỗi: " + err, "Lỗi");
            }
        }

        private void doipass_Click(object sender, EventArgs e)
        {
            MainForm_User mainForm = ParentForm;
            if (mainForm != null)
            {
                mainForm.ChangePass();
            }
        }
    }
}
