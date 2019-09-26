using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double Result = 1;
            int N;
            Console.WriteLine("Введите число А:");
            if (double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Введите число N (N > 0):");
                if (int.TryParse(Console.ReadLine(), out N) && N > 0)
                {
                    for (int i = 1; i <= N; i++)
                        Result *= a;
                    Console.WriteLine(Result);
                }
                else
                    Console.WriteLine("Ошибка! Неправильно введено число N! N должно быть целое и больше 0");

            }
            else
                Console.WriteLine("Ошибка! Неправильно введено число A!");
        }
    }
}
