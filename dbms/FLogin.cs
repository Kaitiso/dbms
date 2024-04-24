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
    public partial class FLogin : Form
    {
        //xem login
        public FLogin()
        {
            InitializeComponent();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection_to_SQL.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("SELECT dbo.func_kiemTraDangNhap(@username, @password)", connection);
            cmd.Parameters.AddWithValue("@username", txt_TaiKhoan.Text);
            cmd.Parameters.AddWithValue("@password", txt_matKhau.Text);
            bool count = (bool)cmd.ExecuteScalar();
            if (count)
            {
                FMenu menu = new FMenu();
                menu.tenTaiKhoan = txt_TaiKhoan.Text;
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
        }
    }
}
