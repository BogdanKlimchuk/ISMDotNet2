using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b, c;
            double D, x1, x2;
            Console.WriteLine("A = ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("A - тыльки ціле!");
                Console.WriteLine("B = ");
            }
            Console.WriteLine("B = ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("B - тыльки ціле!");
                Console.WriteLine("B = ");
            }
            Console.WriteLine("C = ");
            while (!int.TryParse(Console.ReadLine(), out c))
            {
                Console.WriteLine("C - тыльки ціле!");
                Console.WriteLine("C = ");
            }
            D = b * b - 4.0 * a * c;
            Console.WriteLine($"D = {D}");
            if (D > 0)
            {
                Console.WriteLine("2 розвязки:");
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                Console.WriteLine("1 розвязок:");
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                Console.WriteLine($"x = {x1}");
            }
            else
            {
                Console.WriteLine("Жодного розвязку:");
            }

            }
    }
}
