using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl.Xulydulieu.Xuthithongtintaikhoan;


namespace btl
{
    public partial class formitemthongtintaikhoan : Form
    {
        public formitemthongtintaikhoan()
        {
            InitializeComponent();
        }
        thongtintaikhoan a = new thongtintaikhoan();
        string tennguoisd;
        int loaitk;
        private void formitemthongtintaikhoan_Load(object sender, EventArgs e)
        {
           

            tennguoisd = Properties.Settings.Default.tennguoisudung;
            a.loadthongtin(tennguoisd);
            tb_Tennguoisudung.Text = tennguoisd;
            
            tb_Tendangnhap.Text = a.Tendangnhap;
            tb_Matkhau.Text = a.Matkhau;
            loaitk = a.loaitaikhoan;
            if (loaitk == 0)
            {
                lb_Chucvu.Text = "admin == Hiệu trưởng";
                DateTime ngay1 = a.ngaysinh;
                dtpk_Ngaysinh.Value = ngay1;

            }
            else if (loaitk == 1)
            {
                DateTime ngay1 = a.ngaysinh;
                lb_Chucvu.Text = "Giáo viên";
                dtpk_Ngaysinh.Value = ngay1;
            }
            else
            {
                DateTime ngay1 = a.ngaysinh;
                lb_Chucvu.Text = "Học sinh";
                dtpk_Ngaysinh.Value = ngay1;
            }

            
        }

        private void btl_Doidulieu_Click(object sender, EventArgs e)
        {
            tennguoisd = Properties.Settings.Default.tennguoisudung;
            DialogResult result = MessageBox.Show("Xác nhận lại:",
                  "Bạn có chắc chắn muốn thay đổi thông tin?",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                bool ktr = a.suathongtin(
                    tb_Tendangnhap.Text, tb_Matkhau.Text, tennguoisd, dtpk_Ngaysinh.Value);

            }
            else
                return;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tb_Tennguoisudung_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
