using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl
{
    public partial class FormQuenmatkhau : Form
    {
        public FormQuenmatkhau()
        {
            InitializeComponent();
        }

        private void lb_Quaulaidangnhap_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }
        Xulydulieu.Xulydangnhap.Quenmatkhau x=new Xulydulieu.Xulydangnhap.Quenmatkhau();
        private void btn_Xacnhan_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string tenuser = tb_Tennguoisudung.Text;
            string tentk = tb_Tentaikhoan.Text;
            string mk = tb_Matkhaumoi.Text;
            string mknl = tb_Nhaplaimk.Text;
            bool ktr = x.kiemtramk(mk);
            bool doi;
            if (tenuser == "")
            {
                errorProvider1.SetError(tb_Tennguoisudung, "Tên người sử dụng không được trống");
            }
            else if (tentk == "")
            {
                errorProvider1.SetError(tb_Tentaikhoan, "Tên tài khoản không được trống");
            }
            else if (mk == "")
            {
                errorProvider1.SetError(tb_Matkhaumoi, "Mật khẩu không được để trống");
            }
            else if (ktr == false)
            {
                errorProvider1.SetError(tb_Matkhaumoi,
                    "Mật khẩu cần có chữ hoa,chữ thường ,số ,và từ 6 đến 24 kí tự");
            }
            else if (mknl !=mk)
            {
                errorProvider1.SetError(tb_Nhaplaimk, "Mật khẩu nhập lại không khớp");
            }
            else
            {
                doi = x.Doimatkhau(mk, tenuser, tentk);
                if (doi)
                {
                    this.Close();
                }
                else
                    lbKiemtra.Text = "Kiểm tra lại thông tin Tên đang nhập và Tên người sử dụng";
            }
            
            

        }

        private void FormQuenmatkhau_Load(object sender, EventArgs e)
        {

        }
    }
}
