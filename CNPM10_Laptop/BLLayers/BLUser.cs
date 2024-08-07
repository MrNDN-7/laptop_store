using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLUser
    {
        ConnectDB db;

        public BLUser()
        {
            db = new ConnectDB();
        }

        //public DataTable GetKH()
        //{
        //    SqlCommand cmd = new SqlCommand("select * from KHACHHANG", db.getConnection);
        //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //    DataTable dataTable = new DataTable();
        //    adapter.Fill(dataTable);
        //    return dataTable;
        //}

        //public DataSet TimKiemMP(string MaPhieu, ref string err)
        //{
        //string query = "select MaPhieu, tbChoDuyet.MaThe, MaDG,MaDauSach\r\nfrom tbthe,tbChoDuyet\r\nwhere tbthe.mathe = tbChoDuyet.MaThe and MaPhieu  LIKE '%" + MaPhieu + "%'";

        //return db.ExecuteQueryDataSet(query, CommandType.Text);
        //}
    }
}
