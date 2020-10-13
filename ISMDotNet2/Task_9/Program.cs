using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            ulong n, sum = 0, fact = 1;
            Console.Write("N = ");
            while (!ulong.TryParse(Console.ReadLine(), out n) || n < 1)
            {
                Console.WriteLine("Число цiлем i бiльше нуля!");
                Console.Write("N = ");
            }
            for (ulong i = 1; i <= n; i += 1)
            {
                fact *= i;
                sum += fact;
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
