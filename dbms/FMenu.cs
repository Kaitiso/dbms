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
    public partial class FMenu : Form
    {
        public FMenu()
        {
            InitializeComponent();
            hienThi("ViewNhapHang", dgv_NhapHang);
            hienThi("NhanVien", dgv_dsNhanVien);
            hienThi("NhaCungCap", dgv_nhaCC);
            hienThi("KeHang", dvg_KeHang);
            hienThi("KhachHang", dgv_KhachHang);
            hienThi("LoaiHangHoa", dgv_LoaiHang);
            hienThi("HangHoa", dgv_HangHoa);
            hienThi("PhieuNhapHang", dgv_phieuNhapHang);
        }

        private void FMenu_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnNew_Click(object sender, EventArgs e)
        {

        }
        private void TabHome_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabQuanLyNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }


        private void tabNhapHang_Click(object sender, EventArgs e)
        {

        }
        public void hienThi(string tenBang, DataGridView dvg)
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
        private void btn_NhapHang_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themNhapHang", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maphieunhap", txt_MaPN.Text);
            cmd.Parameters.AddWithValue("@ngaynhaphang", date_NgayNH.Value);
            cmd.Parameters.AddWithValue("@manv", txt_MaNhanVien.Text);
            cmd.Parameters.AddWithValue("@manhacc", txt_MaNhaCungCap.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            double giaNhap = int.Parse(txt_GiaNhap.Text);
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("proc_themHangHoa", connection);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@mahh", txt_MaHangHoa.Text);
            cmd1.Parameters.AddWithValue("@tenhh", txt_TenHangHoa.Text);
            cmd1.Parameters.AddWithValue("@maloaihh", txt_MaLoaiHH.Text);
            cmd1.Parameters.AddWithValue("@hsd", date_HanSD.Value);
            cmd1.Parameters.AddWithValue("@giaban", giaNhap);
            cmd1.Parameters.AddWithValue("@donvitinh", "VND");
            cmd1.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            connection.Close();
            int soLuong = int.Parse(txt_SoLuong.Text);
            double tongTien = giaNhap * soLuong;
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("proc_themChiTietHH", connection);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@maphieunhap", txt_MaPN.Text);
            cmd2.Parameters.AddWithValue("@mahh", txt_MaHangHoa.Text);
            cmd2.Parameters.AddWithValue("@gianhap", giaNhap);
            cmd2.Parameters.AddWithValue("@soluong", soLuong);
            cmd2.Parameters.AddWithValue("@tongtien", tongTien);
            cmd2.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            connection.Close();
            hienThi("ViewNhapHang", dgv_NhapHang);
        }

        private void FNhapHang_Load(object sender, EventArgs e)
        {

        }

        private void btn_PhanCa_Click(object sender, EventArgs e)
        {
            phanCa pc = new phanCa();
            this.Hide();
            pc.ShowDialog();
            this.Show();
        }

        private void btn_NhapHang_Click_1(object sender, EventArgs e)
        {

        }

        private void dgv_HangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_xoaHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_suaLoaiHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoaLoaiHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_themLoaiHang_Click(object sender, EventArgs e)
        {

        }

        private void dgv_LoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_SuaKeHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoaKeHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_themKeHang_Click(object sender, EventArgs e)
        {

        }

        private void dvg_KeHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_suaHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoaPhieuNhapHang_Click(object sender, EventArgs e)
        {

        }

        private void dgv_phieuNhapHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_suaPhieuNhapHang_Click(object sender, EventArgs e)
        {

        }

        private void btn_themNhaCC_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themNhaCC", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhaCC", txt_MaNhaCungCap.Text);
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

        private void btn_themKH_Click(object sender, EventArgs e)
        {

        }

        private void dgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button38_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button42_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button28_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_tenNhaCC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_xoaNhaCC_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_xoaNhaCC", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@manhaCC", txt_MaNhaCungCap.Text);
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
            cmd.Parameters.AddWithValue("@manhaCC", txt_MaNhaCungCap.Text);
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

        private void btn_TKNhaCC_Click(object sender, EventArgs e)
        {

        }

        private void dgv_nhaCC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_dsNhanVien.Rows[e.RowIndex];
            txt_MaNhaCungCap.Text = Convert.ToString(row.Cells["MaNhaCungCap"].Value);
            txt_MaNhaCungCap.ReadOnly = true;
            txt_tenNhaCC.Text = Convert.ToString(row.Cells["TenNhaCungCap"].Value);
            txt_maSoThue.Text = Convert.ToString(row.Cells["MaSoThue"].Value);
            txt_diaChiNhaCC.Text = Convert.ToString(row.Cells["DiaChi"].Value);
            txt_taiKhoan.Text = Convert.ToString(row.Cells["TaiKhoan"].Value);
        }

        private void btn_themKH_Click_1(object sender, EventArgs e)
        {
            int sodienthoai = int.Parse(txt_SĐT.Text);
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themKhachHang", connection);
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

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dgv_KhachHang_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_KhachHang.Rows[e.RowIndex];
            txt_maKH.Text = Convert.ToString(row.Cells["MaKH"].Value);
            txt_maKH.ReadOnly = true;
            txt_tenKhachHang.Text = Convert.ToString(row.Cells["TenKH"].Value);
            txt_SĐT.Text = Convert.ToString(row.Cells["SDT"].Value);
        }

        private void btn_xoaHangHoa_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_xoaHangHoa", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maHH", txt_MaHangHoa.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_HangHoa.DataSource = dataTable;
            hienThi("HangHoa", dgv_HangHoa);
            connection.Close();
        }

        private void btn_suaHangHoa_Click_1(object sender, EventArgs e)
        {
            double giaBan = double.Parse(txt_giaBan.Text);
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaHangHoa", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maHH", txt_MaHangHoa.Text);
            cmd.Parameters.AddWithValue("@tenHH", txt_TenHangHoa.Text);
            cmd.Parameters.AddWithValue("@gia", giaBan);
            cmd.Parameters.AddWithValue("@donVi", txt_donVi.Text);
            cmd.Parameters.AddWithValue("@hsd", date_HanSD.Value);
            cmd.Parameters.AddWithValue("@maLH", txt_maLoaiHangHH.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_HangHoa.DataSource = dataTable;
            hienThi("HangHoa", dgv_HangHoa);
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dgv_HangHoa_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_HangHoa.Rows[e.RowIndex];
            txt_MaHangHoa.Text = Convert.ToString(row.Cells["MaHangHoa"].Value);
            txt_MaHangHoa.ReadOnly = true;
            txt_TenHangHoa.Text = Convert.ToString(row.Cells["TenHang"].Value);
            txt_giaBan.Text = Convert.ToString(row.Cells["GiaBan"].Value);
            txt_donVi.Text = Convert.ToString(row.Cells["DonViTinh"].Value);
            date_HanSD.Value = Convert.ToDateTime(row.Cells["HanSuDung"].Value);
            txt_maLoaiHangHH.Text = Convert.ToString(row.Cells["MaLoaiHang"].Value);
        }

        private void btn_xoaPhieuNhapHang_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_suaPhieuNhapHang_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_suaPhieuNhapHang", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@maphieunhap", txt_MaPN.Text);
            cmd.Parameters.AddWithValue("@ngaynhap", date_NgayNH.Value);
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

        private void btn_themLoaiHang_Click_1(object sender, EventArgs e)
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

        private void btn_xoaLoaiHang_Click_1(object sender, EventArgs e)
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

        private void btn_suaLoaiHangHoa_Click_1(object sender, EventArgs e)
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

        private void btn_themKeHang_Click_1(object sender, EventArgs e)
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

        private void btn_xoaKeHang_Click_1(object sender, EventArgs e)
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

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_maPhieuNhap_Click(object sender, EventArgs e)
        {

        }

        private void date_NgayNhapHang_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_HoTen_Click(object sender, EventArgs e)
        {

        }

        private void txt_taiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MaNhanVien_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
