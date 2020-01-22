using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Rectangel
    {
         public void hasil_Area(int length, int width)
        {
            int hasil = length * width;
            Console.WriteLine("Area : " + hasil);
        }
        public void hasil_Around(int length, int width)
        {
            int hasil = 2 * (length + width);
            Console.WriteLine("Around : " + hasil);
        }
    }
}
