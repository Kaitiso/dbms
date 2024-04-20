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
        public UC_LoaiHH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void UC_LoaiHH_Load(object sender, EventArgs e)
        {
            this.Size = new Size(229, 257);
    //      lbl_tenHH.Size = new Size(108, 20);
     //     lbl_tenHH.Location = new Point(59, 184);
     //     lbl_SL.Size = new Size(62, 20);
     //     lbl_SL.Location = new Point(81, 215);
            lbl_tenHH.Text = tenHH + ": " + giaHH.ToString();
            lbl_SL.Text = "SL: " + soLuong.ToString();
        }
    }
}
