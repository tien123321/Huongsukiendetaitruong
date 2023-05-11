using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace btl.Chức_năng_tìm_kiếm.formTimkiem
{
    public partial class formloadtimkiem : Form
    {
        public formloadtimkiem()
        {
            InitializeComponent();
        }



      
        private void button2_Click_1(object sender, EventArgs e)
        {
            formtimkiemtheokhoi form = new formtimkiemtheokhoi();
            this.Hide();
            form.ShowDialog();
            this.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

            formtimkiemtheolop form = new formtimkiemtheolop();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timkiemtheomon form = new timkiemtheomon();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
        public void formloadf()
        {
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }
        private void formloadtimkiem_Load(object sender, EventArgs e)
        {
            formloadf();
        }
    }
}
