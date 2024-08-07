using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop
{
    internal class ConnectDB
    {
        //static string connectString = "Server=tcp:dbmsnhom10.database.windows.net,1433;Initial Catalog=CuaHangLapTop;Persist Security Info=False;User ID=dbms;Password=Kiet@2003;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

        static string connectString = "Data Source=DESKTOP-QFFQABI\\ACER NITRO 5;Initial Catalog=CuaHangLapTop;Integrated Security=True";
        //SqlConnection connect = new SqlConnection();
        SqlConnection connect = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;
        public ConnectDB()
        {
            connect = new SqlConnection(connectString);
            comm = connect.CreateCommand();
        }
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
            connect.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataTable ExecuteQueryDataTable(string strSQL, CommandType ct)
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
            connect.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataTable ds = new DataTable();
            da.Fill(ds);
            return ds;
        }
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (connect.State == ConnectionState.Open)
                connect.Close();
            connect.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                connect.Close();
            }
            return f;
        }
        public string MyExecuteString(string strSQL, CommandType ct, ref string error)
        {
            string result = string.Empty;

            if (connect.State == ConnectionState.Open)
                connect.Close();
            connect.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                result = comm.ExecuteScalar()?.ToString();
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                connect.Close();
            }
            return result;
        }
        public bool MyExecuteNonQuery_Command(SqlCommand strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            try
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
                connect.Open();

                strSQL.Connection = connect;
                strSQL.CommandType = ct;

                strSQL.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                connect.Close();
            }
            return f;
        }
        SqlConnection con = new SqlConnection(connectString);
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
