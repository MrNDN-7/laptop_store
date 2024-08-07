using CNPM10_Laptop.BLLayers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM10_Laptop.UserForm
{
    public partial class ChiTietSP : Form
    {
        string MaSP;
        string err;
        DataTable dtChitiet = null;

        public ChiTietSP(string maSP)
        {
            InitializeComponent();
            MaSP = maSP; // Nhận MaSP từ đối tượng sp_user hoặc từ một nguồn khác
            LoadData();
        }

        private void ChiTietSP_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        void LoadData()
        {
            BLChiTiet db = new BLChiTiet();
            byte[] img = null;
            DataTable SP = null;
            SP = db.getImage(MaSP);
            DataRow row = SP.Rows[0];
            img = (byte[])row["Image"];
            pictureBox1.Image = byteArrayToImage(img);

            txtHDH.Text = db.getHDH(MaSP, ref err);
            txtCard.Text = db.getCard(MaSP, ref err);
            txtCong.Text = db.getCongetNoi(MaSP, ref err);
            txtCPU.Text = db.getCPU(MaSP, ref err);
            txtMan.Text = db.getManHinh(MaSP, ref err);
            txtOcung.Text = db.getOCung(MaSP, ref err);
            txtPin.Text = db.getPin(MaSP, ref err);
            txtRam.Text = db.getRam(MaSP, ref err);
            txtTrongLuong.Text = db.getKg(MaSP, ref err);
            lblGia.Text = "Giá: " + db.getGia(MaSP, ref err);
            lblTen.Text = db.getTen(MaSP, ref err);
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

        public byte[] ImageToByteArray(Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
    }
}
