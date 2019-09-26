using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, K;
            Console.WriteLine("Введите число N (N > 0) :");
            if (int.TryParse(Console.ReadLine(), out N) && N > 0)
            {
                Console.WriteLine("Введите число K (K > 0):");
                if (int.TryParse(Console.ReadLine(), out K) && N > 0)
                {
                    double Result = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        Result += Math.Pow(i, K);
                    }
                    Console.WriteLine(Result);
                }
                else
                    Console.WriteLine("Ошибка! Неправильно введено число K! Введите целое число!");
            }
            else
                Console.WriteLine("Ошибка! Неправильно введено число N! Введите целое число!");
        }
    }
}
