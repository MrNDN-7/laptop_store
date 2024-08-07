using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLGioHangAD
    {
        ConnectDB db;
        public BLGioHangAD()
        {
            db = new ConnectDB();
        }
        public DataTable getGH()
        {
            string str = "select * from v_AllGioHang";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public DataTable getCTGH(string MaGH)
        {
            string str = $"exec getCTGH '{MaGH}'";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public string CapNhatGH(string MaGH, string MaSP, string SL, string DonGia, ref string err)
        {
            string str = $"exec CapNhatGHAD {MaGH}, {MaSP}, {SL}, {DonGia}";
            return db.MyExecuteString(str, CommandType.Text, ref err);
        }
        public DataTable KH_GH()
        {
            string query = $"EXEC [dbo].[GetCustomerAndCartInfo];";
            return db.ExecuteQueryDataTable(query, CommandType.Text);
        }

        public DataTable CTGH(string MaKH)
        {
            string query = $"EXEC [dbo].[GetCartDetailsByCustomer] {MaKH};";
            return db.ExecuteQueryDataTable(query, CommandType.Text);
        }

        public bool doiSLSP(string MaGH, string MaSP, int soluong, ref string err)
        {

            string sqlInsert = $"Exec [dbo].[UpdateCartItemQuantity] '{MaGH}', '{MaSP}', {soluong};";
            return db.MyExecuteNonQuery(sqlInsert, CommandType.Text, ref err);
        }

        public bool XoaSP(string MaGH, string MaSP, ref string err)
        {

            string sqlInsert = $"Exec XoaSanPhamKhoiGioHang '{MaGH}', '{MaSP}';";
            return db.MyExecuteNonQuery(sqlInsert, CommandType.Text, ref err);
        }
    }
}
