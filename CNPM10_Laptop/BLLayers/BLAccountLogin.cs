using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLAccountLogin
    {
        ConnectDB data = null;

        public BLAccountLogin()
        {
            data = new ConnectDB();
        }

        public void RefreshData()
        {
            try
            {
                // Kiểm tra xem kết nối đã mở hay chưa
                if (data.getConnection.State == ConnectionState.Open)
                {
                    data.closeConnection(); // Nếu đã mở, thì đóng kết nối
                }

                data.openConnection(); // Mở lại kết nối
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (exception) ở đây nếu cần thiết
                Console.WriteLine("Lỗi khi mở lại kết nối và làm mới dữ liệu: " + ex.Message);
            }
        }
        public string timPassAccount(string userName)
        {
            string password = null;
            string err = string.Empty;

            try
            {
                data.openConnection();
                SqlCommand cmd = new SqlCommand("proc_timMatKhau", data.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramTenDangNhap = new SqlParameter("@TenDangNhap", userName);
                SqlParameter paramMatKhau = new SqlParameter("@MatKhau", SqlDbType.NVarChar, 50);
                paramMatKhau.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramTenDangNhap);
                cmd.Parameters.Add(paramMatKhau);

                cmd.ExecuteNonQuery();

                password = paramMatKhau.Value.ToString();

                data.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return password;
        }


        public string TimMaTK(string userName)
        {
            string maTK = null;
            string err = string.Empty;

            try
            {
                data.openConnection();
                SqlCommand cmd = new SqlCommand("proc_timMaTK", data.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramTenDangNhap = new SqlParameter("@TenDangNhap", userName);
                SqlParameter paramMaTK = new SqlParameter("@MaTK", SqlDbType.NVarChar, 50);
                paramMaTK.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramTenDangNhap);
                cmd.Parameters.Add(paramMaTK);

                cmd.ExecuteNonQuery();

                maTK = paramMaTK.Value.ToString();

                data.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return maTK;
        }



        public string CheckTenDangNhap(string userName)
        {
            int soLuong = 0;
            string err = string.Empty;

            try
            {
                data.openConnection();
                SqlCommand cmd = new SqlCommand("proc_checkTenDangNhap", data.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramTenDangNhap = new SqlParameter("@TenDangNhap", userName);
                SqlParameter paramSoLuong = new SqlParameter("@SoLuong", SqlDbType.Int);
                paramSoLuong.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramTenDangNhap);
                cmd.Parameters.Add(paramSoLuong);

                cmd.ExecuteNonQuery();

                soLuong = (int)paramSoLuong.Value;

                data.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return soLuong.ToString();
        }



        public string ThemTaiKhoan(string maTK, string tenDangNhap, string matKhau, ref string err)
        {
            string str = $"exec proc_themTaiKhoan {maTK}, {tenDangNhap}, {matKhau}; ";
            return data.MyExecuteString(str, CommandType.Text, ref err);
        }



        public string DemSoLuongTaiKhoan()
        {
            int soLuong = 0;
            string err = string.Empty;

            try
            {
                data.openConnection();
                SqlCommand cmd = new SqlCommand("proc_demSoLuongTaiKhoan", data.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramSoLuong = new SqlParameter("@SoLuong", SqlDbType.Int);
                paramSoLuong.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramSoLuong);

                cmd.ExecuteNonQuery();

                soLuong = (int)paramSoLuong.Value;

                data.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return soLuong.ToString();
        }


        public string TimMaKH(string maTaiKhoan)
        {
            string maKH = null;
            string err = string.Empty;

            try
            {
                data.openConnection();
                SqlCommand cmd = new SqlCommand("proc_TimMaKH_User", data.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramMaTaiKhoan = new SqlParameter("@MaTaiKhoan", maTaiKhoan);
                SqlParameter paramMaKH = new SqlParameter("@MaKH", SqlDbType.NVarChar, 50);
                paramMaKH.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramMaTaiKhoan);
                cmd.Parameters.Add(paramMaKH);

                cmd.ExecuteNonQuery();

                maKH = paramMaKH.Value.ToString();

                data.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return maKH;
        }

        public string TimTenKH(string maTaiKhoan)
        {
            string hoTen = null;
            string err = string.Empty;

            try
            {
                data.openConnection();
                SqlCommand cmd = new SqlCommand("proc_TimHoTen_User", data.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramMaTaiKhoan = new SqlParameter("@MaTaiKhoan", maTaiKhoan);
                SqlParameter paramHoTen = new SqlParameter("@HoTen", SqlDbType.NVarChar, 255);
                paramHoTen.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramMaTaiKhoan);
                cmd.Parameters.Add(paramHoTen);

                cmd.ExecuteNonQuery();

                hoTen = paramHoTen.Value.ToString();

                data.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return hoTen;
        }

        public string TimDiaChiKH(string maTaiKhoan)
        {
            string diaChi = null;
            string err = string.Empty;

            try
            {
                data.openConnection();
                SqlCommand cmd = new SqlCommand("proc_TimDiaChi_User", data.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramMaTaiKhoan = new SqlParameter("@MaTaiKhoan", maTaiKhoan);
                SqlParameter paramDiaChi = new SqlParameter("@DiaChi", SqlDbType.NVarChar, 255);
                paramDiaChi.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramMaTaiKhoan);
                cmd.Parameters.Add(paramDiaChi);

                cmd.ExecuteNonQuery();

                diaChi = paramDiaChi.Value.ToString();

                data.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return diaChi;
        }

        public string TimEmailKH(string maTaiKhoan)
        {
            string email = null;
            string err = string.Empty;

            try
            {
                data.openConnection();
                SqlCommand cmd = new SqlCommand("proc_TimEmail_User", data.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramMaTaiKhoan = new SqlParameter("@MaTaiKhoan", maTaiKhoan);
                SqlParameter paramEmail = new SqlParameter("@Email", SqlDbType.NVarChar, 255);
                paramEmail.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramMaTaiKhoan);
                cmd.Parameters.Add(paramEmail);

                cmd.ExecuteNonQuery();

                email = paramEmail.Value.ToString();

                data.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return email;
        }

        public string TimSDTKH(string maTaiKhoan)
        {
            string sdt = null;
            string err = string.Empty;

            try
            {
                data.openConnection();
                SqlCommand cmd = new SqlCommand("proc_TimSDT_User", data.getConnection);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramMaTaiKhoan = new SqlParameter("@MaTaiKhoan", maTaiKhoan);
                SqlParameter paramSDT = new SqlParameter("@SDT", SqlDbType.NVarChar, 20);
                paramSDT.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(paramMaTaiKhoan);
                cmd.Parameters.Add(paramSDT);

                cmd.ExecuteNonQuery();

                sdt = paramSDT.Value.ToString();

                data.closeConnection();
            }
            catch (Exception ex)
            {
                err = ex.Message;
                Console.WriteLine(err);
            }

            return sdt;
        }
        // Tài khoản




        public bool updateinfoKH(string makh, string ten, string diachi, string email, string sdt, ref string err)
        {
            string sqlString = $"EXEC dbo.ChinhSuaThongTinKhachHang '{makh}',N'{ten}', '{sdt}',N'{email}', N'{diachi}'";
            return data.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }


        public string GetMatKhauUs(string MaTK, ref string err)
        {
            string sqlString = "EXEC proc_GetMatKhauUser @MaTaiKhoan = '" + MaTK + "'";
            return data.MyExecuteString(sqlString, CommandType.Text, ref err);
        }

        public bool CapNhatMatKhau(string maTK, string matKhauMoi, ref string err)
        {
            string sqlString = $"EXEC dbo.proc_CapNhatMatKhauTaiKhoanUser '{maTK}', N'{matKhauMoi}'";
            return data.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

    }
}
