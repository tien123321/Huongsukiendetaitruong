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
    class xulydl_Monhoc
    {
        public xulydl_Monhoc()
        {
        }
        connect connect = new connect();
        DataTable tbl=new DataTable();
        
        public xulydl_Monhoc(
            string tenhs, string tenmh, float diemmieng,
            float diem15phut, float diem1tiet, float diemhocki, float diemthi)
        {
            this.tenhs = tenhs;
            this.tenmh = tenmh;
            Diemmieng = diemmieng;
            Diem15phut = diem15phut;
            Diem1tiet = diem1tiet;
            Diemhocki = diemhocki;
            Diemthi = diemthi;
        }

        string tenhs { get; set; }
        string tenmh { get; set; }
        float Diemmieng { get; set; }
        float Diem15phut { get; set; }
        float Diem1tiet { get; set; }
        float Diemhocki { get; set; }
        float Diemthi { get; set; }

        public DataTable infor_monhoc(string proc)
        {
            
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;

                    tbl.Load(cmd.ExecuteReader());


                    cnn.Close();
                }
            }
            return tbl;
        }
    }
}
