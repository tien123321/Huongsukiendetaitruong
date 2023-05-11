using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using btl.Xulyacountadmin.XulydulieuData;

namespace btl.Xulyacountadmin.formxuly
{
    public partial class formtimkiemhs : Form
    {
        public DataTable tbl { get; set; }
        public formtimkiemhs(DataTable tbl)
        {
            InitializeComponent();
            this.tbl = tbl;
        }
        Xulydlad_Hocsinh xl = new Xulydlad_Hocsinh();
        private void formtimkiemhs_Load(object sender, EventArgs e)
        {
            rb_Nam.Checked = false;
            rb_Nu.Checked = false;
            string[] cb = new string[8] {"Lớp 6A", "Lớp 6B",
                                         "Lớp 7A", "Lớp 7B",
                                         "Lớp 8A", "Lớp 8B",
                                         "Lớp 9A", "Lớp 9B" };
            foreach (string i in cb)
            {
                comboBox1.Items.Add(i);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ktr = false;
            errorProvider1.Clear();
            string ngay = "", thang = "", nam = "";
            string ngaysinh = mtb_Ngaysinh.Text;
            if (ngaysinh.Length == 6)
            {

                ngay = ngaysinh.Substring(0, 2);
                thang = ngaysinh.Substring(3, 2);
                if (ngay == "1 " || ngay == "2 " || ngay == "3 "
                || thang == "1 ")
                {
                    errorProvider1.SetError(mtb_Ngaysinh, "Vui long nhập đủ thông tin");
                    ktr = true;
                }
            }
            else if (ngaysinh.Length == 10)
            {
                ngay = ngaysinh.Substring(0, 2);
                thang = ngaysinh.Substring(3, 2);
                nam = ngaysinh.Substring(6, 4);
                if (ngay == "1 " || ngay == "2 " || ngay == "3 "
                || thang == "1 ")
                {
                    errorProvider1.SetError(mtb_Ngaysinh, "Vui long nhập đủ thông tin");
                    ktr = true;
                }
            }
            else
            {

                errorProvider1.SetError(mtb_Ngaysinh, "Vui long nhập đủ thông tin");
                ktr = true;
            }
            if (ngay == "  ")
            {
                ngay = "";
            }
            if (thang == "  ")
            {
                thang = "";
            }
            string newday = ngay.TrimStart('0');
            string newmounth = thang.TrimStart('0');
            string gt = "";
            if (rb_Nam.Checked) gt = "Nam";
            if (rb_Nu.Checked) gt = "Nữ";
            if (ktr == false)
            {
                //tbl.Clear();
               // MessageBox.Show(textBox1.Text);
                tbl = xl.timkiemhs(tb_Ma.Text,
                    tb_ten.Text, newday, newmounth, nam, gt,
                    textBox1.Text, comboBox1.Text);
            }
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
