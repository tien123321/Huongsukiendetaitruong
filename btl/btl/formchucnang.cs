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
using btl.Xulyacountsinhvien;
using btl.xulyacounGiaovien;
using btl.Xulyacountadmin;

namespace btl
{
    public partial class Formchucnangachocsinh : Form
    {
        public Formchucnangachocsinh()
        {
            InitializeComponent();
        }
        string ten;
        int loaitk;
        thongtintaikhoan a = new thongtintaikhoan();

        //Form tài khoản sinh viên
        form_hocsinh_Hocsinh formsv = new form_hocsinh_Hocsinh();
        Formchucnang_Môn_học form1sv = new Formchucnang_Môn_học();
     

        //Form Tài khoản giáo viên
        FormHocsinh_AcountGiaovien formgv = new FormHocsinh_AcountGiaovien();
        FormMonhoc_Acountgiaovien form1gv = new FormMonhoc_Acountgiaovien();
        FormDiemtk_AcountGiaovien form2gv = new FormDiemtk_AcountGiaovien();
        FormLophoc_AcountGiaovien form3gv = new FormLophoc_AcountGiaovien();

        //Form tài khoản admin
        formHocsinh_AccountAdmin formad = new formHocsinh_AccountAdmin();
        FormMonhoc_AccountAddmin form1ad = new FormMonhoc_AccountAddmin();
        FormGiaovien_AcountAdmin form2ad = new FormGiaovien_AcountAdmin();
        FormDiemtk_AcountAdmin form3ad = new FormDiemtk_AcountAdmin();
        FormLop_acountAdmin form4ad = new FormLop_acountAdmin();
        public void loadform(Form form)
        {
            form.TopLevel = false;
            panel5.Controls.Add(form);
            form.FormBorderStyle =FormBorderStyle.None;
            
            form.Show();
        }
        private void Formchucnang_Load(object sender, EventArgs e)
        {
           
            ten = Properties.Settings.Default.tennguoisudung;
            a.loadthongtin(ten);
            loaitk = a.loaitaikhoan;
            lb_tennguoi.Text = ten;
            DateTime Hientai = DateTime.Now;
            lb_ngay.Text = Hientai.ToString("dd-MM-yyyy");
            if(loaitk==0 ||loaitk==1 )
            {
                lbChedo.Text = "Thông tin Quản lý Điểm học sinh";
                if (loaitk == 1)
                {
                    btn_Giaovien.Visible = false;
                    ptb_Giaovien.Visible = false;
                }
            }
            
            else 
            {
                lbChedo.Text = "Thông tin cá nhân";
                btn_Giaovien.Visible = false;
                ptb_Giaovien.Visible = false;
                btn_Lophoc.Visible = false;
                Ptb_Lophoc.Visible = false;
                btn_Diemtongket.Visible = false;
                pictureBox5.Visible = false;
            }
            btn_DScaclophoc.BackColor = Color.Bisque;
            btn_Diemtongket.BackColor = Color.White;
            Btn_Monhoc.BackColor = Color.White;
            if (loaitk == 2)
            {
                loadform(formsv);
                formsv.formload();
            }
            else if (loaitk == 1)
            {
                loadform(formgv);
                formgv.formload();
            }
            else
            {
                loadform(formad);
                formad.loadform();
            }

        }
       
        private void btn_DScaclophoc_Click(object sender, EventArgs e)
        {

            btn_DScaclophoc.BackColor = Color.Bisque;
            btn_Diemtongket.BackColor = Color.White;
            Btn_Monhoc.BackColor = Color.White;
            btn_Giaovien.BackColor = Color.White;
            btn_Lophoc.BackColor = Color.White;
            

            if (loaitk == 2)
            {
                form1sv.Hide();
                loadform(formsv);
                formsv.formload();
            }
            else if (loaitk == 1)
            {
                form1gv.Hide();
                form2gv.Hide();
                form3gv.Hide();

                loadform(formgv);
                formgv.formload();
            }
            else
            {
                form1ad.Hide();
                form2ad.Hide();
                form3ad.Hide();
                form4ad.Hide();

                loadform(formad);
                formad.loadform();
            }
        }

        private void Btn_Monhoc_Click(object sender, EventArgs e)
        {
            btn_DScaclophoc.BackColor = Color.White;
            btn_Diemtongket.BackColor = Color.White;
            btn_Giaovien.BackColor = Color.White;
            btn_Lophoc.BackColor = Color.White;
            Btn_Monhoc.BackColor = Color.Bisque;
            

            if (loaitk == 2)
            {
                formsv.Hide();
                

                loadform(form1sv);
                form1sv.formload();
            }
            else if (loaitk == 1)
            {
                formgv.Hide();
                form2gv.Hide();
                form3gv.Hide();

                loadform(form1gv);
                form1gv.formload();
            }
            else
            {
                formad.Hide();
                form2ad.Hide();
                form3ad.Hide();
                form4ad.Hide();

                loadform(form1ad);
                form1ad.loadform();
            }
        }

        private void btn_Diemtongket_Click(object sender, EventArgs e)
        {
            btn_DScaclophoc.BackColor = Color.White;
            btn_Diemtongket.BackColor = Color.Bisque;
            btn_Giaovien.BackColor = Color.White;
            btn_Lophoc.BackColor = Color.White;
            Btn_Monhoc.BackColor = Color.White;
            if (loaitk == 1)
            {
                formgv.Hide();
                form1gv.Hide();
                form3gv.Hide();

                loadform(form2gv);
                form2gv.formload();
            }
            else
            {
                formad.Hide();
                form1ad.Hide();
                form2ad.Hide();
                form4ad.Hide();

                loadform(form3ad);
                form3ad.formload();
            }

        }

        private void btn_Lophoc_Click(object sender, EventArgs e)
        {
            btn_DScaclophoc.BackColor = Color.White;
            btn_Diemtongket.BackColor = Color.White;
            btn_Giaovien.BackColor = Color.White;
            btn_Lophoc.BackColor = Color.Bisque;
            Btn_Monhoc.BackColor = Color.White;
            if (loaitk == 1)
            {
                formgv.Hide();
                form1gv.Hide();
                form2gv.Hide();

                loadform(form3gv);
                form3gv.formload();
                
            }
            else
            {
                formad.Hide();
                form1ad.Hide();
                form2ad.Hide();
                form3ad.Hide();

                loadform(form4ad);
                form4ad.loadform();


            }
        }

        private void btn_Giaovien_Click(object sender, EventArgs e)
        {
            btn_DScaclophoc.BackColor = Color.White;
            btn_Diemtongket.BackColor = Color.White;
            btn_Giaovien.BackColor = Color.Bisque;
            btn_Lophoc.BackColor = Color.White;
            Btn_Monhoc.BackColor = Color.White;

            formad.Hide();
            form1ad.Hide();
            form4ad.Hide();
            form3ad.Hide();

            loadform(form2ad);
            form2ad.formload();
        }

        private void lb_tennguoi_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
