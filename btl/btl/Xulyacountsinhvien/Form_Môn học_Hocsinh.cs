using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl.Connectionstring;
using btl.Xulydulieu.Xuthithongtintaikhoan;
using System.Data;
using System.Data.SqlClient;

namespace btl.Xulyacountsinhvien
{
    public partial class Formchucnang_Môn_học : Form
    {
        public Formchucnang_Môn_học()
        {
            InitializeComponent();
        }
        connect connect = new connect();
        thongtintaikhoan tt = new thongtintaikhoan();
        DataTable tbl = new DataTable();
        public void formload()
        {
            tt.loadthongtin(Properties.Settings.Default.tennguoisudung);
            string proc = "inforDiemmonhocsv";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@Masv", tt.maxx);
                    tbl.Clear();
                    tbl.Load(cmd.ExecuteReader());
                    cnn.Close();
                }
                dataGridView1.DataSource = tbl;
            }
        }
        private void Formchucnang_Môn_học_Load(object sender, EventArgs e)
        {
            formload();
        }
    }
}
