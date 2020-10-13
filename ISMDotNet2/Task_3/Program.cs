using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int x, a, b;
            double y;
            Console.WriteLine("X = ");
            while (!int.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("X - не число!");
                Console.WriteLine("X = ");
            }

            Console.WriteLine("A = ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("A - не число!");
                Console.WriteLine("A = ");
            }

            Console.WriteLine("B = ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("B - не число!");
                Console.WriteLine("B = ");
            }
            y = 2.4 * Math.Abs((x * x + b) / a) + (a - b) * Math.Sin(a - b) * Math.Sin(a - b) + (1.0 / 100) * (x - b);
            Console.WriteLine($"Y = {y}");
        }
    }
}
