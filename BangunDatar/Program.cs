using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BangunDatar
{
    class Program
    {
        static void Main(string[] args)
        {
            awal:
            int a, b;
            int option;
            Console.WriteLine("1. Square ");
            Console.WriteLine("2. Rectangel ");
            Console.WriteLine("3. Round ");
            Console.WriteLine("4. Triangel ");
            Console.WriteLine("5. Parallelogram ");
            Console.Write("Choose two-dimentional shape : ");
            option = Convert.ToInt16(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Input side : ");
                    int side = Convert.ToInt16(Console.ReadLine());

                    Square hasil_square = new Square();

                    hasil_square.hasil_Area(side);
                    hasil_square.hasil_Around(side);
                    break;

                case 2:
                    Console.Write("Input Length : ");
                    int length = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Input Width : ");
                    int width = Convert.ToInt16(Console.ReadLine());

                    Rectangel hasil_rectangel = new Rectangel();

                    hasil_rectangel.hasil_Area(length, width);
                    hasil_rectangel.hasil_Around(length, width);

                    break;

                case 3:
                    Console.Write("Input radius : ");
                    int radius = Convert.ToInt16(Console.ReadLine());
                    
                    Round hasil_round = new Round();

                    hasil_round.hasil_Area(radius);
                    hasil_round.hasil_Around(radius);

                    break;

                case 4:
                    Console.Write("Input base : ");
                    int based = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Input high : ");
                    int high = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Input side : ");
                    side = Convert.ToInt16(Console.ReadLine());

                    Triangel hasil_triangel = new Triangel();

                    hasil_triangel.hasil_Area(based, high);
                    hasil_triangel.hasil_Around(based, high, side);

                    break;

                case 5:
                    Console.Write("Input base : ");
                    based = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Input high : ");
                    high = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Input side : ");
                    side = Convert.ToInt16(Console.ReadLine());

                    Parallelogram hasil_parellelogram = new Parallelogram();

                    hasil_parellelogram.hasil_Area(based, high);
                    hasil_parellelogram.hasil_Around(based, high, side);

                    break;

                default:
                    Console.WriteLine("ERROR");
                    goto awal;
            }

        }
    }
}
