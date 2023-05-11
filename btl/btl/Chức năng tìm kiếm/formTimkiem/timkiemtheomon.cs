using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl.Chức_năng_tìm_kiếm.formTimkiem.Xử_lý_dữ_liệu_tìm_kiếm;
using btl.Báo_cáo_dữ_liệu;

namespace btl.Chức_năng_tìm_kiếm.formTimkiem
{
    public partial class timkiemtheomon : Form
    {
        public timkiemtheomon()
        {
            InitializeComponent();
        }
        timkiemmon x = new timkiemmon();
        DataTable tbl = new DataTable();
        private void timkiemtheomon_Load(object sender, EventArgs e)
        {
            string[] mdanhhieu = new string[4] { "Giỏi", "Khá", "TB", "Yếu" };
            foreach (string i in mdanhhieu)
            {
                cb_danhhieu.Items.Add(i);
            }
            string[] cb_khoihoc = new string[16] {"Toán 6","Toán 7","Toán 8","Toán 9",
                                                  "Lý 6","Lý 7","Lý 8","Lý 9",
                                                  "Hóa 6","Hóa 7","Hóa 8","Hóa 9",
                                                  "Sinh 6","Sinh 7","Sinh 8","Sinh 9"};
            foreach (string i in cb_khoihoc)
            {
                cb_khoi.Items.Add(i);
            }
            tbl.Clear();
            tbl = x.loaddulieu();
            dataGridView1.DataSource = tbl;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            int diemmax = int.Parse(max.Value.ToString());
            int diemmin = int.Parse(min.Value.ToString());
            tbl = x.Timkiem(tb_ten.Text, cb_khoi.Text,
                cb_danhhieu.Text, diemmax,
                diemmin);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formrepost form = new formrepost();
            ThongkeTKdiemmon rpt = new ThongkeTKdiemmon();
            tbl = (DataTable)dataGridView1.DataSource;
            rpt.SetDataSource(tbl);
            form.crystalReportViewer1.ReportSource = rpt;
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
