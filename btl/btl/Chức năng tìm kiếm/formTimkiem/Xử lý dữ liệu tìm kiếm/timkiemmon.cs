using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using btl.Connectionstring;

namespace btl.Chức_năng_tìm_kiếm.formTimkiem.Xử_lý_dữ_liệu_tìm_kiếm
{
    class timkiemmon
    {
        public timkiemmon()
        {
        }
        DataTable tbl = new DataTable();
        connect connect = new connect();
        public DataTable loaddulieu()
        {
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd =
                    new SqlCommand("Select * from vw_diemMonfull", cnn))
                {
                    cnn.Open();
                    tbl.Clear();
                    tbl.Load(cmd.ExecuteReader());
                    cnn.Close();
                }
            }
            return tbl;
        }
        public DataTable Timkiem
            (string ten, string mon, string danhhieu, int maxdiem, int mindiem)
        {
            string proc = "search_diemmon";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.Parameters.AddWithValue("@mon", mon);
                    cmd.Parameters.AddWithValue("@danhhieu", danhhieu);
                    cmd.Parameters.AddWithValue("@diemtbmax", maxdiem);
                    cmd.Parameters.AddWithValue("@diemtbmin", mindiem);
                    tbl.Clear();
                    tbl.Load(cmd.ExecuteReader());
                    cnn.Close();
                }
            }

            return tbl;
        }
    }
}
