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

namespace btl.Xulyacountadmin
{
    public partial class FormLop_acountAdmin : Form
    {
        public FormLop_acountAdmin()
        {
            InitializeComponent();
        }
        Xulylophocadmin xl = new Xulylophocadmin();
        DataTable tbl = new DataTable();
        public void loadform()
        {
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            tbl.Clear();
            tbl = xl.inforlop("6");
            dataGridView1.DataSource = tbl;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Bisque;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            tbl.Clear();
            tbl = xl.inforlop("6");
            dataGridView1.DataSource = tbl;

        }

        private void FormLop_acountAdmin_Load(object sender, EventArgs e)
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
            tbl = xl.inforlop("7");
            dataGridView1.DataSource = tbl;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Bisque;
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button4.BackColor = Color.White;
            tbl.Clear();
            tbl = xl.inforlop("8");
            dataGridView1.DataSource = tbl;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Bisque;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            button2.BackColor = Color.White;
            tbl.Clear();
            tbl = xl.inforlop("9");
            dataGridView1.DataSource = tbl;
        }
    }
}
