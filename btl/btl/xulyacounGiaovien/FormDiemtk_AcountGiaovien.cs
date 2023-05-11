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
using btl.Báo_cáo_dữ_liệu;

namespace btl.xulyacounGiaovien
{
    public partial class FormDiemtk_AcountGiaovien : Form
    {
        public FormDiemtk_AcountGiaovien()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        Xulydulieudiem xl = new Xulydulieudiem();
        public void formload()
        {
            tbl.Clear();
            tbl = xl.loaddulieu();
            dataGridView1.DataSource = tbl;
        }
        private void FormDiemtk_AcountGiaovien_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formrepost form = new formrepost();
            thongkettdanhhieuhs rpt = new thongkettdanhhieuhs();
            tbl = (DataTable)dataGridView1.DataSource;
            rpt.SetDataSource(tbl);
            form.crystalReportViewer1.ReportSource = rpt;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
