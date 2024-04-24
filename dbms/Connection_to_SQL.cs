using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using dbms;

namespace DuLich
{
    public class Connection_to_SQL
    {
        static string cnnString = @"Data Source=MSI;Initial Catalog=QuanLyCuaHangTienLoi;Integrated Security=True";
        static string cnnString1 = @"Data Source=msi;Initial Catalog=Quanlycuahangtienloi;User ID=binh456789;Password=666666";
        public static SqlConnection getConnection()
        {
                return new SqlConnection(cnnString);     
        }
    }
}
