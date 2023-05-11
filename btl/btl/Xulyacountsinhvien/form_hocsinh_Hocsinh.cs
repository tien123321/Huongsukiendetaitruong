using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using btl.Xulydulieu.Xuthithongtintaikhoan;
using btl.Connectionstring;
using System.Data.SqlClient;

namespace btl.Xulyacountsinhvien
{
    public partial class form_hocsinh_Hocsinh : Form
    {
        public form_hocsinh_Hocsinh()
        {
            InitializeComponent();
        }
        thongtintaikhoan tt = new thongtintaikhoan();
        connect cnn = new connect();
        public void formload()
        {
            string proc = "inforsv_sv";
            tt.loadthongtin(Properties.Settings.Default.tennguoisudung);
            using (SqlConnection cn = cnn.Connect())
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@ma", tt.maxx);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        tb_ma.Text = reader["nMasv"].ToString();
                        tb_Ten.Text = reader["nTensv"].ToString();
                        dtpk_Ngaysinh.Value = DateTime.Parse(reader["dNgaysinh"].ToString());
                        string ktr;
                        tb_gt.Text = reader["nGioitinh"].ToString();

                        tblop.Text = reader["nTenlophoc"].ToString();
                    }
                    reader.Close();
                    cn.Close();
                }
            }
        }
        private void Xulychucnang_hocsinh_Load(object sender, EventArgs e)
        {
            formload();
        }
    }
}
