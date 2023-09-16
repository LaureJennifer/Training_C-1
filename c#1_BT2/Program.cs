namespace c_1_BT2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer(8,6,7);
            computer.InraThongTin();

            Chair chair = new Chair(5,4,3);
            chair.InraThongTin();

            Table table = new Table(2,5,7);
            table.InraThongTin();

            Bed bed = new Bed(3,2,2);
            bed.InraThongTin();

           
            do
            {
                Deliver guest = new Deliver();
                Console.WriteLine("Menu:");
                Console.WriteLine("")


            } while (true);
        }
    }
}