using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace btl.Báo_cáo_dữ_liệu.ListBaocao
{
    class listPhieuDiemmonhocgv
    {
        public listPhieuDiemmonhocgv()
        {
        }

        public listPhieuDiemmonhocgv(string nMasv, string nTensv,
            string nTenmonhoc, int diemmieng, int diem15phut, 
            int diem1tiet, int diemhocki,int diemthi)
        {
            this.nMasv = nMasv;
            this.nTensv = nTensv;
            this.nTenmonhoc = nTenmonhoc;
            Diemmieng = diemmieng;
            Diem15phut = diem15phut;
            Diem1tiet = diem1tiet;
            Diemhocki = diemhocki;

        }

        public string nMasv { get; set; }
        public string nTensv { get; set; }
        public string nTenmonhoc { get; set; }
        public int Diemmieng { get; set; }
        public int Diem15phut { get; set; }
        public int Diem1tiet { get; set; }
        public int Diemhocki { get; set; }
        public int Diemthi { get; set; }
    }
}
