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
using btl.xulyacounGiaovien.Xulydulieuacontgv;
using btl.xulyacounGiaovien.formxuly;
using btl.Báo_cáo_dữ_liệu;


namespace btl.xulyacounGiaovien
{

    public partial class FormHocsinh_AcountGiaovien : Form
    {
        public FormHocsinh_AcountGiaovien()
        {
            InitializeComponent();
        }
        string ma="";
        DataTable tbl = new DataTable();
        xulyhocsinh_giaovien xl = new xulyhocsinh_giaovien();
        public void formload()
        {
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            tbl.Clear();
            tbl = xl.hienthidulieu();
            dataGridView1.DataSource = tbl;
        }
        private void FormHocsinh_AcountGiaovien_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            formsuatths form1 = new formsuatths(ma);
            if (ma == "")
            {
                MessageBox.Show("Vui lòng chọn mã học sinh cần sửa", "Thông báo");
            }
            else
            {
                form1.ShowDialog();
                tbl.Clear();
                tbl = xl.hienthidulieu();
                dataGridView1.DataSource = tbl;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ma = dataGridView1.Rows[e.RowIndex].Cells["nMasv"].Value.ToString();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formtimsv tim = new formtimsv(tbl);
            tim.ShowDialog();
            tbl = tim.tbl;
            dataGridView1.DataSource = tbl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = xl.hienthidulieu();
            dataGridView1.DataSource = tbl;
            tbl.Clear();
            tbl = xl.hienthidulieu();
            dataGridView1.DataSource = tbl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formrepost form = new formrepost();
            tbl = (DataTable)dataGridView1.DataSource;
            thongketthocsinh rpt = new thongketthocsinh();
            rpt.SetDataSource(tbl);
            form.crystalReportViewer1.ReportSource = rpt;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
