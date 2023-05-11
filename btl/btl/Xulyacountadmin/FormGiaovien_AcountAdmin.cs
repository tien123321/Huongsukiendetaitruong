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
using System.Data;
using btl.Xulyacountadmin.formxuly;

namespace btl.Xulyacountadmin
{
    public partial class FormGiaovien_AcountAdmin : Form
    {
        public FormGiaovien_AcountAdmin()
        {
            InitializeComponent();
        }
        Xulyad_Giaovien xl = new Xulyad_Giaovien();
        DataTable tbl = new DataTable();
        string ma = "";
       
        public void formload()
        {
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";

            tbl.Clear();
            tbl = xl.infor_Giaovien();
            dataGridView1.DataSource = tbl;
        }
        private void FormGiaovien_AcountAdmin_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ma = "";
            Themvaupdategiaovien form1 = new Themvaupdategiaovien(ma);
            form1.ShowDialog();
            tbl.Clear();
            tbl = xl.infor_Giaovien();
            dataGridView1.DataSource = tbl;
        }

      

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ma = dataGridView1.Rows[e.RowIndex].Cells["nMagiaovien"].Value.ToString();
            }
            catch { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ma != "")
            {
                Themvaupdategiaovien form1 = new Themvaupdategiaovien(ma);
                form1.ShowDialog();
                tbl.Clear();
                tbl = xl.infor_Giaovien();
                dataGridView1.DataSource = tbl;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã học sinh cần cập nhập", "Thông báo");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = xl.xoadulieu(ma);
            tbl.Clear();
            tbl = xl.infor_Giaovien();
            dataGridView1.DataSource = tbl;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ma = dataGridView1.Rows[e.RowIndex].Cells["nMagiaovien"].Value.ToString();
            }
            catch { }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
            Timgiavienadmin formtim = new Timgiavienadmin(tbl);
            formtim.ShowDialog();
            tbl = formtim.tbl;
            dataGridView1.DataSource = tbl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            tbl.Clear();
            tbl = xl.infor_Giaovien();
            dataGridView1.DataSource = tbl;
            tbl.Clear();
            tbl = xl.infor_Giaovien();
            dataGridView1.DataSource = tbl;
        }
    }
}
