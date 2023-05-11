using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl.xulyacounGiaovien.Xulydulieuacontgv;

namespace btl.xulyacounGiaovien.formxuly
{
    public partial class formsuatths : Form
    { string ma;
       
        public formsuatths(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }
        xulyhocsinh_giaovien xl = new xulyhocsinh_giaovien();
        string ktr;
        private void formsua_Load(object sender, EventArgs e)
        {
            tb_Masv.Enabled = false;
            cbx_Malop.Enabled = false;
            int n = xl.timdulieu(ma);
            
            tb_Masv.Text = ma;

            tb_Diachi.Text = xl.diachi;
            tb_tensv.Text = xl.Tenhs;
            cbx_Malop.Text = xl.lophoc;
            DateTime ngay = xl.Ngaysinh;
           dtpk_Ngaysinh.Value = ngay;
            ktr = xl.Gioiting;
            if (ktr=="Nam")
            {
                cb_Gioitinh.Checked = true;
            }
            else
            {
                cb_Gioitinh.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tb_Masv.Text == "")
            {
                errorProvider1.SetError(tb_Masv, "Mã sinh viên không được để trống");
            }
            else if (tb_tensv.Text == "")
            {
                errorProvider1.SetError(tb_tensv, "Tên sinh viên không được để trống");

            }
            else if (tb_Diachi.Text == "")
            {
                errorProvider1.SetError(tb_Diachi, "Địa chỉ không được để trống");
            }
            else
            {
                DateTime abc = dtpk_Ngaysinh.Value;
                ktr = xl.Gioiting;
                int n = xl.themhoacsua(tb_Masv.Text, tb_tensv.Text, abc,
                     ktr, tb_Diachi.Text, cbx_Malop.Text, "pr_updatedulieu");

            }
            this.Dispose();
        }
    }
}
