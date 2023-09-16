using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1_BT2
{
    internal class Deliver
    {
        public string name;
        public Deliver() { }
        ArrayList guests = new ArrayList();
        public void Addguest()
        {
            Guest guest = new Guest();
            Console.WriteLine("Mời nhập thông tin khách hàng muốn thêm:");
            Console.WriteLine("Nhập thông tin khách hàng :");
            Console.WriteLine("Tên: ");
            guest._name = Console.ReadLine();
            Console.WriteLine("Tuổi: ");
            guest._age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Địa chỉ: ");
            guest.Address = Console.ReadLine();
            Console.WriteLine("Số điện thoại: ");
            guest.Phone = Console.ReadLine();
            guests.Add(guest);
        }
        public void Deleteguest()
        {
            Guest guest = new Guest();
            Console.WriteLine("Mời nhập thông tin khách hàng muốn bớt:");
            Console.WriteLine("Nhập thông tin khách hàng :");
            Console.WriteLine("Tên: ");
            guest._name = Console.ReadLine();
            Console.WriteLine("Tuổi: ");
            guest._age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Địa chỉ: ");
            guest.Address = Console.ReadLine();
            Console.WriteLine("Số điện thoại: ");
            guest.Phone = Console.ReadLine();
            guests.Remove(guest);
        }

    }
}
