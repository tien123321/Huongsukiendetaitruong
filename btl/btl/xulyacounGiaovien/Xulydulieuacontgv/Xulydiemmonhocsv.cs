using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btl.Connectionstring;
using System.Data.SqlClient;
using System.Data;
using btl.Xulydulieu.Xuthithongtintaikhoan;

namespace btl.xulyacounGiaovien.Xulydulieuacontgv
{
    class Xulydiemmonhocsv
    {
        public Xulydiemmonhocsv()
        {
        }

        public Xulydiemmonhocsv(
            string tensv, string tenmonhoc, float diemmieng,
            float diem15phut, float diem1tiet, float diemhocki, float diemthi,string ma)
        {
            this.tensv = tensv;
            this.mamon = ma;
            this.tenmonhoc = tenmonhoc;
            this.diemmieng = diemmieng;
            this.diem15phut = diem15phut;
            this.diem1tiet = diem1tiet;
            this.diemhocki = diemhocki;
            this.diemthi = diemthi;
        }

        public string tensv { get; set; }
        public string mamon { get; set; }
        public string tenmonhoc { get; set; }
        public float diemmieng { get; set; }
        public float diem15phut { get; set; }

        public float diem1tiet { get; set; }
        public float diemhocki { get; set; }
        public float diemthi { get; set; }




        DataTable tbl = new DataTable();
        connect connect = new connect();
        thongtintaikhoan x = new thongtintaikhoan();
        public DataTable loadttdiem()
        {
            x.loadthongtin(Properties.Settings.Default.tennguoisudung);
            string proc = "inforDiemmonhoc";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@Magv", x.maxx);

                    tbl.Load(cmd.ExecuteReader());


                    cnn.Close();

                }
            }
            return tbl;
        }
        public int timdulieu(string ma)
        {
            int n;
            x.loadthongtin(Properties.Settings.Default.tennguoisudung);
            string procUpdate = "search_Diemmonhoc";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procUpdate;
                    cmd.Parameters.AddWithValue("@Magv", x.maxx);
                    cmd.Parameters.AddWithValue("@masv", ma);

                    n = cmd.ExecuteNonQuery();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        // Tendangnhap = reader["Tentaikhoan"].ToString();
                        tensv = reader["nTensv"].ToString();
                        mamon = reader["nMamonhoc"].ToString();
                        tenmonhoc = reader["nTenmonhoc"].ToString();
                        diemmieng = float.Parse(reader["Diemmieng"].ToString());
                        diem15phut = float.Parse(reader["Diem15phut"].ToString());
                        diem1tiet = float.Parse(reader["Diem1tiet"].ToString());
                        diemhocki = float.Parse(reader["Diemhocki"].ToString());
                        diemthi = float.Parse(reader["Diemthi"].ToString());
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
        public int themhoacsua
          (string madiem,string mamonhoc, float Diemmieng, float diemthi,
            float Diem15phut, float diem1tiet, float diemhocki)
        {
            int n;
            string proc = "update_diem";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc;
                    cmd.Parameters.AddWithValue("@ma", madiem);
                    cmd.Parameters.AddWithValue("@Mamon", mamonhoc);
                    cmd.Parameters.AddWithValue("@DM", Diemmieng);
                    cmd.Parameters.AddWithValue("@D15p", Diem15phut);
                    cmd.Parameters.AddWithValue("@D1t", diem1tiet);
                    cmd.Parameters.AddWithValue("@DT", diemthi);
                    cmd.Parameters.AddWithValue("@Dhk", diemhocki);
                    n = cmd.ExecuteNonQuery();

                    cnn.Close();
                }
                if (n > 0)
                {
                    return 1;
                }
                else return 0;
            }


        }
        public DataTable timdiemsv(string ma,string ten)
        {
            x.loadthongtin(Properties.Settings.Default.tennguoisudung);
            string procUpdate = "timdiemacgiaovien";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = procUpdate;
                    cmd.Parameters.AddWithValue("@Magv", x.maxx);
                    cmd.Parameters.AddWithValue("@masv", ma);
                    cmd.Parameters.AddWithValue("@tensv", ten);
                    tbl.Load(cmd.ExecuteReader());
                    cnn.Close();
                }
                
            }
            return tbl;
        }
    }
}
