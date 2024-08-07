using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLSanPham
    {
        ConnectDB db;

        public BLSanPham()
        {
            db = new ConnectDB();
        }

        public DataTable SanPham()
        {
            string query = "EXEC proc_SanPham";
            return db.ExecuteQueryDataTable(query, CommandType.Text);
        }
        public DataTable cthd(string MaHD)
        {
            string query = $"EXEC [dbo].[GetChiTietHoaDonByMaHD] @MaHD = '{MaHD}';";
            return db.ExecuteQueryDataTable(query, CommandType.Text);
        }
        public DataTable GioHang(string Matk)
        {
            string query = $"EXEC procGetGioHangUser '{Matk}'";
            return db.ExecuteQueryDataTable(query, CommandType.Text);
        }

        public DataSet GetSP()
        {
            string query = "select * from SANPHAM";

            return db.ExecuteQueryDataSet(query, CommandType.Text);
        }

        public void ThemSP(string maSP, string tenSP, double donGia, string tinhTrang,
            string tgBaoHanh, string maNSX, string maThongSoKT, int soLuong)
        {
            string query = $"exec procThemSanPhamAdmin '{maSP}', '{tenSP}', '{donGia}'," +
                $" N'{tinhTrang}', '{tgBaoHanh}', '{maNSX}', '{maThongSoKT}', '{soLuong}'";

            string err = "";
            db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        public DataSet TimKiemLapTop(string TenSP)
        {
            return db.ExecuteQueryDataSet("exec procTimKiemSanPhamUser @TenSP='" + TenSP + "'", CommandType.Text);
        }

        public void CapNhatSP(string maSP, string tenSP, double donGia, string tinhTrang,
            string tgBaoHanh, string maNSX, string maThongSoKT, int soLuong)
        {
            string query = $"exec procCapNhatSanPhamAdmin '{maSP}', '{tenSP}', '{donGia}'," +
                $" N'{tinhTrang}', '{tgBaoHanh}', '{maNSX}', '{maThongSoKT}', '{soLuong}'";
            string err = "";
            db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }

        public void XoaSP(string maSP)
        {
            string query = $"delete from SANPHAM where MaSP = '{maSP}'";
            string err = "";
            db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }
        //push Sản phẩm vào giỏ hàng
        public bool themCTGH(string MaGH, string MaSP, string soluong, string Dongia, ref string err)
        {
            //string sqlInsert = "Insert into CHITIETGIOHANG Values('" + MaGH + "', '" + MaSP + "', '" + soluong + "', '" + Dongia + "');";
            string sqlInsert = "EXEC ThemCTGH @MaGH= '" + MaGH + "', @MaSP='" + MaSP + "', @SoLuong='" + soluong + "', @DonGia='" + Dongia + "'";
            return db.MyExecuteNonQuery(sqlInsert, CommandType.Text, ref err);
        }

        public bool themVaoGioHang(string MaGH, string MaSP, string soluong, string Dongia, ref string err)
        {
            //string sqlInsert = "Insert into CHITIETGIOHANG Values('" + MaGH + "', '" + MaSP + "', '" + soluong + "', '" + Dongia + "');";
            string sqlInsert = "EXEC proc_ThemVaoGioHangUser @MaGH= '" + MaGH + "', @MaSP='" + MaSP + "', @SoLuong='" + soluong + "', @DonGia='" + Dongia + "'";
            return db.MyExecuteNonQuery(sqlInsert, CommandType.Text, ref err);
        }
        public string timGioHang_id(string MaTK, ref string err)
        {
            string sqlString = "SELECT * FROM fn_TimGioHangUser('" + MaTK + "');";
            return db.MyExecuteString(sqlString, CommandType.Text, ref err);
        }
        public string tim_SLSP(string MaSP, ref string err)
        {
            string sqlString = $"SELECT dbo.fn_SoLuongSP('{MaSP}') AS SoLuong;;";
            return db.MyExecuteString(sqlString, CommandType.Text, ref err);
        }

        public string tonggt(string MaKH, ref string err)
        {
            string sqlString = $"EXEC GetTotalCartValue '{MaKH}';";
            return db.MyExecuteString(sqlString, CommandType.Text, ref err);
        }
        public bool themChiTietHoaDon(string MaSP, string MaHD, string Dongia, string soluong, string tongtien, ref string err)
        {
            string sqlInsert = "EXEC proc_ThemChiTietHoaDonUser @MaSP= '" + MaSP + "', @MaHD='" + MaHD + "', @DonGia='" + Dongia + "', @SoLuong='" + soluong + "',@TongTien='" + tongtien + "'";
            return db.MyExecuteNonQuery(sqlInsert, CommandType.Text, ref err);
        }

        public bool ThanhToanSP(string MaKH, string MaSP, string MaNV, string TenDv, string TrangThai, string DiaChiGiao, string HinhThuc, string NgayThanhToan, decimal DonGia, int SoLuong, ref string err)
        {
            string q1 = $"EXEC ThanhToan '{MaKH}', 'SP001', 'NV004', N'Bán hàng', N'Chờ xác nhận', N'38/11/5', N'Online', '2023/11/17', 120000, 1;";
            string query = $"EXEC ThanhToan '{MaKH}', '{MaSP}', '{MaNV}', N'{TenDv}', N'{TrangThai}', N'{DiaChiGiao}', N'{HinhThuc}', '{NgayThanhToan}', {DonGia}, {SoLuong};";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }

        public string slsp(string MaSP, ref string err)
        {
            string sqlString = $"EXEC proc_slsp '{MaSP}';";
            return db.MyExecuteString(sqlString, CommandType.Text, ref err);
        }
    }
}
