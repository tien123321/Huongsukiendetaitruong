using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using btl.Connectionstring;
using btl.Xulydulieu.Xuthithongtintaikhoan;

namespace btl.xulyacounGiaovien.Xulydulieuacontgv
{
    class Xulydulieudiem
    {
        connect connect = new connect();
        thongtintaikhoan tt = new thongtintaikhoan();
        DataTable tbl = new DataTable();

        public DataTable loaddulieu()
        {
            tt.loadthongtin(Properties.Settings.Default.tennguoisudung);
            string proc = "inforDTK_danhhieutkgv";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@Magv", tt.maxx);

                    tbl.Load(cmd.ExecuteReader());


                    cnn.Close();

                }
            }
            return tbl;
        
        }
    }
}
