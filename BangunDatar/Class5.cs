using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Parallelogram
    {
        public void hasil_Area(int based, int high)
        {
            int hasil = based * high;
            Console.WriteLine("Area : " + hasil);
        }
        public void hasil_Around(int based, int high, int side)
        {
            int hasil = 2 * (high + based);
            Console.WriteLine("Around : " + hasil);
        }
    }
}
