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
    public partial class UC_HoaDon : UserControl
    {
        public UC_HoaDon()
        {
            InitializeComponent();
        }

        private void UC_HoaDon_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connection_to_SQL.getConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ViewHoaDon", connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "HoaDon");
                connection.Close();
                DataTable dataTable = dataSet.Tables["HoaDon"];
                dgv_HoaDon.DataSource = dataTable;
            }
        }

        private void dgv_HoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
