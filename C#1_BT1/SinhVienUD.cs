using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_BT1
{
    internal class SinhVienUD:SinhVien
    {
        private int Kihoc;

        public SinhVienUD()
        {
            
        }
        public SinhVienUD(string maSV, string ten, int namSinh, double diem, int kihoc):base (maSV,ten,namSinh,diem)
        {
            Kihoc = kihoc;
        }

        public int Kihoc1 { get => Kihoc; set => Kihoc = value; }

        public override void inThongTin()
        {
            Console.WriteLine($"Mã sinh viên:{MaSV1}\n Tên : {Ten1}\n Năm sinh : {NamSinh1} \nDiem: {Diem1}\n Kì học :{Kihoc1}\n");
        }
    }
}
