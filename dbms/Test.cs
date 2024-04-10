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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btn_DanhMucHang_Click(object sender, EventArgs e)
        {
            uC_DanhMucHang1.BringToFront();
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            uC_HoaDon1.BringToFront();
        }

        private void btn_NhanVienTheoCa_Click(object sender, EventArgs e)
        {
            uC_NhanVienTheoCa1.BringToFront();
        }

        private void btn_PhieuNhapDonHang_Click(object sender, EventArgs e)
        {
            uC_PhieuNhapDonHang1.BringToFront();
        }

        private void btn_PhieuTichDiem_Click(object sender, EventArgs e)
        {
            uC_PhieuTichDiem1.BringToFront();
        }

        private void btn_ThongKeTaiChinh_Click(object sender, EventArgs e)
        {
            uC_ThongKeTaiChinh1.BringToFront();
        }

        private void btn_ViTriHangHoa_Click(object sender, EventArgs e)
        {
            uC_ViTriHangHoa1.BringToFront();
        }

        private void uC_ViTriHangHoa1_Load(object sender, EventArgs e)
        {

        }
    }
}
