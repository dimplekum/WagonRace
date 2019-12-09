using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WagonRace
{
    abstract class DataStorage
    {
        public static Wagon[] wagon = new Wagon[4];
        public static Competator[] bettor = new Competator[3];
        public static Random rand = new Random();
        public static int currentGambler { get; set; }
    }
}
