using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM10_Laptop.BLLayers
{
    internal class BLChiTiet
    {
        ConnectDB db;
        public BLChiTiet()
        {
            db = new ConnectDB();
        }
        public string getHDH(string MaSP, ref string err)
        {
            string command = $"select HeDieuHanh from LaodChiTiet ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getCPU(string MaSP, ref string err)
        {
            string command = $"select CPU from LaodChiTiet ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getCongetNoi(string MaSP, ref string err)
        {
            string command = $"select CongKetNoi from LaodChiTiet ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getCard(string MaSP, ref string err)
        {
            string command = $"select Card from LaodChiTiet ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getRam(string MaSP, ref string err)
        {
            string command = $"select Ram from LaodChiTiet ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getOCung(string MaSP, ref string err)
        {
            string command = $"select OCung from LaodChiTiet ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getManHinh(string MaSP, ref string err)
        {
            string command = $"select ManHinh from LaodChiTiet ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getPin(string MaSP, ref string err)
        {
            string command = $"select Pin from LaodChiTiet ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getKg(string MaSP, ref string err)
        {
            string command = $"select TrongLuong from LaodChiTiet ('{MaSP}')";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getTen(string MaSP, ref string err)
        {
            string command = $"select TenSP from SANPHAM WHERE MaSP =  '{MaSP}'";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public string getGia(string MaSP, ref string err)
        {
            string command = $"select DonGia from SANPHAM WHERE MaSP =  '{MaSP}'";
            return db.MyExecuteString(command, CommandType.Text, ref err);
        }
        public DataTable getImage(string MaSP)
        {
            string command = $"select Image from SANPHAM WHERE MaSP =  '{MaSP}'";
            return db.ExecuteQueryDataTable(command, CommandType.Text);
        }

    }
}
