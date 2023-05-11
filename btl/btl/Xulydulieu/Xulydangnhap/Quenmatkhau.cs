using btl.Connectionstring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace btl.Xulydulieu.Xulydangnhap
{
    class Quenmatkhau
    {
        Connectionstring.connect connect = new Connectionstring.connect();

        public Quenmatkhau()
        {
        }

        public Quenmatkhau(connect connect)
        {
            this.connect = connect;
        }
        public bool kiemtramk(string mk)
        {
            return Regex.IsMatch(mk, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool Doimatkhau(String matkhaumoi,string tennguoisudung,string tendangnhap)
        {
            int n;
            string prdoimatkhau = "Quenmatkhau";
            using (SqlConnection connection = connect.Connect())
            {
                using(SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = prdoimatkhau;
                    command.Parameters.AddWithValue("@Matkhaumoi", matkhaumoi);
                    command.Parameters.AddWithValue("@Tenuser", tennguoisudung);
                    command.Parameters.AddWithValue("@tentaikhoan", tendangnhap);
                     n = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            if (n != 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
