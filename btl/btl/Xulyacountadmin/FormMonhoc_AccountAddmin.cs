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


namespace btl.Xulyacountadmin
{
    public partial class FormMonhoc_AccountAddmin : Form
    {
        public FormMonhoc_AccountAddmin()
        {
            InitializeComponent();
        }
        DataTable tbl=new DataTable();
        xulydl_Monhoc xl = new xulydl_Monhoc();
        public void loadform()
        {
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            tbl.Clear();
            tbl = xl.infor_monhoc("inforDiemtoan");
            dataGridView1.DataSource = tbl;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            tbl.Clear();
            tbl = xl.infor_monhoc("inforDiemtoan");
            dataGridView1.DataSource = tbl;
        }

        private void FormMonhoc_AccountAddmin_Load(object sender, EventArgs e)
        {
            loadform();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Bisque;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            tbl.Clear();
            tbl = xl.infor_monhoc("inforDiemly");
            dataGridView1.DataSource = tbl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Bisque;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button4.BackColor = Color.White;
            tbl.Clear();
            tbl = xl.infor_monhoc("inforDiemhoa");
            dataGridView1.DataSource = tbl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Bisque;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            tbl.Clear();
            tbl = xl.infor_monhoc("inforDiemsinh");
            dataGridView1.DataSource = tbl;
        }
    }
}
