using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl.Xulyacountadmin.XulydulieuData;



namespace btl.Xulyacountadmin.FormThemdulieu
{
    public partial class Themhs : Form
    {
        string ma;
        public Themhs(string ma)
        {
            InitializeComponent();
            this.ma = ma;
       
        }
        Xulydlad_Hocsinh xl = new Xulydlad_Hocsinh();
        string gt;
        private void kiemtra()
        {
            
            if (cb_Gioitinh.Checked)
            {
                gt = "Nam";
            }
            else gt = "Nữ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            errorProvider1.Clear();
            if (tb_Masv.Text == "")
            {
                errorProvider1.SetError(tb_Masv,"Mã sinh viên không được để trống");
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
                kiemtra();
               string n= xl.themhoacsua(tb_Masv.Text,tb_tensv.Text,abc,
                    gt,tb_Diachi.Text,cbx_Malop.Text, "themhs");
                MessageBox.Show(n);
                if (n != "Kiểm tra lại ràng buộc khóa chính")
                    this.Dispose();
            }
            
            
        }

        private void Themhs_Load(object sender, EventArgs e)
        {
            cbx_Malop.Text = "LH6A";
            string[] cb = new string[8] {"LH6A", "LH6B",
                                         "LH7A", "LH7B",
                                         "LH8A", "LH8B",
                                         "LH9A", "LH9B" };
            foreach(string i in cb)
            {
                cbx_Malop.Items.Add(i);
            }
            if (ma == "")
            {
                button2.Visible = false;
            }
            else
            {
                button1.Visible = false;
                int n = xl.timdulieu(ma);
                tb_Masv.Text = ma;

                tb_Diachi.Text = xl.diachi;
                tb_tensv.Text = xl.Tenhs;
                cbx_Malop.Text = xl.lophoc;
                dtpk_Ngaysinh.Value = xl.Ngaysinh;
                string ktr = xl.Gioiting;
                if (ktr=="Nam")
                {
                    cb_Gioitinh.Checked = true;
                }
                else
                {
                    cb_Gioitinh.Checked = false;
                }
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
                kiemtra();
                string n = xl.themhoacsua(tb_Masv.Text, tb_tensv.Text, abc,
                     gt, tb_Diachi.Text, cbx_Malop.Text, "pr_updatedulieu");

            }
           this.Dispose();
        }
    }
}
