using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLChatUser
    {
        ConnectDB db;

        public BLChatUser()
        {
            db = new ConnectDB();
        }

        public List<string> GetChatbyID(string MaKH)
        {
            List<string> chatTextList = new List<string>() ;

            string query = $"EXEC ListMessage '{MaKH}';"; // Sử dụng chuỗi truy vấn với tham số
            CommandType commandType = CommandType.Text;


            DataSet ds = db.ExecuteQueryDataSet(query, commandType);
            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                string chatRole = row["Role"].ToString();
                string chatText = row["Text"].ToString().TrimEnd();
                DateTime chatTime = Convert.ToDateTime(row["time"]);
                string formattedChatTime = chatTime.ToString("HH:mm:ss dd/MM/yy");
                string formattedChat = $"{chatRole} ({formattedChatTime}): {chatText}";
                chatTextList.Add(formattedChat);
            }
            return chatTextList;
        }


        public string SendIb(string MaKH, string txt, ref string err)
        {
            string str = $"EXEC InsertChatMessage '{MaKH}', N'{txt}';";
            return db.MyExecuteString(str, CommandType.Text, ref err);
        }

        public string deleteIB(string MaKH, ref string err)
        {
            string str = $"EXEC DeleteChatMessagesByMaKH {MaKH}; ";
            return db.MyExecuteString(str, CommandType.Text, ref err);
        }
    }
}
