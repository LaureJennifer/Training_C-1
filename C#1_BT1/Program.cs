namespace C_1_BT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Service service = new Service();
            int choice;
            do
            {
                Console.WriteLine("Quản lí sinh viên tham gia HappyBee, Mời chọn:");
                Console.WriteLine("==================================================");
                Console.WriteLine("1.Nhập danh sách đối tượng");
                Console.WriteLine("2.Xuất danh sách đối tượng");
                Console.WriteLine("3.Xuất danh sách sinh viên được tặng vé HappyBee");
                Console.WriteLine("4.Xóa sinh viên k dc tham gia HappyBee nếu k dc tặng");
                Console.WriteLine("5.Thoát");
                Console.WriteLine("6.Kế thừa");
                Console.WriteLine("==================================================");
                Console.Write("Mời chọn :");
                choice=Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        service.Nhap();
                        break;
                    case 2:
                        service.Xuat1();
                        break;
                    case 3:
                        service.Xuat2();
                        break;
                    case 4:
                        service.Xoa();
                        break;
                    case 5:
                        Console.WriteLine("Thoát!");
                        Environment.Exit(0);
                        break;
                    case 6:
                        service.KeThua();
                        break;
                    default:
                        break;

                }

            } while (choice !=5);
        }
    }
}