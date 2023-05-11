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

namespace btl.xulyacounGiaovien.formxuly
{
    public partial class formtimdiemmonhocgv : Form
    {
        public DataTable tbl;
        public formtimdiemmonhocgv(DataTable tbl)
        {
            InitializeComponent();
            this.tbl = tbl;
        }
        Xulydulieuacontgv.Xulydiemmonhocsv xl =
            new Xulydulieuacontgv.Xulydiemmonhocsv();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbl = xl.timdiemsv(tb_ma.Text,tb_ten.Text);
            this.Dispose();
        }
    }
}
