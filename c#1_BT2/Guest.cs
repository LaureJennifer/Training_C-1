using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1_BT2
{
    internal class Guest
    {
        public string _name;
        public int _age;
        private string _phone;
        private string _address;

        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }

        ArrayList stuff= new ArrayList();
        public void Addstuff()
        {
            int choice;
            Console.WriteLine("Chọn đồ muốn thêm:");
            Console.WriteLine("1.Computer");
            Console.WriteLine("2.Chair");
            Console.WriteLine("3.Table");
            Console.WriteLine("4.Bed");
            Console.WriteLine("5.Wardrobe");
            Console.WriteLine("6.Thoát");
            Console.WriteLine("Chọn : ");
            choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Computer computer = new Computer();
                    Console.WriteLine("Kích thước là:");
                    computer.Dai=Convert.ToInt32(Console.ReadLine());
                    computer.Rong = Convert.ToInt32(Console.ReadLine());
                    computer.Sau = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Đã thêm 1 Computer");
                    stuff.Add(computer);
                    break;
                case 2:
                    Chair chair = new Chair();
                    Console.WriteLine("Kích thước là:");
                    chair.Dai = Convert.ToInt32(Console.ReadLine());
                    chair.Rong = Convert.ToInt32(Console.ReadLine());
                    chair.Sau = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Đã thêm 1 Chair");
                    stuff.Add(chair);
                    break;
                case 3:
                    Table table = new Table();
                    Console.WriteLine("Kích thước là:");
                    table.Dai = Convert.ToInt32(Console.ReadLine());
                    table.Rong = Convert.ToInt32(Console.ReadLine());
                    table.Sau = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Đã thêm 1 Table");
                    stuff.Add(table);
                    break;
                case 4:
                    Bed bed = new Bed();
                    Console.WriteLine("Kích thước là:");
                    bed.Dai = Convert.ToInt32(Console.ReadLine());
                    bed.Rong = Convert.ToInt32(Console.ReadLine());
                    bed.Sau = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Đã thêm 1 Bed");
                    stuff.Add(bed);
                    break;
                case 5:
                    Wardrobe wardrobe = new Wardrobe();
                    Console.WriteLine("Kích thước là:");
                    wardrobe.Dai = Convert.ToInt32(Console.ReadLine());
                    wardrobe.Rong = Convert.ToInt32(Console.ReadLine());
                    wardrobe.Sau = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Đã thêm 1 wardrobe");
                    stuff.Add(wardrobe);
                    break;
                case 6:
                    Console.WriteLine("Thoát");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Không có lựa chọn này, mời chọn cái khác");
                    break;
            }
        }
        public void Removestuff()
        {
            int choice;
            Console.WriteLine("Chọn đồ muốn xóa:");
            Console.WriteLine("1.Computer");
            Console.WriteLine("2.Chair");
            Console.WriteLine("3.Table");
            Console.WriteLine("4.Bed");
            Console.WriteLine("5.Wardrobe");
            Console.WriteLine("6.Thoát");
            Console.WriteLine("Chọn : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Computer computer = new Computer();
                    Console.WriteLine("Kích thước là:");
                    computer.Dai = Convert.ToInt32(Console.ReadLine());
                    computer.Rong = Convert.ToInt32(Console.ReadLine());
                    computer.Sau = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Đã thêm 1 Computer");
                    stuff.Remove(computer);
                    break;
                case 2:
                    Chair chair = new Chair();
                    Console.WriteLine("Kích thước là:");
                    chair.Dai = Convert.ToInt32(Console.ReadLine());
                    chair.Rong = Convert.ToInt32(Console.ReadLine());
                    chair.Sau = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Đã thêm 1 Chair");
                    stuff.Remove(chair);
                    break;
                case 3:
                    Table table = new Table();
                    Console.WriteLine("Kích thước là:");
                    table.Dai = Convert.ToInt32(Console.ReadLine());
                    table.Rong = Convert.ToInt32(Console.ReadLine());
                    table.Sau = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Đã thêm 1 Table");
                    stuff.Remove(table);
                    break;
                case 4:
                    Bed bed = new Bed();
                    Console.WriteLine("Kích thước là:");
                    bed.Dai = Convert.ToInt32(Console.ReadLine());
                    bed.Rong = Convert.ToInt32(Console.ReadLine());
                    bed.Sau = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Đã thêm 1 Bed");
                    stuff.Remove(bed);
                    break;
                case 5:
                    Wardrobe wardrobe = new Wardrobe();
                    Console.WriteLine("Kích thước là:");
                    wardrobe.Dai = Convert.ToInt32(Console.ReadLine());
                    wardrobe.Rong = Convert.ToInt32(Console.ReadLine());
                    wardrobe.Sau = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Đã thêm 1 wardrobe");
                    stuff.Remove(wardrobe);
                    break;
                case 6:
                    Console.WriteLine("Thoát");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Không có lựa chọn này, mời chọn cái khác");
                    break;
            }

        }
        public void Inra_ThongTinKH()
        {
            Console.WriteLine($"Tên : {_name}\nTuổi : {_age}\nĐịa chỉ : {Address}\n Số điện thoại : {Phone}");
            Console.WriteLine("Đồ đạc gồm:");
            for (int i=0; i<stuff.Count; i++)
            {
                Console.WriteLine(stuff[i]);
            }   
        }
    }
}
