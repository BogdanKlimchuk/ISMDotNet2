using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double z1, z2;
            int m, n;
            Console.WriteLine("Введiть m: ");
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("M - не число!!");
                Console.WriteLine("M =");
            }
            Console.WriteLine("Введiть n: ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("N - не число!");
                Console.WriteLine("N = ");
            }
            z1 = ((m - 1) * Math.Sqrt(m) - (n - 1) * Math.Sqrt(n)) / (Math.Sqrt(m * m * m * n) + n * m + m * m - m);
            Console.WriteLine($"z1 = {z1}");
            z2 = (Math.Sqrt(m) - Math.Sqrt(n)) / m;
            Console.WriteLine($"z2 = {z2}"); 
        }
    }
}
