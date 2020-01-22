using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Triangel
    {
        public void hasil_Area(int based, int high)
        {
            int hasil = based * high/ 2;
            Console.WriteLine("Area : " + hasil);
        }
        public void hasil_Around(int based, int high, int side)
        {
            int hasil = high + based + side;
            Console.WriteLine("Around : " + hasil);
        }
    }
}
