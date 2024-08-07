using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLVanChuyen
    {
        ConnectDB db;

        public BLVanChuyen()
        {
            db = new ConnectDB();
        }
        public DataSet GetVanChuyen(string MaTK)
        {
            return db.ExecuteQueryDataSet("exec procGetVanChuyenUser @MaTK = '" + MaTK + "'", CommandType.Text);
        }
    }
}
