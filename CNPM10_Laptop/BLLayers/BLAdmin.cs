using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLAdmin
    {
        public static string deviceName = "NO1\\THANHBINH";
        static string connStr = "Data Source=" + deviceName + ";Initial Catalog=CuaHangLapTop_So1_VVN;Integrated Security=True";

        SqlConnection con = new SqlConnection(connStr);
        public SqlConnection getConnection
        {
            get
            {
                return con;
            }
        }
        // open the connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
