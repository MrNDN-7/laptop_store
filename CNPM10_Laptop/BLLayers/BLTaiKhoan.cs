using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLTaiKhoan
    {
        ConnectDB db;

        public BLTaiKhoan()
        {
            db = new ConnectDB();
        }

        public bool DangNhap(string username, string password, string check, ref string err)
        {
            string sqlString = $"EXEC proc_KiemTraTaiKhoan {username},{password}, {check}";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public void Info(string username, ref string hoTen, ref string maKH, ref string err)
        {
            string query = $"SELECT * FROM dbo.MaKH_TenKH('{username}');";

            using (SqlCommand cmd = new SqlCommand(query, db.getConnection))
            {
                try
                {
                    db.openConnection();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Lấy giá trị từ cột HoTen và MaKH
                                hoTen = reader["HoTen"].ToString();
                                maKH = reader["MaKH"].ToString();
                            }
                        }
                        else
                        {
                            err = "Không tìm thấy thông tin cho tên đăng nhập này.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    err = ex.Message;
                }
                finally
                {
                    db.closeConnection();
                }
            }



        }
        // Dang ky tai khoan
        public bool DangKy(string Hoten, string gioitinh, string sdt, string email, string diachi, string tendn, string mk, string remk, ref string err)
        {
            string query = $"EXEC dbo.DangKyTaiKhoan  '{tendn}',    '{mk}',    N'{Hoten}',    '{sdt}',    N'{gioitinh}',    '{email}',    N'{diachi}',    '{remk}';";
            return db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }

    }
}
