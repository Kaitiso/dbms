using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DuLich
{
    public class Connection_to_SQL
    {

        static string cnnString = @"Data Source=LAPTOP-NJM7CAI2;Initial Catalog=Test;Integrated Security=True;Encrypt=False";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(cnnString);
        }
    }
}
