using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b, P, S;
            Console.WriteLine("A = ");
            while (!int.TryParse(Console.ReadLine(), out a) || a < 1)
            {
                Console.WriteLine("A - має бути цiле i бiльше за нуль");
                Console.WriteLine("A = ");
            }
            Console.WriteLine("B = ");
            while (!int.TryParse(Console.ReadLine(), out b) || b < 1)
            {
                Console.WriteLine("B - має бути цiле i бiльше за нуль");
                Console.WriteLine("B = ");
            }
            P = 2 * a + 2 * b;
            S = a * b;
            Console.WriteLine($"P = {P}");
            Console.WriteLine($"S = {S}");
        }
    }
}
