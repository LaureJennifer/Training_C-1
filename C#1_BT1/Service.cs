using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_1_BT1
{
    internal class Service
    {
        List <SinhVien> list=new List <SinhVien> ();

        internal void Nhap()
        {
            Console.WriteLine("1.Nhập danh sách đối tượng :");
            string NhapTiep;
            do
            {
                SinhVien sv = new SinhVien();

                Console.Write("Nhập mã sinh viên:");
                sv.MaSV1 = Console.ReadLine();

                Console.Write("Nhập tên sinh viên :");
                sv.Ten1 = Console.ReadLine();

                Console.Write("Nhập năm sinh:");
                sv.NamSinh1= Convert.ToInt32(Console.ReadLine());

                Console.Write("Nhập điểm sinh viên:");
                sv.Diem1 = Convert.ToInt32(Console.ReadLine());

                list.Add (sv);

                Console.Write("Nhập tiếp hay không ? (c/k) :");
                NhapTiep = Console.ReadLine();
            }
            while (NhapTiep.ToLower() == "c");
        }

        internal void Xoa()
        {
            for (int i=0; i<list.Count; i++)
            {
                if ((list[i].Diem1 < 8) && (2023- list[i].NamSinh1) >25)
                {
                    list.RemoveAt(i);
                }
            }
        }

        internal void Xuat1()
        {
            Console.WriteLine("2.Xuất danh sách đối tượng :");
            foreach (SinhVien sv in list)
            {
                sv.inThongTin();
            }
        }

        internal void Xuat2()
        {
            Console.WriteLine("2.Xuất danh sách sinh viên được tặng vé HappyBee :");
            foreach (SinhVien sv in list)
            {
                if (sv.Diem1 >= 8)
                {
                    sv.inThongTin();
                } 
            }
        }
        internal void KeThua()
        {
            SinhVienUD svUD = new SinhVienUD();

            Console.Write("Nhập mã sinh viên:");
            svUD.MaSV1 = Console.ReadLine();

            Console.Write("Nhập tên sinh viên :");
            svUD.Ten1 = Console.ReadLine();

            Console.Write("Nhập năm sinh:");
            svUD.NamSinh1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập điểm sinh viên:");
            svUD.Diem1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nhập kì học của sinh viên:");
            svUD.Kihoc1 = Convert.ToInt32(Console.ReadLine());

            svUD.inThongTin();

        }
    }
}
