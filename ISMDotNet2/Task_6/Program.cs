using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int num = 1;
            int a, b;
            do
            {
                Console.Write("A =");
                while (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Лише цiлi числа!");
                    Console.Write("A = ");
                }

                Console.Write("B = ");
                while (!int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Лише цiлi числа!");
                    Console.Write("B = ");
                }
                if (a >= b) { Console.WriteLine("A < B"); }
            } 
            while (a >= b);
            for (int i = b; i >= a; i-=1)
            {
                num *= i;
            }
            Console.WriteLine($"Добуток від {a} до {b} = {num}");
        }
    }
}
