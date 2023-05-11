using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using btl.Connectionstring;
namespace btl.Xulyacountadmin.XulydulieuData
{
    class Xulyad_Giaovien
    {
        public Xulyad_Giaovien()
        {
        }

        public Xulyad_Giaovien
            (string magv, string tengv, DateTime ngaysinh, string gioitinh, string lophoc)
        {
            this.Magv = magv;
            this.Tengv = tengv;
            this.Ngaysinh = ngaysinh;
            this.gioitinh = gioitinh;
            this.lophoc = lophoc;
        }

        public string Magv {get;set;}
        public string Tengv { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string gioitinh { get; set; }
        public string lophoc { get; set; }


        DataTable tbl = new DataTable();
        connect connect = new connect();
        public DataTable infor_Giaovien()
        {
            string proc_Inforgiaovien= "infor_Giaovien";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc_Inforgiaovien;

                    tbl.Load(cmd.ExecuteReader());


                    cnn.Close();
                }
            }
            return tbl;
        }
        public string addorupdategiaovien
            (string ma, string ten,
            DateTime Ngaysinh, string gioitinh, string proc)
        {
            try
            {
                int n;
                using (SqlConnection cnn = connect.Connect())
                {
                    using (SqlCommand cmd = cnn.CreateCommand())
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = proc;
                        cmd.Parameters.AddWithValue("@ma", ma);
                        cmd.Parameters.AddWithValue("@Ten", ten);
                        cmd.Parameters.AddWithValue("@Ngaysinh", Ngaysinh);
                        cmd.Parameters.AddWithValue("@gioitinh", gioitinh);

                        n = cmd.ExecuteNonQuery();

                        cnn.Close();
                    }

                }
                return "Đã thêm Giáo viên mới";
            }
            catch
            {
                return "Kiểm tra lại khóa chính";
            }
        }
        public void timdulieu(string ma)
        {
            int n;
            string procUpdate = "search_Giaovien";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procUpdate;
                    cmd.Parameters.AddWithValue("@ma", ma);

                    n = cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Magv = ma;
                        // Tendangnhap = reader["Tentaikhoan"].ToString();
                        Tengv = reader["nTengiaovien"].ToString();

                        Ngaysinh = DateTime.Parse(reader["dNgaysinh"].ToString());
                        gioitinh = reader["nGioitinh"].ToString();
                     
                        
                    }
                    reader.Close();
                    cnn.Close();
                }
              
            }
        }
        public int xoadulieu(string ma)
        {
            int n;
            string procdelete = "delete_giaovien";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procdelete;
                    cmd.Parameters.AddWithValue("@ma", ma);

                    n = cmd.ExecuteNonQuery();

                    cnn.Close();
                }

            }
            if (n > 0)
            {
                return 1;
            }
            else return 0;
        }
        public DataTable timkiemgv(string ma, string ten,
            string ngay,string thang,string nam, string gioitinh)
        {
            string proc = "timkiemgv";
            using(SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@Magv", ma);
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.Parameters.AddWithValue("@Ngay", ngay);
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);
                    cmd.Parameters.AddWithValue("@GT", gioitinh);
                    
                    tbl.Load(cmd.ExecuteReader());
                }
            }
            return tbl;
        }
    }


}
    

   

