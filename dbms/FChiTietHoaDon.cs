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
    public partial class FChiTietHoaDon : Form
    {
        public FChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void FChiTietHoaDon_Load(object sender, EventArgs e)
        {

            SqlConnection conn = Connection_to_SQL.getConnection();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM ChiTietHoaDon");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtNhanVien = new DataTable();
                adapter.Fill(dtNhanVien);
                dgv_chiTietHoaDon.DataSource = dtNhanVien;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
