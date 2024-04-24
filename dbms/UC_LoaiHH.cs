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
        public string maHH;
        public string tenHH;
        public double giaHH;
        public int soLuong;
        public int viTri;
        public int viTriXuong;
        public FMenu menu;
        public UC_LoaiHH(FMenu f)
        {
            InitializeComponent();
            menu = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            menu.maHH = maHH;
            menu.tenHangHoa = tenHH;
            menu.soLuong = soLuong;
            menu.giaBan = giaHH;
            menu.check = true;
            menu.FMenu_Load(menu, EventArgs.Empty);
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
