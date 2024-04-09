using DuLich;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms
{
    public partial class UC_ThongKeTaiChinh : UserControl
    {
        public UC_ThongKeTaiChinh()
        {
            InitializeComponent();
        }

        private void UC_ThongKeTaiChinh_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connection_to_SQL.getConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ViewThongKeTaiChinh", connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "ThongKeTaiChinh");
                connection.Close();
                DataTable dataTable = dataSet.Tables["ThongKeTaiChinh"];
                dgv_ThongKeTaiChinh.DataSource = dataTable;
            }
        }
    }
}
