using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using dbms;
using System.Windows.Interop;
using Microsoft.Office.Interop.Excel;

namespace DuLich
{
    public class Connection_to_SQL
    {
        static string cnnString = @"Data Source=MSI;Initial Catalog=QuanLyCuaHangTienLoi;Integrated Security=True";
        
        public static SqlConnection getConnection()
        {
            return new SqlConnection(cnnString);     
        }
        public static SqlConnection getConnectionNhanVien(string username, string password)
        {
            string cnnString1 = @"Data Source=MSI;Initial Catalog=Quanlycuahangtienloi;User ID=" + username + ";Password=" + password + ";";
            return new SqlConnection(cnnString1);
        }
    }
}
