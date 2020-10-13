using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int n;
            double sum = 0;
            Console.Write("N = ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("Число цiле i бiльше за нуль!");
                Console.Write("N = ");
            }
            for (int i = 1; i <= n; i += 1)
            {
                sum += 1.0 / i;
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
