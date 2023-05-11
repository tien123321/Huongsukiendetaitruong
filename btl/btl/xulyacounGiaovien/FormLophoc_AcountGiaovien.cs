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
using System.Data;

namespace btl.xulyacounGiaovien
{
    public partial class FormLophoc_AcountGiaovien : Form
    {
        public FormLophoc_AcountGiaovien()
        {
            InitializeComponent();
        }
        xulylophocacgiaovien xl = new xulylophocacgiaovien();
        DataTable tbl = new DataTable();
        public void formload()
        {
            tbl.Clear();
            tbl = xl.inforlopday();
            dataGridView1.DataSource = tbl;
        }
        private void FormLophoc_AcountGiaovien_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void label3_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
