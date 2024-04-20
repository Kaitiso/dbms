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
    public partial class UC_PhieuTichDiem : UserControl
    {
        public UC_PhieuTichDiem()
        {
            InitializeComponent();
        }

        private void UC_PhieuTichDiem_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connection_to_SQL.getConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ViewPhieuTichDiem", connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "PhieuTichDiem");
                connection.Close();
                DataTable dataTable = dataSet.Tables["PhieuTichDiem"];
                dgv_PhieuTichDiem.DataSource = dataTable;
            }
        }

        private void dgv_PhieuTichDiem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
