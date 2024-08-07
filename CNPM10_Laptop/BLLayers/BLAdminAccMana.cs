using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLAdminAccMana
    {
        ConnectDB db;
        public BLAdminAccMana()
        {
            db = new ConnectDB();
        }
        public DataTable getAcc()
        {
            string str = "select * from TAIKHOAN";
            return db.ExecuteQueryDataTable(str, CommandType.Text);
        }
        public bool ThemAcc(string ID, string username, string password, ref string err)
        {
            string sqlString = $"EXEC dbo.ThemAcc {ID},{username},{password}";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool CapNhatAcc(string ID, string username, string password, ref string err)
        {
            string sqlString = $"EXEC dbo.SuaAcc {ID},{username},{password}";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        public bool XoaAcc(string ID, ref string err)
        {
            string sqlString = $"EXEC dbo.XoaAcc {ID}";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
