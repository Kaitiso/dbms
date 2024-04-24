using DuLich;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms
{

    public partial class FMenu : Form
    {
        public string maHH;
        public string tenHangHoa;
        public int soLuong;
        public double giaBan;
        public bool check = false;
        public Label LABEL = new Label();
        public FMenu()
        {
            InitializeComponent();
            hienThi("ViewNhapHang", dgv_NhapHang);
            hienThi("NhanVien", dgv_dsNhanVien);
            hienThi("NhaCungCap", dgv_nhaCC);
            hienThi("KeHang", dvg_KeHang);
            hienThi("ViewKhachHang", dgv_KhachHang);
            hienThi("LoaiHangHoa", dgv_LoaiHang);
            hienThi("HangHoa", dgv_HangHoa);
            hienThi("PhieuNhapHang", dgv_phieuNhapHang);
            hienThi("ViewHoaDon", dgv_hoaDon);
        }

        public void FMenu_Load(object sender, EventArgs e)
        {
            if (giaBan != 0 && soLuong != 0)
            {
                Label label = new Label();
                string str = maHH + "       " + tenHangHoa + "              " + giaBan.ToString() + "                " + soLuong.ToString() + "                  " + (giaBan * soLuong).ToString();
                //18 - 21 -25
                label.Size = new Size(1000, 30);
                label.Text = str;
                label.Click += Label_Click;
                flp_bangThanhToan.Controls.Add(label);
                Control control = label;
            }
            else
            {
                Label label = new Label();
                string str = "Mã hàng hóa "+"       " + "Tên hàng hóa" + "          " + "Giá bán" + "           " + "Số lượng" + "          " + "Tổng".ToString();
                label.Size = new Size(1000, 30);
                label.Text = str;
                flp_bangThanhToan.Controls.Add(label);
            }
            if (check == false)
            {
                int count = 0;
                var lastIndex = this.guna2TabControl1.TabCount;
                //MaPhong++;
                //MessageBox.Show(lastIndex.ToString());
                string query = string.Format("SELECT * FROM LoaiHangHoa");
                SqlConnection conn = Connection_to_SQL.getConnection();
                conn.Open();
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string tenLoaiHangHoa = reader.GetString(reader.GetOrdinal("TenLoaiHang"));
                    string maLoaiHH = reader.GetString(reader.GetOrdinal("MaLoaiHang"));
                    this.guna2TabControl1.TabPages.Insert(lastIndex, tenLoaiHangHoa);
                    using (SqlConnection connection = Connection_to_SQL.getConnection())
                    {
                        connection.Open();
                        string query2 = "SELECT COUNT(*) FROM HangHoa WHERE HangHoa.MaLoaiHang = @maLoaiHang";

                        using (SqlCommand command2 = new SqlCommand(query2, connection))
                        {
                            command2.Parameters.AddWithValue("@maLoaiHang", maLoaiHH);
                            count = (int)command2.ExecuteScalar();
                        }
                    }
                    //MessageBox.Show(count.ToString());
                    if (count > 0)
                    {
                        int i = 0;
                        int j = 0;
                        TabPage tabPage1 = guna2TabControl1.TabPages[lastIndex];
                        tabPage1.AutoScroll = true;
                        string query1 = string.Format("SELECT * FROM HangHoa, ChiTietPhieuNH WHERE HangHoa.MaHangHoa = ChiTietPhieuNH.MaHH AND HangHoa.MaLoaiHang = @maLoaiHang");
                        SqlConnection conn1 = Connection_to_SQL.getConnection();
                        conn1.Open();
                        SqlCommand command1 = new SqlCommand(query1, conn1);
                        command1.Parameters.AddWithValue("@maLoaiHang", maLoaiHH);
                        command1.ExecuteNonQuery();
                        SqlDataReader reader1 = command1.ExecuteReader();
                        while (reader1.Read())
                        {
                            string maHangHoa = reader1.GetString(reader1.GetOrdinal("MaHangHoa"));
                            string tenHangHoa = reader1.GetString(reader1.GetOrdinal("TenHang"));
                            decimal giaBan = reader1.GetDecimal(reader1.GetOrdinal("GiaBan"));
                            double giaBanDouble = (double)giaBan;
                            int soLuong = reader1.GetInt32(reader1.GetOrdinal("SoLuong"));
                            UC_LoaiHH uLoaiHH = new UC_LoaiHH(this);
                            uLoaiHH.viTri = 170 * i;
                            uLoaiHH.viTriXuong = 220 * j;
                            uLoaiHH.Size = tabPage1.Size;
                            uLoaiHH.maHH = maHangHoa;
                            uLoaiHH.tenHH = tenHangHoa;
                            uLoaiHH.giaHH = giaBanDouble;
                            uLoaiHH.soLuong = soLuong;
                            tabPage1.Controls.Add(uLoaiHH);
                            uLoaiHH.BringToFront();
                            i++;
                            if (i == 5)
                            {
                                i = 0;
                                j++;
                            }
                        }
                        count = 0;
                        lastIndex++;
                    }

                }
                conn.Close();
                this.guna2TabControl1.SelectedIndex = lastIndex;
            }
        }
        private void Label_Click(object sender, EventArgs e)
        {
            LABEL = (Label)sender;
            MessageBox.Show("Nhập số lượng hàng cần mua");
            panel9.Visible = true;
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            flp_bangThanhToan.Controls.Clear();
            tongTienThanhToan = 0;
            flp_bangThanhToan.Controls.Add(panel9);
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
            int soDiem = int.Parse(txt_soDiem.Text);
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_themKhachHang", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sdt", sodienthoai);
            cmd.Parameters.AddWithValue("@maKH", txt_maKH.Text);
            cmd.Parameters.AddWithValue("@tennKH", txt_tenKhachHang.Text);
            cmd.Parameters.AddWithValue("@mathe", txt_maTheTichDiem.Text);
            cmd.Parameters.AddWithValue("@sodiem", soDiem);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_KhachHang.DataSource = dataTable;
            hienThi("ViewKhachHang", dgv_KhachHang);
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
            Application.Restart();
            //FMenu_Load(sender, e);
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

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tabQuanLyHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_NhapHang_Click_2(object sender, EventArgs e)
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

        private void btn_phaCa_Click(object sender, EventArgs e)
        {
            phanCa pc = new phanCa();
            this.Hide();
            pc.ShowDialog();
            this.Show();
        }

        private void btn_timPhatLuong_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = Connection_to_SQL.getConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.func_tinhLuongNVPartTime (@thang,@nam)", connection);
                cmd.Parameters.AddWithValue("@thang", int.Parse(date_phatLuong.Value.ToString("MM")));
                cmd.Parameters.AddWithValue("@nam", int.Parse(date_phatLuong.Value.ToString("yyyy")));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_partTime.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_fullTime_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = Connection_to_SQL.getConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.func_tinhLuongNVFullTime (@thang,@nam)", connection);
                cmd.Parameters.AddWithValue("@thang", int.Parse(date_phatLuongFull.Value.ToString("MM")));
                cmd.Parameters.AddWithValue("@nam", int.Parse(date_phatLuongFull.Value.ToString("yyyy")));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_fullTime.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_PhatLuongQL_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = Connection_to_SQL.getConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.func_tinhLuongQL (@thang,@nam)", connection);
                cmd.Parameters.AddWithValue("@thang", int.Parse(date_phatLuongQL.Value.ToString("MM")));
                cmd.Parameters.AddWithValue("@nam", int.Parse(date_phatLuongQL.Value.ToString("yyyy")));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_phatLuongQL.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txt_tenLoaiHang_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_themLoaiHang_Click_2(object sender, EventArgs e)
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
            Application.Restart();
            //FMenu_Load(sender, e);

        }

        private void lbl_tenNhaCC_Click(object sender, EventArgs e)
        {

        }

        private void lbl_GioiTinh_Click(object sender, EventArgs e)
        {

        }


        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btn_xoaHoaDon_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_xoaHoaDon", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahoadon", txt_maHoaDon.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_hoaDon.DataSource = dataTable;
            hienThi("ViewHoaDon", dgv_hoaDon);
            connection.Close();
        }

        private void dgv_hoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgv_hoaDon.Rows[e.RowIndex];
            txt_maHoaDon.Text = Convert.ToString(row.Cells["MaHoaDon"].Value);
            txt_maHoaDon.ReadOnly = true;
            date_ngayLap.Value = Convert.ToDateTime(row.Cells["NgayLap"].Value);
            txt_maKhachHang.Text = Convert.ToString(row.Cells["MaKhachHang"].Value);
            txt_maNhanVienHD.Text = Convert.ToString(row.Cells["MaNhanVien"].Value);
            txt_maPhieuTra.Text = Convert.ToString(row.Cells["MaPhieuTra"].Value);
            txt_soDiemTra.Text = Convert.ToString(row.Cells["soDiemTra"].Value);
            txt_maPhieuTich.Text = Convert.ToString(row.Cells["MaPhieu"].Value);
            txt_soDiemTich.Text = Convert.ToString(row.Cells["soDiemTich"].Value);
        }
        int tongTienThanhToan = 0;
        private void guna2Button3_Click_2(object sender, EventArgs e)
        {
            panel9.Visible = false;
            soLuong = int.Parse(txt_SoLuong1.Text);// soLuong
            string input;
            string output;
            foreach (Control control in flp_bangThanhToan.Controls)
            {
                if (control is Label && control == LABEL)
                {
                    string before2 = "       "; //mahh... tenhh
                    string before1 = "              ";// hang hoa .... gia ban
                    string before  = "                ";// gia ban ... soluong
                    string after   = "                  ";// soluong ... tong
                    input = control.Text;

                    // Tìm vị trí của giá trị trước và sau
                    int startIndex = input.IndexOf(before);
                    int startIndex1 = input.IndexOf(before1);
                    int startIndex2 = input.IndexOf(before2);
                    int endIndex = input.IndexOf(after, startIndex + before.Length);
                    string giaBan = input.Substring(startIndex1, startIndex1);
                    giaBan = giaBan.Replace(" ", "");
                    int tongTien = int.Parse(giaBan) * soLuong; // tien hang hoa
                    string maHH = input.Substring(0, startIndex2);//maHangHoa
                    tongTienThanhToan = tongTienThanhToan + tongTien;
                    if (startIndex != -1 && endIndex != -1)
                    {
                        // Thay thế chuỗi
                        string replacement = soLuong.ToString();
                        string replacedString = input.Substring(0, startIndex + before.Length) +"    " + replacement + "              " + tongTien;
                        MessageBox.Show(input.Substring(0, startIndex2));
                        control.Text = replacedString;
                    }
                    SqlConnection connection = Connection_to_SQL.getConnection();
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("proc_themHoaDon", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@mahoadon", txt_maHoaDonTT.Text);
                    cmd.Parameters.AddWithValue("@mahh", maHH);
                    cmd.Parameters.AddWithValue("@soLuong", soLuong);
                    cmd.Parameters.AddWithValue("@ngayLap", DateTime.Now);
                    cmd.Parameters.AddWithValue("@manv", txt_maNhanVienTT.Text);
                    cmd.Parameters.AddWithValue("@makh", txt_maKhachHangTT.Text);
                    cmd.Parameters.AddWithValue("@thanhtoan", tongTienThanhToan);
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_hoaDon.DataSource = dataTable;
                    hienThi("ViewHoaDon", dgv_hoaDon);
                    connection.Close();
                }
                
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_SuaKeHang_Click_1(object sender, EventArgs e)
        {

        }

        private void btn_suaHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void lbl_traCuuCaLV_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = Connection_to_SQL.getConnection();
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM dbo.func_phanCaLamViecTungNgay (@ngay,@thang,@nam)", connection);
                cmd.Parameters.AddWithValue("@ngay", int.Parse(date_phanCaTheoNgay.Value.ToString("dd")));
                cmd.Parameters.AddWithValue("@thang", int.Parse(date_phanCaTheoNgay.Value.ToString("MM")));
                cmd.Parameters.AddWithValue("@nam", int.Parse(date_phanCaTheoNgay.Value.ToString("yyyy")));
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_phanCaTheoNgay.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Label label = new Label();
            string str = "----------------------------------------------------------------------------------------------------------------------".ToString();
            label.Size = new Size(1000, 30);
            label.Text = str;
            flp_bangThanhToan.Controls.Add(label);
            Label label1 = new Label();
            string str1 = "Tổng thanh toán: " + tongTienThanhToan.ToString() + " VNĐ";
            label1.Size = new Size(1000, 30);
            label1.Text = str1;
            flp_bangThanhToan.Controls.Add(label1);

            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("proc_capNhatGiaThanhToan", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mahd", txt_maHoaDonTT.Text);
            cmd.Parameters.AddWithValue("@thanhtoan", tongTienThanhToan);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dgv_hoaDon.DataSource = dataTable;
            hienThi("ViewHoaDon", dgv_hoaDon);
            connection.Close();
        }

        private void btn_chiTietHoaDon_Click(object sender, EventArgs e)
        {
            FChiTietHoaDon pc = new FChiTietHoaDon();
            this.Hide();
            pc.ShowDialog();
            this.Show();
        }
    }
}
