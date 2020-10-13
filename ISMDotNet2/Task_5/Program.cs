using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            Console.Write("Оберіть день:");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Лише цiлi числа!");
                Console.Write("Оберіть день: ");
            }
            switch (a)
            {
                case 1:
                    {
                        Console.WriteLine("Понедiлок");
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Вiвторок");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Середа");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Четвер");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("П'ятниця");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Субота");
                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Недiля");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Такого дня не існує!");
                        break;
                    }
                }
            }
        }
    }
