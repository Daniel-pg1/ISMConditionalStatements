using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole6
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
                for (int i = 1; i <= N; i++)
                    Result += Math.Pow(i, N -i + 1);
                Console.WriteLine(Result);
            }
            else
                Console.WriteLine("Ошибка! Неправильно введено число N! Введите целое число!");
        }
    }
}
