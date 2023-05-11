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
using btl.xulyacounGiaovien.formxuly;
using btl.Báo_cáo_dữ_liệu;
using btl.Báo_cáo_dữ_liệu.ListBaocao;
using System.Web.UI.WebControls;
using btl.Connectionstring;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace btl.xulyacounGiaovien
{
    public partial class FormMonhoc_Acountgiaovien : Form
    {
        public FormMonhoc_Acountgiaovien()
        {
            InitializeComponent();
        }
        Xulydiemmonhocsv xl = new Xulydiemmonhocsv();
        DataTable tbl = new DataTable("QLdiem");
        string ma = "";
        public void formload()
        {
            tbl.Clear();
            tbl = xl.loadttdiem();
            dataGridView1.DataSource = tbl;
        }
        private void FormMonhoc_Acountgiaovien_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formsuattdiem form1 = new formsuattdiem(ma);
            if (ma == "")
            {
                MessageBox.Show("Vui lòng chọn mã học sinh cần sửa", "Thông báo");
            }
            else
            {
                form1.ShowDialog();
                tbl.Clear();
                tbl = xl.loadttdiem();
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
          
            formtimdiemmonhocgv form1 = new formtimdiemmonhocgv(tbl);
            form1.ShowDialog();
            tbl.Clear();
            tbl = form1.tbl;
            dataGridView1.DataSource = tbl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formload();
            formload();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formrepost form = new formrepost();
            
            tbl = (DataTable)dataGridView1.DataSource;
            Thongkediemmon rpt = new Thongkediemmon();
            rpt.SetDataSource(tbl);
            form.crystalReportViewer1.ReportSource = rpt;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
