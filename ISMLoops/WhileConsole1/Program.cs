using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число N (N > 1) :");
            if (int.TryParse(Console.ReadLine(), out N))
            {
                int K = 1;
                while (Math.Pow(3, K) <= N)
                {
                    K++;
                }
                Console.WriteLine(K);
            }
            else
                Console.WriteLine("Ошибка! Неправильно введено число N! Введите целое число!");
        }
    }
}
