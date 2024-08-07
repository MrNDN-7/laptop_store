using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLGioHang
    {
        ConnectDB db;

        public BLGioHang()
        {
            db = new ConnectDB();
        }
        public DataSet GetGioHang(string MaTK)
        {
            return db.ExecuteQueryDataSet("exec procGetGioHangUser @MaTK = '" + MaTK + "'", CommandType.Text);
        }
        public DataSet XoaChiTietGH(string id)
        {

            return db.ExecuteQueryDataSet("exec procXoaChiTietGHUser @id= '" + id + "';", CommandType.Text);
        }
        public string TinhTong(string MaTK, ref string err)
        {
            //return db.MyExecuteString("SELECT SUM(SoLuong * DonGia) AS TongGiaTri FROM CHITIETGIOHANG where MaGH =( select MaGH from GIOHANG where MaKH =(select MaKH from KHACHHANG where MaTaiKhoan ='"+ MaTK +"'));", CommandType.Text, ref err);
            return db.MyExecuteString("SELECT dbo.fn_TinhTongTienGioHang('" + MaTK + "')", CommandType.Text, ref err);
        }
        public DataSet GetHoaDonUser(string MaTK)
        {
            return db.ExecuteQueryDataSet("exec  procGetHoaDonUser @MaTK = '" + MaTK + "'", CommandType.Text);
        }
        public DataSet GetChiTietHoaDonUser(string MaTK)
        {
            return db.ExecuteQueryDataSet("exec  procGetChiTietHoaDonUser @MaTaiKhoan='" + MaTK + "'", CommandType.Text);
        }
        public bool themHoaDon(string maHoaDon, string TenDichVu, string TongGiaTri, string MaNV, string MaKH, string NgayThanhToan, string MaDonHang, ref string err)
        {
            string sqlInsert = "EXEC proc_ThemHoaDonUser @MaHoaDon='" + maHoaDon + "', @TenDichVu=N'" + TenDichVu + "', @TongGiaTri=" + TongGiaTri + ", @MaNV='" + MaNV + "', @MaKH='" + MaKH + "', @NgayThanhToan='" + NgayThanhToan + "', @MaDonHang='" + MaDonHang + "'";
            return db.MyExecuteNonQuery(sqlInsert, CommandType.Text, ref err);
        }

        public bool themDonHang(string maDonHang, string TrangThai, string DiaChi, string TongGiaTri, string HinhThuc, string NgayDat, string NgayGiao, string MaNV, ref string err)
        {
            string Insert = "EXEC proc_ThemDonHangUser @MaDonHang='" + maDonHang + "', @TrangThai=N'" + TrangThai + "', @DiaChi=N'" + DiaChi + "', @TongGiaTri=" + TongGiaTri + ", @HinhThuc='" + HinhThuc + "', @NgayDat='" + NgayDat + "', @NgayGiao='" + NgayGiao + "', @MaNV='" + MaNV + "'";
            return db.MyExecuteNonQuery(Insert, CommandType.Text, ref err);
        }
        public string DemSoLuongMaDonHang()
        {
            int soLuong = 0;
            string err = string.Empty;

            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("procSoLuongCotMaDonHang", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramSoLuong = new SqlParameter("@SoLuong", SqlDbType.Int);
                paramSoLuong.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramSoLuong);

                cmd.ExecuteNonQuery();

                soLuong = (int)paramSoLuong.Value;

                db.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return soLuong.ToString();
        }
        public string DemSoLuongHoaDon()
        {
            int soLuong = 0;
            string err = string.Empty;

            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("procSoLuongHoaDon", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramSoLuong = new SqlParameter("@SoLuong", SqlDbType.Int);
                paramSoLuong.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramSoLuong);

                cmd.ExecuteNonQuery();

                soLuong = (int)paramSoLuong.Value;

                db.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return soLuong.ToString();
        }
        public void XoaGH(string maGH)
        {
            string err = string.Empty;

            try
            {
                db.openConnection();
                SqlCommand cmd = new SqlCommand("proc_XoaFullGioHang_User", db.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramMaGH = new SqlParameter("@MaGH", maGH);
                cmd.Parameters.Add(paramMaGH);

                cmd.ExecuteNonQuery();

                db.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }
        }
        public string TimeNow()
        {
            DateTime dt = DateTime.Now;
            string formattedDateTime = dt.ToString("yyyy/MM/dd");
            return formattedDateTime;
        }




    }
}
