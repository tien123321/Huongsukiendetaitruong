using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using btl.Connectionstring;
using System.Data.SqlClient;
using System.Data;
using btl.Xulyacountadmin.XulydulieuData;
using btl.Xulydulieu.Xuthithongtintaikhoan;

namespace btl.xulyacounGiaovien.Xulydulieuacontgv
{
    class xulyhocsinh_giaovien
    {
        private string Mahs { get; set; }
        public string Tenhs { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Gioiting { get; set; }
        public string diachi { get; set; }
        public string lophoc { get; set; }
        connect connect = new connect();
        thongtintaikhoan x = new thongtintaikhoan();
        

        public xulyhocsinh_giaovien(
            string mahs, string tenhs, DateTime ngaysinh,
            string gioiting, string diachi, string lophoc, connect connect)
        {
            this.Mahs = mahs;
            this.Tenhs = tenhs;
            this.Ngaysinh = ngaysinh;
            this.Gioiting = gioiting;
            this.diachi = diachi;
            this.lophoc = lophoc;
            this.connect = connect;
        }

        public xulyhocsinh_giaovien()
        {
        }

        DataTable tb = new DataTable();
       
        public DataTable hienthidulieu()
        {
            x.loadthongtin(Properties.Settings.Default.tennguoisudung);
            string proc_Thongtin = "inforgv_sinhvien";
            using (SqlConnection cnn = connect.Connect())
            {
                using (SqlCommand cmd = cnn.CreateCommand())
                {
                    cnn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = proc_Thongtin;
                    cmd.Parameters.AddWithValue("@Magv", x.maxx);

                    tb.Load(cmd.ExecuteReader());


                    cnn.Close();
                }
            }
            return tb;
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
        public int themhoacsua
           (string ma, string ten, DateTime Ngaysinh, string gioitinh, string diachi, string lop,
           string proc)
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
                    return 1;
                }
                else return 0;
            }
        }
        public DataTable timkiemhs(string ma, string ten,
          string ngay, string thang, string nam,
          string gioitinh, string diachi)
        {
            x.loadthongtin(Properties.Settings.Default.tennguoisudung);
            string proc = "timkiemhsacountgv";
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
                    cmd.Parameters.AddWithValue("@diachi", diachi);
                   
                    cmd.Parameters.AddWithValue("@magv", x.maxx);
                    tb.Load(cmd.ExecuteReader());
                }
            }
            return tb;
        }
    }
}
