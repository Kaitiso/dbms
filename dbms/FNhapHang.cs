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
    public partial class FNhapHang : Form
    {
        public FNhapHang()
        {
            InitializeComponent();
            hienThi("ViewNhapHang", dgv_nhapHang);
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
            cmd.Parameters.AddWithValue("@maphieunhap", txt_maPhieuNhap.Text);
            cmd.Parameters.AddWithValue("@ngaynhaphang", date_NgayNhapHang.Value);
            cmd.Parameters.AddWithValue("@manv", txt_maNV.Text);
            cmd.Parameters.AddWithValue("@manhacc", txt_maNhaCC.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            double giaNhap = int.Parse(txt_giaNhap.Text);
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("proc_themHangHoa", connection);
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@mahh", txt_maHH.Text);
            cmd1.Parameters.AddWithValue("@tenhh", txt_tenHH.Text);
            cmd1.Parameters.AddWithValue("@maloaihh", txt_maLoaiHH.Text);
            cmd1.Parameters.AddWithValue("@hsd", date_HSD.Value);
            cmd1.Parameters.AddWithValue("@giaban", giaNhap);
            cmd1.Parameters.AddWithValue("@donvitinh", "VND");
            cmd1.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmd1);
            DataTable dataTable1 = new DataTable();
            adapter1.Fill(dataTable1);
            connection.Close();
            int soLuong = int.Parse(txt_soLuong.Text);
            double tongTien = giaNhap * soLuong;
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("proc_themChiTietHH", connection);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@maphieunhap", txt_maPhieuNhap.Text);
            cmd2.Parameters.AddWithValue("@mahh", txt_maHH.Text);
            cmd2.Parameters.AddWithValue("@gianhap", giaNhap);
            cmd2.Parameters.AddWithValue("@soluong", soLuong);
            cmd2.Parameters.AddWithValue("@tongtien", tongTien);
            cmd2.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter2 = new SqlDataAdapter(cmd2);
            DataTable dataTable2 = new DataTable();
            adapter2.Fill(dataTable2);
            connection.Close();
            hienThi("ViewNhapHang", dgv_nhapHang);
        }

        private void FNhapHang_Load(object sender, EventArgs e)
        {

        }
    }
}
