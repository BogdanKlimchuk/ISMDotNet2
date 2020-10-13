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
            int a, b, P, S;
            Console.WriteLine("A = ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("B = ");
            b = int.Parse(Console.ReadLine());
            P = 2 * a + 2 * b;
            S = a * b;
            Console.WriteLine($"P = {P}");
            Console.WriteLine($"S = {S}");
        }
    }
}
