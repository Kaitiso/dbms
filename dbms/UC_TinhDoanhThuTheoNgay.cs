using DuLich;
using Microsoft.IdentityModel.Tokens;
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
using static System.Net.Mime.MediaTypeNames;

namespace dbms
{
    public partial class UC_TinhDoanhThuTheoNgay : UserControl
    {
        public UC_TinhDoanhThuTheoNgay()
        {
            InitializeComponent();
        }

        private void btn_HienThi_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = Connection_to_SQL.getConnection();
                connection.Open();
                if (txt_Thang.Text.IsNullOrEmpty() && txt_Ngay.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Nam");
                    SqlCommand cmd = new SqlCommand("TinhDoanhThuTheoNam", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@nam", int.Parse(txt_Nam.Text));
                    cmd.Parameters.AddWithValue("@tong", 0);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    hienThi(dataTable);
                    connection.Close();
                }
                else if(txt_Ngay.Text.IsNullOrEmpty())
                {
                    MessageBox.Show("Thang");
                    SqlCommand cmd = new SqlCommand("TinhDoanhThuTheoThang", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@thang", int.Parse(txt_Thang.Text));
                    cmd.Parameters.AddWithValue("@nam", int.Parse(txt_Nam.Text));
                    cmd.Parameters.AddWithValue("@tong", 0);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    hienThi(dataTable);
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Ngay");
                    SqlCommand cmd = new SqlCommand("TinhDoanhThuTheoNgay", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ngay", int.Parse(txt_Ngay.Text));
                    cmd.Parameters.AddWithValue("@thang", int.Parse(txt_Thang.Text));
                    cmd.Parameters.AddWithValue("@nam", int.Parse(txt_Nam.Text));
                    cmd.Parameters.AddWithValue("@tong", 0);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    hienThi(dataTable);
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void hienThi(DataTable table)
        {

            lbl_Gia.Text = table.Rows[0]["TongGiaNhapHang"].ToString();
            lbl_Gia1.Text = table.Rows[0]["TongGiaBanHang"].ToString();
            lbl_Gia2.Text = table.Rows[0]["TongLuongNhanVien"].ToString();
            lbl_Gia3.Text = table.Rows[0]["TongDoanhThu"].ToString();
        }
    }
}
