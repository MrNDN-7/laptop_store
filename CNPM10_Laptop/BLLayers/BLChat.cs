using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLChat
    {
        ConnectDB db;

        public BLChat()
        {
            db = new ConnectDB();
        }

        public List<string> GetChatbyID(string MaKH)
        {
            List<string> chatTextList = new List<string>();

            string query = "SELECT Role, Text, Time FROM CHAT WHERE MaKH = '" + MaKH + "'";
            CommandType commandType = CommandType.Text;

            DataSet ds = db.ExecuteQueryDataSet(query, commandType);
            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                string chatRole = row["Role"].ToString();
                string chatText = row["Text"].ToString().TrimEnd();
                string time = row["time"].ToString();
                string formattedChat = $"{chatRole}: {chatText}    ({time})";
                chatTextList.Add(formattedChat);
            }

            return chatTextList;
        }

        public List<string> GetMaKHChat()
        {
            List<string> chatMaKHList = new List<string>();

            string query = "exec procLayMaKHChat";
            CommandType commandType = CommandType.Text;

            DataSet ds = db.ExecuteQueryDataSet(query, commandType);
            DataTable dt = ds.Tables[0];

            foreach (DataRow row in dt.Rows)
            {
                string chatMaKH = row["MaKH"].ToString();
                chatMaKHList.Add(chatMaKH);
            }
            return chatMaKHList;
        }


        public void SendChat(string maKH, string text, string role)
        {
            string query = $"exec procThemChat @makh = '{maKH}', @text = '{text}', @role = '{role}'";
            string err = "";
            db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }

        public void DeleteChat(string maKH)
        {
            string query = $"exec DeleteChatMessagesByMaKH @MaKH = '{maKH}'";
            string err = "";
            db.MyExecuteNonQuery(query, CommandType.Text, ref err);
        }

    }
}
