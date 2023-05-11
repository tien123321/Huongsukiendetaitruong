using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btl.Connectionstring;
using System.Data;
using System.Data.SqlClient;


namespace btl.Xulyacountadmin.XulydulieuData
{
    class Xulylophocadmin
    {
        public Xulylophocadmin()
        {
        }
        connect connect = new connect();
        DataTable tbl = new DataTable();
        public DataTable inforlop(string khoihoc)
        {
            string proc = "infor_class";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@khoihoc", khoihoc);

                    tbl.Load(cmd.ExecuteReader());


                    cnn.Close();
                }
            }
            return tbl;
        }
    }
}
