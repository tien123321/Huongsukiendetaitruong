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
using btl.Xulyacountadmin.FormThemdulieu;
using btl.Xulyacountadmin.formxuly;


namespace btl.Xulyacountadmin
{
    public partial class formHocsinh_AccountAdmin : Form
    {
        public formHocsinh_AccountAdmin()
        {
            InitializeComponent();
        }
        string ma = "";
        
        Xulydlad_Hocsinh xl = new Xulydlad_Hocsinh();
        DataTable tbl= new DataTable();
       


        public void loadform()
        {
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy";
            tbl.Clear();
            tbl = xl.hienthidulieu();
            dataGridView1.DataSource = tbl;
        }
        private void formHocsinh_AccountAdmin_Load(object sender, EventArgs e)
        {
            loadform();
        }
        
       
        private void button1_Click(object sender, EventArgs e)
        {
            ma = "";
            Themhs form1 = new Themhs(ma);
            form1.ShowDialog();
            tbl.Clear();
            tbl = xl.hienthidulieu();
            dataGridView1.DataSource = tbl;
            
               
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (ma != "")
            {
                Themhs form1 = new Themhs(ma);
                form1.ShowDialog();
                tbl.Clear();
                tbl = xl.hienthidulieu();
                dataGridView1.DataSource = tbl;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn mã học sinh cần cập nhập", "Thông báo");
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

        private void button3_Click(object sender, EventArgs e)
        {
            int n = xl.xoadulieu(ma);
            tbl.Clear();
            tbl = xl.hienthidulieu();
            dataGridView1.DataSource = tbl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tbl.Clear();
            tbl = xl.hienthidulieu();
            dataGridView1.DataSource = tbl;
            tbl.Clear();
            tbl = xl.hienthidulieu();
            dataGridView1.DataSource = tbl;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formtimkiemhs tkhs = new formtimkiemhs(tbl);
            tkhs.ShowDialog();
            tbl = tkhs.tbl;
            dataGridView1.DataSource = tbl;
        }
    }
}
