using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLKho
    {
        ConnectDB db;
        public BLKho()
        {
            db = new ConnectDB();
        }
        public DataTable getSp()
        {
            string str = "exec SapXepSP";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public DataTable getDonNhap()
        {
            string str = "select * from v_DNHAP ";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public DataTable getChiTietDN(string MaDN)
        {
            string str = $"exec XemChiTietDNHAP {MaDN}";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public string getTen(string MaSP, ref string err)
        {
            string command = $"select TenSP from f_LayTTtuMaSP ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getDonGia(string MaSP, ref string err)
        {
            string command = $"select DonGia from f_LayTTtuMaSP ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getNSX(string MaSP, ref string err)
        {
            string command = $"select MaNSX from f_LayTTtuMaSP ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public bool checkMaSP(string MaSP, ref string err)
        {
            string str = $"select TenSP from SANPHAM where MaSP = {MaSP} ;";
            if (db.MyExecuteString(str, CommandType.Text, ref err) != null)
                return true;
            return false;
        }
        public string getTong(string SoLuong, string DonGia)
        {
            if (SoLuong != "" && DonGia != "")
            {
                decimal Tong = 0;
                int sl = int.Parse(SoLuong);
                decimal dg = decimal.Parse(DonGia);
                Tong = sl * dg;

                string tong = Tong.ToString();
                return tong;
            }
            return "0";

        }
        public bool themChiTietDN(string MaSP, string MaDN, string SoLuong, string DonGia, string Tong, ref string err)
        {
            int SL = int.Parse(SoLuong);
            decimal dg = decimal.Parse(DonGia);
            decimal tong = decimal.Parse(Tong);
            string str = $"exec themChiTietDN {MaSP}, {MaDN}, {SL}, {dg}, {tong}";
            return db.MyExecuteNonQuery(str, CommandType.Text, ref err);
        }
        public bool HTDN(string MaDN, string NgayNhap, string SoTienChi, ref string err)
        {//them PhieuChi va Them DonNhap
            decimal tien = decimal.Parse(SoTienChi);
            string str = $"exec AddHTDN {MaDN}, '{NgayNhap}', {SoTienChi};";
            return db.MyExecuteNonQuery(str, CommandType.Text, ref err);
        }
        public bool getCTDN(string MaDN, ref string err)
        {
            string str = $"SELECT MaSP, SoLuong, TongTien from CHITIETDONNHAP where MaDonNhap = '{MaDN}'";
            return db.MyExecuteNonQuery(str, CommandType.Text, ref err);
        }
        public bool XoaCTDN(string MaDN, string MaSP, ref string err)
        {
            string str = $"Delete from CHITIETDONNHAP where MaDonNhap = '{MaDN}' AND MaSP = '{MaSP}'";
            return db.MyExecuteNonQuery(str, CommandType.Text, ref err);
        }
        public string GetToDay()
        {
            DateTime dt = DateTime.Today;

            string formattedDate = dt.ToString("yyyy-MM-dd");

            return formattedDate;
        }
    }
}
