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
    public partial class formsuattdiem : Form
    {
        string ma;
        public formsuattdiem(string ma)
        {
            InitializeComponent();
            this.ma = ma;
        }
        Xulydiemmonhocsv xl = new Xulydiemmonhocsv();
        private void formsuattdiem_Load(object sender, EventArgs e)
        {
            int n = xl.timdulieu(ma);
            tb_Mabangdiem.Enabled = false;
            tb_tenmonhoc.Enabled = false;
            tb_tensv.Enabled = false;


            tb_Mabangdiem.Text = ma;
            tb_tenmonhoc.Text = xl.tenmonhoc;
            tb_tensv.Text = xl.tensv;
            tb_DM.Text = xl.diemmieng.ToString();
            tb_D15.Text = xl.diem15phut.ToString();
            tbD1.Text = xl.diem1tiet.ToString();
            tb_Dhk.Text = xl.diemhocki.ToString();
            tbDT.Text = xl.diemthi.ToString();

        }
        private void checkdiem()
        {
            try 
            {
                if (float.Parse(tb_DM.Text) < 0 || float.Parse(tb_DM.Text) > 10
                    || float.Parse(tb_D15.Text) < 0 || float.Parse(tb_D15.Text) > 10
                    || float.Parse(tbDT.Text) < 0 || float.Parse(tbDT.Text) > 10
                    || float.Parse(tbD1.Text) < 0 || float.Parse(tbD1.Text) > 10
                    || float.Parse(tb_Dhk.Text) < 0 || float.Parse(tb_Dhk.Text) > 10)
                {
                    int a = 10, b =0 ; float x = a / b;
                }
                else
                {
                    int n = xl.themhoacsua(tb_Mabangdiem.Text, xl.mamon,
                     float.Parse(tb_DM.Text),
                     float.Parse(tbDT.Text),
                    float.Parse(tb_D15.Text),
                    float.Parse(tbD1.Text),
                    float.Parse(tb_Dhk.Text));
                    this.Dispose();
                }
            }
            catch
            {
                MessageBox.Show("Điểm sửa không hợp lệ");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkdiem();
           

        }
    }
}
