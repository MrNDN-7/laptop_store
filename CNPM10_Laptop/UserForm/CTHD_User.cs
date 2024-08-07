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
    public partial class CTHD_User : Form
    {
        public MainForm_User ParentForm { get; set; }
        string MaTaiKhoan = LoginForm.MaTaiKhoan;
        DataTable DTGH = null;
        BLGioHang DBGH = new BLGioHang();
        BLSanPham sp = new BLSanPham();

        string MaHD; // Chỉ định một lần ở đây

        public CTHD_User()
        {
            InitializeComponent();
        }

        public CTHD_User(string maHD) : this() // Thêm constructor để nhận MaHD từ ngoài vào
        {
            MaHD = maHD;
        }

        public void LoadData()
        {
            DataTable dt = sp.cthd(MaHD);
            dgvLSMH.DataSource = dt;
            dgvLSMH.AutoResizeColumns();
        }

        private void lb_giohang_Click(object sender, EventArgs e)
        {
            MainForm_User mainForm = ParentForm;
            if (mainForm != null)
            {
                mainForm.GioHangShow();
            }
        }

        private void lblHoaDon_Click(object sender, EventArgs e)
        {
            MainForm_User mainForm = ParentForm;
            if (mainForm != null)
            {
                mainForm.ThanhToanShow();
            }
        }

        private void CTHD_User_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }

}
