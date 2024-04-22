using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dbms
{
    public partial class UC_LoaiHH : UserControl
    {
        public string tenHH;
        public double giaHH;
        public int soLuong;
        public int viTri;
        public int viTriXuong;
        public UC_LoaiHH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

            FMenu menu = new FMenu();
            menu.tenHangHoa = tenHH;
            menu.soLuong = soLuong;
            menu.giaBan = giaHH;
            //this.Hide();
            menu.ShowDialog();
            // this.Show();
        }

        private void UC_LoaiHH_Load(object sender, EventArgs e)
        {
            this.Size = new Size(229, 257);
            this.Location = new Point(viTri, viTriXuong);
            lbl_tenHH.Text = tenHH + ": " + giaHH.ToString();
            lbl_SL.Text = "SL: " + soLuong.ToString();
        }
    }
}
