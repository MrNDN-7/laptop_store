using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLDoanhThu
    {
        ConnectDB db;

        public BLDoanhThu()
        {
            db = new ConnectDB();
        }

        public DataTable GetThongKeHoaDon(int thang, int nam)
        {
            string query = $"exec procGetThongKeHoaDon {thang}, {nam};";
            CommandType commandType = CommandType.Text;

            return db.ExecuteQueryDataSet(query, commandType).Tables[0];
        }

        public DataTable GetThongKeDonNhap(int thang, int nam)
        {
            string query = $"exec procGetThongKeDonNhap {thang}, {nam};";
            CommandType commandType = CommandType.Text;

            return db.ExecuteQueryDataSet(query, commandType).Tables[0];
        }

        public string TongGiaTriHoaDonTheoThangNam(int thang, int nam)
        {
            string query = $"select dbo.funcTongGiaTriHoaDonTheoThangNam({thang},{nam})";
            string err = "";
            return db.MyExecuteString(query, CommandType.Text, ref err);
        }

        public string TongGiaTriDonNhapTheoThangNam(int thang, int nam)
        {
            string query = $"select dbo.funcTongGiaTriDonNhapTheoThangNam({thang},{nam})";
            string err = "";
            return db.MyExecuteString(query, CommandType.Text, ref err);
        }
    }
}
