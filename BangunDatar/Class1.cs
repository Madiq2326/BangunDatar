using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Square
    {
        public void hasil_Area(int side)
        { 
            int hasil= side * side;
            Console.WriteLine("Area : " + hasil);
        }
        public void hasil_Around(int side)
        {
            int hasil = 4 * side;
            Console.WriteLine("Around : " + hasil);
        }
    }
}
