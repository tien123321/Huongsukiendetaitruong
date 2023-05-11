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
    public partial class FormDiemtk_AcountAdmin : Form
    {
        public FormDiemtk_AcountAdmin()
        {
            InitializeComponent();
        }
        DataTable tbl = new DataTable();
        xulydl_Monhoc x = new xulydl_Monhoc();
        public void formload()
        {
            tbl.Clear();
            tbl = x.infor_monhoc("inforDTK_danhhieu");
            dataGridView1.DataSource = tbl;
        }
        private void FormDiemtk_AcountAdmin_Load(object sender, EventArgs e)
        {
            formload();
        }

        private void dataGridView1_CellContentClick
            (object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
