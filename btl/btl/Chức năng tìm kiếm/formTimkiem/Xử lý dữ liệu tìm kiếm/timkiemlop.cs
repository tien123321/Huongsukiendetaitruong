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
    class timkiemlop
    {
        connect connect = new connect();

        public timkiemlop()
        {
        }
        DataTable tbl = new DataTable();
        public DataTable loaddulieu()
        {
            using(SqlConnection cnn = connect.Connect())
            {
                using(SqlCommand cmd=
                    new SqlCommand("Select * from vw_diemLopfull", cnn))
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
            (string ten, string lop, string danhhieu, int maxdiem, int mindiem)
        {
            string proc = "search_diemlop";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.Parameters.AddWithValue("@lop", lop);
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
