using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_BT1
{
    internal class SinhVien
    {
        private string MaSV;
        private string Ten;
        private int NamSinh;
        private double Diem;

        public SinhVien()
        {
            
        }
        public SinhVien(string maSV, string ten, int namSinh, double diem)
        {
            MaSV1 = maSV;
            Ten1 = ten;
            NamSinh1 = namSinh;
            Diem1 = diem;
        }

        public string MaSV1 { get => MaSV; set => MaSV = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public int NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public double Diem1 { get => Diem; set => Diem = value; }

        public virtual void inThongTin()
        {
            Console.WriteLine($"Mã sinh viên:{MaSV1}\n Tên : {Ten1}\n Năm sinh : {NamSinh1} \nDiem: {Diem1}\n");
        }
    }
}
