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
    public partial class UC_PhieuNhapDonHang : UserControl
    {
        public UC_PhieuNhapDonHang()
        {
            InitializeComponent();
        }

        private void UC_PhieuNhapDonHang_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = Connection_to_SQL.getConnection())
            {
                SqlCommand command = new SqlCommand("SELECT * FROM ViewPhieuNhapDonHang", connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "PhieuNhapDonHang");
                connection.Close();
                DataTable dataTable = dataSet.Tables["PhieuNhapDonHang"];
                dgv_PhieuNhapDonHang.DataSource = dataTable;
            }
        }
    }
}
