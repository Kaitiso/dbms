using DuLich;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;
using System.Data.SqlClient;

namespace dbms
{
    public partial class TestProceduce_and_Function : Form
    {
        public TestProceduce_and_Function()
        {
            InitializeComponent();
        }

        private void TestProceduce_and_Function_Load(object sender, EventArgs e)
        {
            hienThi();
        }
        public void hienThi()
        {
            SqlConnection conn = Connection_to_SQL.getConnection();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM NhanVien");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtNhanVien = new DataTable();
                adapter.Fill(dtNhanVien);
                dgv_dsNhanVien.DataSource = dtNhanVien; /// gvHsinh = name cua data gridview
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
        private void btn_Them_Click(object sender, EventArgs e)
        {
            int luong = int.Parse(txt_Luong.Text);
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themNhanVien", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@luong", luong);
            cmd.Parameters.AddWithValue("@manv", txt_maNV.Text);
            cmd.Parameters.AddWithValue("@hovaten", txt_hoTen.Text);
            cmd.Parameters.AddWithValue("@ns", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@gt", txt_gioiTinh.Text);
            cmd.Parameters.AddWithValue("@dc", txt_diaChi.Text);
            cmd.Parameters.AddWithValue("@chucvu", txt_chucVu.Text);
            cmd.Parameters.AddWithValue("@ntd", dateTimePicker2.Value);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_dsNhanVien.DataSource = dataTable;
            hienThi();
            connection.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_xoaNhanVien", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MaNV", txt_maNV.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_dsNhanVien.DataSource = dataTable;
            hienThi();
            connection.Close();
        }

        private void dgv_dsNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_dsNhanVien.Rows[e.RowIndex];
            txt_maNV.Text = Convert.ToString(row.Cells["MaNV"].Value);
            txt_maNV.ReadOnly = true;
            txt_hoTen.Text = Convert.ToString(row.Cells["Hoten"].Value);
            txt_chucVu.Text = Convert.ToString(row.Cells["ChucVu"].Value);
            txt_diaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
            txt_Luong.Text = Convert.ToString(row.Cells["Luong"].Value);
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            dateTimePicker2.Value = Convert.ToDateTime(row.Cells["NgayTuyenDung"].Value);
            txt_gioiTinh.Text = Convert.ToString(row.Cells["GioiTinh"].Value);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            int luong = int.Parse(txt_Luong.Text);
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaNhanVien", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@luong", luong);
            cmd.Parameters.AddWithValue("@manv", txt_maNV.Text);
            cmd.Parameters.AddWithValue("@hovaten", txt_hoTen.Text);
            cmd.Parameters.AddWithValue("@ns", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@gt", txt_gioiTinh.Text);
            cmd.Parameters.AddWithValue("@dc", txt_diaChi.Text);
            cmd.Parameters.AddWithValue("@chucvu", txt_chucVu.Text);
            cmd.Parameters.AddWithValue("@ntd", dateTimePicker2.Value);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_dsNhanVien.DataSource = dataTable;
            hienThi();
            connection.Close();
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("pro_timKiemNVbytenNV", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TenNV", txt_hoTen.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_dsNhanVien.DataSource = dataTable;
            //hienThi();
            connection.Close();
        }

        private void btn_phaCa_Click(object sender, EventArgs e)
        {
            phanCa pc = new phanCa();
            this.Hide();
            pc.ShowDialog();
            this.Show();
        }
    }
}
