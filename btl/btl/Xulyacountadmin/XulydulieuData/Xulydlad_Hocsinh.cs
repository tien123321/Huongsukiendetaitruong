using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using btl.Connectionstring;
using System.Data;

namespace btl.Xulyacountadmin.XulydulieuData
{
    class Xulydlad_Hocsinh
    {
        private string Mahs { get; set; }
        public string Tenhs { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Gioiting { get; set; }
        public string diachi { get; set; }
        public string lophoc { get; set; }
        connect connect = new connect();
        public Xulydlad_Hocsinh()
        {
        }

        public Xulydlad_Hocsinh
            (string mahs, string tenhs, DateTime ngaysinh,
            string gioiting, string diachi, string lophoc, connect connect, DataTable tb)
        {
            this.Mahs = mahs;
            this.Tenhs = tenhs;
            this.Ngaysinh = ngaysinh;
            this.Gioiting = gioiting;
            this.diachi = diachi;
            this.lophoc = lophoc;
            this.connect = connect;
            this.tb = tb;
        }

        DataTable tb=new DataTable();
        public DataTable hienthidulieu()
        {
      
            string proc_Thongtin = "thongtinsv";
            using(SqlConnection cnn = connect.Connect())
            {
               using(SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc_Thongtin;
                    
                        tb.Load(cmd.ExecuteReader());
                        
                    
                    cnn.Close();
                }
            }
            return tb;
        }
        public string themhoacsua
            (string ma,string ten,DateTime Ngaysinh,
            string gioitinh,string diachi,string lop,
            string proc)
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
                        cmd.Parameters.AddWithValue("@Gioitinh", gioitinh);
                        cmd.Parameters.AddWithValue("@diachi", diachi);
                        cmd.Parameters.AddWithValue("@lop", lop);
                        n = cmd.ExecuteNonQuery();

                        cnn.Close();
                    }

                    if (n > 0)
                    {
                        return "Thêm thành công";
                    }
                    else return "Kiểm tra lại ràng buộc";
                }
            }
            catch
            {
                return "Kiểm tra lại ràng buộc khóa chính";
            }
            
        }
        public int timdulieu(string ma)
        {
            int n;
            string procUpdate = "pr_seachsinhvien";
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
                        // Tendangnhap = reader["Tentaikhoan"].ToString();
                        Tenhs = reader["nTensv"].ToString();
                        
                        Ngaysinh = DateTime.Parse(reader["dNgaysinh"].ToString());
                        Gioiting = reader["nGioitinh"].ToString();
                        diachi = reader["nDiachi"].ToString();
                        lophoc = reader["nMalop"].ToString();
                    }
                    reader.Close();
                    cnn.Close();
                }
                if (n > 0)
                {
                    return 1;
                }
                else return 0;
            }
        }
        public int xoadulieu(string ma)
        {
            int n;
            string procdelete = "deletehocsinh";
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
        public DataTable timkiemhs(string ma, string ten,
           string ngay, string thang, string nam,
           string gioitinh,string Diachi,string lop)
        {
            string proc = "timkiemhs";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@Ma", ma);
                    cmd.Parameters.AddWithValue("@Ten", ten);
                    cmd.Parameters.AddWithValue("@Ngay", ngay);
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@nam", nam);
                    cmd.Parameters.AddWithValue("@GT", gioitinh);
                    cmd.Parameters.AddWithValue("@diachi", Diachi);
                    cmd.Parameters.AddWithValue("@Tenlop", lop);

                    tb.Load(cmd.ExecuteReader());
                }
            }
            return tb;
        }
    }
}
