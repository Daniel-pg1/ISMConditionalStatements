using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double Result = 0;
            Console.WriteLine("Введите число N (N > 0):");
            if (int.TryParse(Console.ReadLine(), out N))
            {
                if (N > 0)
                {
                    for (int i = 1; i <= N; i++)
                    Result += 1.0 / i;
                    Console.WriteLine(Result);
                }
                else
                    Console.WriteLine("Число N должно быть больше 0");
            }
            else
                Console.WriteLine("Ошибка! Неправильно введено число N! Введите целое число!");
        }
    }
}
