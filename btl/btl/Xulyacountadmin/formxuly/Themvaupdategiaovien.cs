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

namespace btl.Xulyacountadmin.formxuly
{
    public partial class Themvaupdategiaovien : Form
    {
        private string ma;
        Xulyad_Giaovien xl = new Xulyad_Giaovien();
        public Themvaupdategiaovien(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
                errorProvider1.Clear();
                if (tb_Magv.Text == "")
                {
                    errorProvider1.SetError(tb_Magv, "Mã sinh viên không được để trống");
                }
                else if (tb_tensgv.Text == "")
                {
                    errorProvider1.SetError(tb_tensgv, "Tên sinh viên không được để trống");

                }

                else
                {

                    DateTime abc = dtpk_Ngaysinh.Value;
                    string gt;
                    if (cb_Gioitinh.Checked)
                    {
                        gt = "Nam";
                    }
                    else gt = "Nữ";
               
                   string a= xl.addorupdategiaovien(tb_Magv.Text, tb_tensgv.Text,
                         abc, gt, "insert_Giaovien");
                    if (a== "Đã thêm Giáo viên mới")
                {
                    MessageBox.Show("Đã Thêm Giáo viên mới");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại khóa chính");
                }
                }

                
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (tb_Magv.Text == "")
            {
                errorProvider1.SetError(tb_Magv, "Mã sinh viên không được để trống");
            }
            else if (tb_tensgv.Text == "")
            {
                errorProvider1.SetError(tb_tensgv, "Tên sinh viên không được để trống");

            }
            
            else
            {
                DateTime abc = dtpk_Ngaysinh.Value;
                string gt;
                if (cb_Gioitinh.Checked)
                {
                    gt = "Nam";
                }
                else gt = "Nữ";
                xl.addorupdategiaovien(tb_Magv.Text,
                   tb_tensgv.Text, abc,
                   gt, "update_giaovien");

            }
            this.Dispose();
        }

        private void Themvaupdategiaovien_Load(object sender, EventArgs e)
        {
            


            if (ma == "")
            {
                button2.Visible = false;
            }
            else
            {
                button1.Visible = false;
                xl.timdulieu(ma);
                tb_Magv.Text = ma;

               
                tb_tensgv.Text = xl.Tengv;
                DateTime abc = xl.Ngaysinh;
                
                dtpk_Ngaysinh.Value = abc;
                string ktr=xl.gioitinh ;
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

        private void tb_Magv_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
