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

        private void UC_TinhDoanhThuTheoNgay_Load(object sender, EventArgs e)
        {
            //this.Size = new Size(1176, 682);
            //lbl_QuanLyDoanhThuNgay.Location = new Point(382, 20);
            //lbl_QuanLyDoanhThuNgay.Size = new Size(425, 36);

            //lbl_NhapNgay.Location = new Point(120, 96);
            //lbl_NhapNgay.Size = new Size(107, 25);

            //txt_Ngay.Location = new Point(251, 100);
            //txt_Ngay.Size = new Size(166, 22);

            //lbl_NhapThang.Location = new Point(455, 96);
            //lbl_NhapThang.Size = new Size(113, 25);

            //txt_Thang.Location = new Point(586, 100);
            //txt_Thang.Size = new Size(166, 22);

            //lbl_NhapNam.Location = new Point(810, 96);
            //lbl_NhapNam.Size = new Size(102, 25);

            //txt_Nam.Location = new Point(941, 100);
            //txt_Nam.Size = new Size(166, 22);

            //btn_HienThi.Location = new Point(495, 169);
            //btn_HienThi.Size = new Size(180, 45);

            //panel1.Location = new Point(12, 274);
            //panel1.Size = new Size(255, 155);

            //panel2.Location = new Point(310, 274);
            //panel2.Size = new Size(255, 155);

            //panel3.Location = new Point(615, 274);
            //panel3.Size = new Size(255, 155);

            //panel4.Location = new Point(910, 274);
            //panel4.Size = new Size(255, 155);

            //lbl_GiaNhapHang.Location = new Point(59, 15);
            //lbl_GiaNhapHang.Size = new Size(140, 25);

            //lbl_Gia.Location = new Point(27, 67);
            //lbl_Gia.Size = new Size(42, 25);

            //lbl_VND1.Location = new Point(179, 67);
            //lbl_VND1.Size = new Size(54, 25);

            //lbl_GiaBanHang.Location = new Point(51, 15);
            //lbl_GiaBanHang.Size = new Size(129, 25);

            //lbl_Gia1.Location = new Point(16, 67);
            //lbl_Gia1.Size = new Size(42, 25);

            //lbl_VND2.Location = new Point(179, 67);
            //lbl_VND2.Size = new Size(54, 25);

            //lbl_LuongNhanVien.Location = new Point(52, 15);
            //lbl_LuongNhanVien.Size = new Size(157, 25);

            //lbl_Gia2.Location = new Point(17, 67);
            //lbl_Gia2.Size = new Size(42, 25);

            //lbl_VND3.Location = new Point(188, 67);
            //lbl_VND3.Size = new Size(54, 25);

            //lbl_TongDoanhThu.Location = new Point(3, 15);
            //lbl_TongDoanhThu.Size = new Size(247, 25);

            //lbl_Gia3.Location = new Point(13, 67);
            //lbl_Gia3.Size = new Size(42, 25);

            //lbl_VND4.Location = new Point(198, 67);
            //lbl_VND4.Size = new Size(54, 25);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
