using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace btl.Xulydulieu.Xuthithongtintaikhoan
{
    class thongtintaikhoan
    {
       
        public string Tendangnhap { get; set; }
        public string Matkhau { get; set; }
        public int loaitaikhoan { get; set; }
        public DateTime ngaysinh { get; set; }
        public string maxx { get; set; }
        public thongtintaikhoan()
        {
        }

        public thongtintaikhoan(
            string tendangnhap,
            string matkhau,
            int loaitaikhoan,
            DateTime ngaysinh)
        {
           
            this.Tendangnhap = tendangnhap;
            this.Matkhau = matkhau;
            this.loaitaikhoan = loaitaikhoan;
            this.ngaysinh = ngaysinh;
        }
        Connectionstring.connect connect = new Connectionstring.connect();
        public void loadthongtin(string tennguoisd)
        {
            string thongtin= "Thongtintaikhoan";
            using (SqlConnection cnn = connect.Connect())
            {
                using(SqlCommand cmd=cnn.CreateCommand())
                {
                    
                    cnn.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = thongtin;
                    cmd.Parameters.AddWithValue("@Tennguoisudung", tennguoisd);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        loaitaikhoan = int.Parse(reader["loaitaikhoan"].ToString());
                        Tendangnhap = reader["Tentaikhoan"].ToString();
                        Matkhau = reader["matkhau"].ToString();
                        Console.WriteLine(Tendangnhap);
                        ngaysinh = DateTime.Parse(reader["dNgaysinh"].ToString());
                        maxx = reader["Maxx"].ToString();
                        
                        
                    }

                    reader.Close();
                    cnn.Close();
                }
            }
        }
        bool a = false;
        public bool suathongtin (string tendangnhap,
            string matkhau,
            string tennguoisd,
            DateTime ngaysinh)
        {
            string prupdate = "updatethongtin";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {

                    cnn.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.CommandText = prupdate;
                    cmd.Parameters.AddWithValue("@Tennguoisudung", tennguoisd);
                    cmd.Parameters.AddWithValue("@Tendangnhap", tendangnhap);
                    cmd.Parameters.AddWithValue("@matkhau", matkhau);
                    cmd.Parameters.AddWithValue("@ngaysinh", ngaysinh);
                    int n = cmd.ExecuteNonQuery();
                    if (n > 0)
                    {
                        a = true;
                    }
                    
                    cnn.Close();
                }
            }
            return a;
        }
    }

}
