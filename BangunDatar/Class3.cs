using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Round
    {
        public void hasil_Area(int radius)
        {
            int hasil = 22 / 7 * radius * radius;
            Console.WriteLine("Area : " + hasil);
        }
        public void hasil_Around(int radius)
        {
            int hasil = 22 / 7 * (radius + radius);
            Console.WriteLine("Around : " + hasil);
        }
    }
}
