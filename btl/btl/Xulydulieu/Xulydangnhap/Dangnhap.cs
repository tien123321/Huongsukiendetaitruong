using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using btl.Connectionstring;

namespace btl.Xulydulieu.Xulydangnhap
{
    class Dangnhap
    {
        
        private int loaitaikhoan;
        private string tennguoisd;
        Connectionstring.connect connect = new Connectionstring.connect();
       

        public Dangnhap()
        {
        }

        public Dangnhap(int loaitaikhoan, string tennguoisd, connect connect)
        {
            this.loaitaikhoan = loaitaikhoan;
            this.tennguoisd = tennguoisd;
            this.connect = connect;
        }
        public int Loaitaikhoan
        {
            set { loaitaikhoan = value; }
            get
            {
                return loaitaikhoan;
            }
        }
        public string Tennguoisd
        {
            set { tennguoisd = value; }
            get
            {
                return tennguoisd;
            }
        }
       

        public bool kiemtraDangnhap(string Tendangnhap, string matkhau)
        {

            string kiemtrataikhoan = "Dangnhaptk";

            using (SqlConnection connection = connect.Connect())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = kiemtrataikhoan;
                    command.Parameters.AddWithValue("@Tendn", Tendangnhap);
                    command.Parameters.AddWithValue("@Matkhau", matkhau);
                    SqlDataReader dr;

                    dr = command.ExecuteReader();
                    while (dr.Read())
                    {
                        loaitaikhoan = int.Parse(dr["loaitaikhoan"].ToString());
                        Properties.Settings.Default.loaitaikhoan = loaitaikhoan;
                        Properties.Settings.Default.Save();
                        tennguoisd = dr["Tennguoisd"].ToString();
                    }
                    if (dr.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    connection.Close();
                }
            }
        }
    }
}
