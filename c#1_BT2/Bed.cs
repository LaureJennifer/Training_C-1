using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1_BT2
{
    internal class Bed:stuff
    {
        public Bed()
        {

        }
        public Bed(int dai, int rong, int sau)
        {
            this.Dai = dai;
            this.Rong = rong;
            this.Sau = sau;
        }
        public override void InraThongTin()
        {
            Console.WriteLine($"V_Bed: {Thetich} ");
        }
    }
}
