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
    public partial class Formdangnhap : Form
    {

        public Formdangnhap()
        {
            InitializeComponent();

        }



        public bool kt;
        public bool Kt
        {
            get { return kt; }
            set { kt = value; }
        }



        public string tennguoisd ;
        public string Tennguoisd
        {
            get { return tennguoisd; }
            set { tennguoisd = value; }
        }


        Xulydulieu.Xulydangnhap.Dangnhap dangnhap = new Xulydulieu.Xulydangnhap.Dangnhap();
        
         public void btn_Dangnhap_Click(object sender, EventArgs e)
        {
            tennguoisd = "";


            errorProvider1.Clear();
            lb_Thongbao.Text = "";
            string txtDN = tb_Tendangnhap.Text;
            string txtMK = tb_Matkhau.Text;
            bool a, ktraDn;
            if (tb_Tendangnhap.Text == "")
            {
                errorProvider1.SetError(tb_Tendangnhap, "Tên đăng nhập không được để trống");
                a = false;
            }
            else if (tb_Matkhau.Text == "")
            {
                errorProvider1.SetError(tb_Matkhau, "Tên mật khẩu không được để trống");
                a = false;
            }
            else
            {
                ktraDn = dangnhap.kiemtraDangnhap(txtDN, txtMK);
                if (ktraDn == true)
                {
                    MessageBox.Show("Đăng nhập thành công","Wellcome");
                    tennguoisd = dangnhap.Tennguoisd.ToString();
                    kt = true;
                    Properties.Settings.Default.tennguoisudung = tennguoisd;
                    Properties.Settings.Default.Save();

                    Formtrangchu x = new Formtrangchu();
                    this.Hide();
                    x.ShowDialog();
                    this.Show();

                    
                    if (cb_Nhomatkhau.Checked)
                    {
                        Properties.Settings.Default.tendangnhap1 = txtDN;
                        Properties.Settings.Default.Matkhau = txtMK;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.tendangnhap1 = "";
                        Properties.Settings.Default.Matkhau = "";
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    lb_Thongbao.Text = "Sai tài khoản hoặc mật khẩu kiểm tra lại";
                }
            }
        }
        public bool ktrclick()
        {
            return kt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tb_Tendangnhap.Text= Properties.Settings.Default.tendangnhap1 ;
            tb_Matkhau.Text= Properties.Settings.Default.Matkhau ;
        }
        
        private void lb_Quenmatkhau_Click(object sender, EventArgs e)
        {

            FormQuenmatkhau quenmatkhau = new FormQuenmatkhau();
            quenmatkhau.Show();
            

        }

        public void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
