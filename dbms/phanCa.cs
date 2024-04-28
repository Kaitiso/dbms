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
    public partial class phanCa : Form
    {
        public string taiKhoan;
        public string matKhau;
        public phanCa()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void hienThi()
        {
            SqlConnection conn = Connection_to_SQL.getConnectionNhanVien(taiKhoan, matKhau);
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM LamViec");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtNhanVien = new DataTable();
                adapter.Fill(dtNhanVien);
                dgv_dsPhanCa.DataSource = dtNhanVien; /// gvHsinh = name cua data gridview
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
        public void hienThi1()
        {
            SqlConnection conn = Connection_to_SQL.getConnectionNhanVien(taiKhoan, matKhau);
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM CaLamViec");
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtNhanVien = new DataTable();
                adapter.Fill(dtNhanVien);
                pdg_CaLamViec.DataSource = dtNhanVien; /// gvHsinh = name cua data gridview
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
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnectionNhanVien(taiKhoan, matKhau);
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themCaLamViec", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maca ", txt_maCa1.Text);
            cmd.Parameters.AddWithValue("@gioBatDau", date_gioBD.Value);
            cmd.Parameters.AddWithValue("@gioKetThuc ", date_GioKT.Value);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            pdg_CaLamViec.DataSource = dataTable;
            hienThi1();
            connection.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void phanCa_Load(object sender, EventArgs e)
        {
            hienThi();
            hienThi1();
        }

        private void btn_Them_Click_1(object sender, EventArgs e)
        {
            double luong = double.Parse(txt_luong.Text);
            SqlConnection connection = Connection_to_SQL.getConnectionNhanVien(taiKhoan, matKhau);
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_ThemCaChoNhanVien", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maca", txt_maCa.Text);
            cmd.Parameters.AddWithValue("@manv", txt_maNV.Text);
            cmd.Parameters.AddWithValue("@maloainv", txt_loaiNhanVien.Text);
            cmd.Parameters.AddWithValue("@ngayLamViec", date_ngayLV.Value);
            cmd.Parameters.AddWithValue("@luong", luong);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_dsPhanCa.DataSource = dataTable;
            hienThi();
            connection.Close();
        }

        private void btn_xoaCa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnectionNhanVien(taiKhoan, matKhau);
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_xoaCaLamViec", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maca ", txt_maCa1.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            pdg_CaLamViec.DataSource = dataTable;
            hienThi1();
            hienThi();
            connection.Close();
        }

        private void btn_SuaCa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnectionNhanVien(taiKhoan, matKhau);
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaCaLamViec", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maca ", txt_maCa1.Text);
            cmd.Parameters.AddWithValue("@gioBatDau", date_gioBD.Value);
            cmd.Parameters.AddWithValue("@gioKetThuc ", date_GioKT.Value);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            pdg_CaLamViec.DataSource = dataTable;
            hienThi1();
            hienThi();
            connection.Close();
        }

        private void pdg_CaLamViec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = pdg_CaLamViec.Rows[e.RowIndex];
            txt_maCa1.Text = Convert.ToString(row.Cells["MaCa"].Value);
            TimeSpan gioBatDau = (TimeSpan)row.Cells["GioBatDau"].Value;
            DateTime ngayGioBatDau = DateTime.Today.Add(gioBatDau);
            date_gioBD.Value = ngayGioBatDau;
            TimeSpan gioKetThuc = (TimeSpan)row.Cells["GioKetThuc"].Value;
            DateTime ngayGioKetThuc = DateTime.Today.Add(gioKetThuc);
            date_GioKT.Value = ngayGioKetThuc;
        }

        private void dgv_dsPhanCa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_dsPhanCa.Rows[e.RowIndex];
            txt_maCa.Text = Convert.ToString(row.Cells["MaCa"].Value);
            txt_maNV.Text = Convert.ToString(row.Cells["MaNV"].Value);
            txt_loaiNhanVien.Text = Convert.ToString(row.Cells["MaLoaiNhanVien"].Value);
            date_ngayLV.Value = Convert.ToDateTime(row.Cells["NgayLamViec"].Value);
            txt_luong.Text = Convert.ToString(row.Cells["Luong"].Value);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnectionNhanVien(taiKhoan, matKhau);
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_xoaCaChoNhanVien", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maca", txt_maCa.Text);
            cmd.Parameters.AddWithValue("@manv", txt_maNV.Text);
            cmd.Parameters.AddWithValue("@maloainv", txt_loaiNhanVien.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_dsPhanCa.DataSource = dataTable;
            hienThi();
            connection.Close();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            double luong = double.Parse(txt_luong.Text);
            SqlConnection connection = Connection_to_SQL.getConnectionNhanVien(taiKhoan, matKhau);
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaCaChoNhanVien", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maca", txt_maCa.Text);
            cmd.Parameters.AddWithValue("@manv", txt_maNV.Text);
            cmd.Parameters.AddWithValue("@maloainv", txt_loaiNhanVien.Text);
            cmd.Parameters.AddWithValue("@ngayLamViec", date_ngayLV.Value);
            cmd.Parameters.AddWithValue("@luong", luong);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_dsPhanCa.DataSource = dataTable;
            hienThi();
            connection.Close();
        }
    }
}
