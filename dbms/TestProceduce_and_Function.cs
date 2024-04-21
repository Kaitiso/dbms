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
            hienThi("NhanVien", dgv_dsNhanVien);
            hienThi("NhaCungCap", dgv_nhaCC);
            hienThi("KeHang", dvg_KeHang);
            hienThi("KhachHang", dgv_KhachHang);
            hienThi("LoaiHangHoa", dgv_LoaiHang);
            hienThi("HangHoa", dgv_HangHoa);
            hienThi("PhieuNhapHang", dgv_phieuNhapHang);
        }
        public void hienThi(string tenBang,DataGridView dvg)
        {
            SqlConnection conn = Connection_to_SQL.getConnection();
            try
            {
                conn.Open();
                string sqlStr = string.Format("SELECT *FROM {0}", tenBang);
                SqlDataAdapter adapter = new SqlDataAdapter(sqlStr, conn);
                DataTable dtNhanVien = new DataTable();
                adapter.Fill(dtNhanVien);
                dvg.DataSource = dtNhanVien; /// gvHsinh = name cua data gridview
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
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themNhanVien", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", txt_maNV.Text);
            cmd.Parameters.AddWithValue("@hovaten", txt_hoTen.Text);
            cmd.Parameters.AddWithValue("@ns", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@gt", txt_gioiTinh.Text);
            cmd.Parameters.AddWithValue("@dc", txt_diaChi.Text);
            cmd.Parameters.AddWithValue("@ntd", dateTimePicker2.Value);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_dsNhanVien.DataSource = dataTable;
            hienThi("NhanVien", dgv_dsNhanVien);
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
            hienThi("NhanVien", dgv_dsNhanVien);
            connection.Close();
        }

        private void dgv_dsNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_dsNhanVien.Rows[e.RowIndex];
            txt_maNV.Text = Convert.ToString(row.Cells["MaNV"].Value);
            txt_maNV.ReadOnly = true;
            txt_hoTen.Text = Convert.ToString(row.Cells["Hoten"].Value);
            txt_diaChi.Text = Convert.ToString(row.Cells["DiaChi"].Value);
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
            dateTimePicker2.Value = Convert.ToDateTime(row.Cells["NgayTuyenDung"].Value);
            txt_gioiTinh.Text = Convert.ToString(row.Cells["GioiTinh"].Value);
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaNhanVien", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manv", txt_maNV.Text);
            cmd.Parameters.AddWithValue("@hovaten", txt_hoTen.Text);
            cmd.Parameters.AddWithValue("@ns", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@gt", txt_gioiTinh.Text);
            cmd.Parameters.AddWithValue("@dc", txt_diaChi.Text);
            cmd.Parameters.AddWithValue("@ntd", dateTimePicker2.Value);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_dsNhanVien.DataSource = dataTable;
            hienThi("NhanVien", dgv_dsNhanVien);
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

        private void btn_themNhaCC_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themNhaCC", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhaCC", txt_maNhaCC.Text);
            cmd.Parameters.AddWithValue("@tennhaCC", txt_tenNhaCC.Text);
            cmd.Parameters.AddWithValue("@dc", txt_diaChiNhaCC.Text);
            cmd.Parameters.AddWithValue("@tk", txt_taiKhoan.Text);
            cmd.Parameters.AddWithValue("@msthue", txt_maSoThue);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_nhaCC.DataSource = dataTable;
            hienThi("NhaCungCap", dgv_nhaCC);
            connection.Close();
        }

        private void btn_xoaNhaCC_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_xoaNhaCC", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhaCC", txt_maNhaCC.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_nhaCC.DataSource = dataTable;
            hienThi("NhaCungCap", dgv_nhaCC);
            connection.Close();
        }

        private void btn_suaNhaCC_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaNhaCC", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhaCC", txt_maNhaCC.Text);
            cmd.Parameters.AddWithValue("@tennhaCC", txt_tenNhaCC.Text);
            cmd.Parameters.AddWithValue("@dc", txt_diaChiNhaCC.Text);
            cmd.Parameters.AddWithValue("@tk", txt_taiKhoan.Text);
            cmd.Parameters.AddWithValue("@msthue", txt_maSoThue.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_nhaCC.DataSource = dataTable;
            hienThi("NhaCungCap", dgv_nhaCC);
            connection.Close();
        }

        private void dgv_nhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_dsNhanVien.Rows[e.RowIndex];
            txt_maNhaCC.Text = Convert.ToString(row.Cells["MaNhaCungCap"].Value);
            txt_maNhaCC.ReadOnly = true;
            txt_tenNhaCC.Text = Convert.ToString(row.Cells["TenNhaCungCap"].Value);
            txt_maSoThue.Text = Convert.ToString(row.Cells["MaSoThue"].Value);
            txt_diaChiNhaCC.Text = Convert.ToString(row.Cells["DiaChi"].Value);
            txt_taiKhoan.Text = Convert.ToString(row.Cells["TaiKhoan"].Value);
        }

        private void btn_themKeHang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themKeHang", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maKeHang", txt_maKeHang.Text);
            cmd.Parameters.AddWithValue("@tenKeHang", txt_tenKeHang.Text);
            cmd.Parameters.AddWithValue("@viTriKe", txt_viTriKeHang.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dvg_KeHang.DataSource = dataTable;
            hienThi("KeHang", dvg_KeHang);
            connection.Close();
        }

        private void btn_xoaKeHang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_xoaKeHang", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maKeHang", txt_maKeHang.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dvg_KeHang.DataSource = dataTable;
            hienThi("KeHang", dvg_KeHang);
            connection.Close();
        }

        private void btn_SuaKeHang_Click(object sender, EventArgs e)
        {
           
        }

        private void dvg_KeHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dvg_KeHang.Rows[e.RowIndex];
            txt_maKeHang.Text = Convert.ToString(row.Cells["MaKeHang"].Value);
            txt_maKeHang.ReadOnly = true;
            txt_tenKeHang.Text = Convert.ToString(row.Cells["TenKeHang"].Value);
            txt_viTriKeHang.Text = Convert.ToString(row.Cells["ViTriKe"].Value);
        }

        private void btn_themKH_Click(object sender, EventArgs e)
        {
            int sodienthoai = int.Parse(txt_SĐT.Text);
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themKhachHang", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sdt", sodienthoai);
            cmd.Parameters.AddWithValue("@maKH", txt_maKH.Text);
            cmd.Parameters.AddWithValue("@tennKH",txt_tenKhachHang.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_KhachHang.DataSource = dataTable;
            hienThi("KhachHang", dgv_KhachHang);
            connection.Close();
        }

        private void btn_xoaKhachHang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_xoaKhachHang", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maKH", txt_maKH.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_KhachHang.DataSource = dataTable;
            hienThi("KhachHang", dgv_KhachHang);
            connection.Close();
        }

        private void btn_suaKH_Click(object sender, EventArgs e)
        {
            int sodienthoai = int.Parse(txt_SĐT.Text);
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaKhachHang", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sdt", sodienthoai);
            cmd.Parameters.AddWithValue("@maKH", txt_maKH.Text);
            cmd.Parameters.AddWithValue("@tennKH", txt_tenKhachHang.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_KhachHang.DataSource = dataTable;
            hienThi("KhachHang", dgv_KhachHang);
            connection.Close();
        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
            txt_maKH.Text = Convert.ToString(row.Cells["MaKH"].Value);
            txt_maKH.ReadOnly = true;
            txt_tenKhachHang.Text = Convert.ToString(row.Cells["TenKH"].Value);
            txt_SĐT.Text = Convert.ToString(row.Cells["SDT"].Value);
        }

        private void btn_themLoaiHang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themLoaiHangHoa", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maLoaiHH", txt_maLoaiHang.Text);
            cmd.Parameters.AddWithValue("@tenLoaiHH", txt_tenLoaiHang.Text);
            cmd.Parameters.AddWithValue("@maKeHang", txt_maKeHangHH.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_LoaiHang.DataSource = dataTable;
            hienThi("LoaiHangHoa", dgv_LoaiHang);
            connection.Close();
        }

        private void btn_xoaLoaiHang_Click(object sender, EventArgs e)
        {
        }

        private void btn_suaLoaiHangHoa_Click(object sender, EventArgs e)
        {
            int sodienthoai = int.Parse(txt_SĐT.Text);
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaLoaiHH", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maLoaiHH", txt_maLoaiHang.Text);
            cmd.Parameters.AddWithValue("@tenLoaiHH", txt_tenLoaiHang.Text);
            cmd.Parameters.AddWithValue("@maKeHang", txt_maKeHangHH.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_LoaiHang.DataSource = dataTable;
            hienThi("LoaiHangHoa", dgv_LoaiHang);
            connection.Close();
        }

        private void dgv_LoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_LoaiHang.Rows[e.RowIndex];
            txt_maLoaiHang.Text = Convert.ToString(row.Cells["MaLoaiHangHoa"].Value);
            txt_maLoaiHang.ReadOnly = true;
            txt_tenLoaiHang.Text = Convert.ToString(row.Cells["TenLoaiHangHoa"].Value);
            txt_viTriKeHang.Text = Convert.ToString(row.Cells["MaKeHang"].Value);
        }

        private void btn_xoaHangHoa_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_xoaHangHoa", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maHH", txt_maHH.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_HangHoa.DataSource = dataTable;
            hienThi("HangHoa", dgv_HangHoa);
            connection.Close();
        }

        private void btn_suaHangHoa_Click(object sender, EventArgs e)
        {
            double giaBan = double.Parse(txt_giaBan.Text);
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaHangHoa", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maHH", txt_maHH.Text);
            cmd.Parameters.AddWithValue("@tenHH", txt_tenHH.Text);
            cmd.Parameters.AddWithValue("@gia", giaBan);
            cmd.Parameters.AddWithValue("@donVi", txt_donVi.Text);
            cmd.Parameters.AddWithValue("@hsd", date_HSD.Value);
            cmd.Parameters.AddWithValue("@maLH", txt_maLoaiHangHH.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_HangHoa.DataSource = dataTable;
            hienThi("HangHoa", dgv_HangHoa);
            connection.Close();
        }

        private void dgv_HangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_HangHoa.Rows[e.RowIndex];
            txt_maHH.Text = Convert.ToString(row.Cells["MaHangHoa"].Value);
            txt_maHH.ReadOnly = true;
            txt_tenHH.Text = Convert.ToString(row.Cells["TenHang"].Value);
            txt_giaBan.Text = Convert.ToString(row.Cells["GiaBan"].Value);
            txt_donVi.Text = Convert.ToString(row.Cells["DonViTinh"].Value);
            date_HSD.Value = Convert.ToDateTime(row.Cells["HanSuDung"].Value);
            txt_maLoaiHangHH.Text = Convert.ToString(row.Cells["MaLoaiHang"].Value);
        }

        private void btn_xoaPhieuNhapHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_suaPhieuNhapHang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaPhieuNhapHang", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maphieunhap", txt_maPhieuNhap.Text);
            cmd.Parameters.AddWithValue("@ngaynhap", date_ngayNhapHang.Value);
            cmd.Parameters.AddWithValue("@manhaCC", txt_maNhaCCNhapHang.Text);
            cmd.Parameters.AddWithValue("@maNV", txt_maNVNhapHang.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_phieuNhapHang.DataSource = dataTable;
            hienThi("PhieuNhapHang", dgv_phieuNhapHang);
            connection.Close();
        }

        private void dgv_phieuNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_phieuNhapHang.Rows[e.RowIndex];
            txt_maPhieuNhap.Text = Convert.ToString(row.Cells["MaPhieuNhap"].Value);
            txt_maPhieuNhap.ReadOnly = true;
            txt_maNVNhapHang.Text = Convert.ToString(row.Cells["MaNV"].Value);
            txt_maNhaCCNhapHang.Text = Convert.ToString(row.Cells["MaNhaCC"].Value);
            date_ngayNhapHang.Value = Convert.ToDateTime(row.Cells["NgayNhapHang"].Value);
        }

        private void txt_taiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_QLKeHang_Click(object sender, EventArgs e)
        {

        }

        private void txt_maNhaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tp_QuanlynhaCC_Click(object sender, EventArgs e)
        {

        }

        private void btn_TKNhaCC_Click(object sender, EventArgs e)
        {

        }

        private void txt_tenNhaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_maSoThue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_diaChiNhaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_maKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_SĐT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_tenKhachHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void tp_Quanlykhachhang_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txt_maHH_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_HSD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void lbl_maNV_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tp_QuanLyNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void tp_Quanlyhanghoa_Click(object sender, EventArgs e)
        {

        }
    }
}
