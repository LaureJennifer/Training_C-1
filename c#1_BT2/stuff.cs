using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_1_BT2
{
    abstract internal class stuff
    {
        private int dai;
        private int rong;
        private int sau;

        public stuff()
        {
            
        }
        public stuff(int dai, int rong, int sau)
        {
            this.dai = dai;
            this.rong = rong;
            this.sau = sau;
        }

        private int tinhTheTich(int d, int r, int s)
        {
            return d * r * s;
        }

        public int Dai { get => dai; set => dai = value; }
        public int Rong { get => rong; set => rong = value; }
        public int Sau { get => sau; set => sau = value; }
        public int Thetich { get => tinhTheTich(Dai,Rong,Sau);set => Thetich=tinhTheTich(Dai,Rong,Sau); }

        abstract public void InraThongTin();
        
            
        
    }
}
