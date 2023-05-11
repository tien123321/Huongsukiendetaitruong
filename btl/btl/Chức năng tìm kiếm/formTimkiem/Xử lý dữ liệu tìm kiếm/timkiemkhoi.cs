using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btl.Connectionstring;
using System.Data.SqlClient;
using System.Data;

namespace btl.Chức_năng_tìm_kiếm.formTimkiem.Xử_lý_dữ_liệu_tìm_kiếm
{
    class timkiemkhoi
    {
        public timkiemkhoi()
        {
        }
        connect connect = new connect();
        DataTable tbl = new DataTable();
        public DataTable loadlieu()
        {
            using (SqlConnection cnn = connect.Connect())
            {
                using(SqlCommand cmd=new SqlCommand("select * from vw_diemkhoifull",cnn))
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
            (string ten,string khoi,string danhhieu,int maxdiem,int mindiem)
        {
            string proc = "search_diemkhoi";
            using (SqlConnection cnn = connect.Connect())
            {
                using(SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.Parameters.AddWithValue("@khoihoc", khoi);
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
