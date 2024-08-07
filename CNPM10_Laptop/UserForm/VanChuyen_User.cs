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

namespace CNPM10_Laptop.UserForm
{
    public partial class VanChuyen_User : Form
    {
        DataTable DTVC = null;
        BLVanChuyen DBVC = new BLVanChuyen();
        string MaTaiKhoan = LoginForm.MaTaiKhoan;
        public MainForm_User ParentForm { get; set; }
        void LoadData()
        {
            try
            {
                DTVC = new DataTable();
                DTVC.Clear();
                DataSet ds = DBVC.GetVanChuyen(MaTaiKhoan);

                DTVC = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvVC.DataSource = DTVC;
                // Thay đổi độ rộng cột
                dgvVC.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table DONHANG Lỗi rồi!!!");
            }
        }
        public VanChuyen_User()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadData();


        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            

        }

        private void VanChuyen_User_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
