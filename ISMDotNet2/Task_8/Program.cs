using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double a, result;
            int n;
            Console.Write("A = ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Лише числа!");
                Console.Write("A = ");
            }
            result = a;
            Console.Write("N = ");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Лише ціле!");
                Console.Write("N = ");
            }
            for (int i = n; i > 1; i -= 1)
            {
                result *= a;
            }
            Console.WriteLine($"{a}^{n} = {result}");
        }
    }
}
