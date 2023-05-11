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
using btl.Chức_năng_tìm_kiếm.formTimkiem.Xử_lý_dữ_liệu_tìm_kiếm;
using btl.Báo_cáo_dữ_liệu;

namespace btl.Chức_năng_tìm_kiếm.formTimkiem
{
    public partial class formtimkiemtheokhoi : Form
    {
        public formtimkiemtheokhoi()
        {
            InitializeComponent();
        }
        timkiemkhoi x = new timkiemkhoi();
        DataTable tbl = new DataTable();
        private void formtimkiemtheokhoi_Load(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = x.loadlieu();
            dataGridView1.DataSource = tbl;
            string[] cb_khoihoc = new string[4] { "6", "7", "8", "9" };
            foreach(string i in cb_khoihoc)
            {
                cb_khoi.Items.Add(i);
            }
            string[] mdanhhieu = new string[4] { "Giỏi", "Khá", "TB", "Yếu" };
            foreach (string i in mdanhhieu)
            {
                cb_danhhieu.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            int diemmax = int.Parse(max.Value.ToString());
            int diemmin = int.Parse(min.Value.ToString());
            tbl = x.Timkiem(tb_ten.Text, cb_khoi.Text,
                cb_danhhieu.Text,diemmax, 
                diemmin);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formrepost form = new formrepost();
            Thongkediemtkkhoi rpt = new Thongkediemtkkhoi();
            tbl = (DataTable)dataGridView1.DataSource;
            rpt.SetDataSource(tbl);
            form.crystalReportViewer1.ReportSource = rpt;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
