using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число N (N > 0):");
            if (int.TryParse(Console.ReadLine(), out N) && N > 0)
            {
                int Result = 0;
                int factorial = 1;
                for (int i = 1; i <= N; i++)
                {
                    factorial *= i;
                    Result += factorial;
                }
                    Console.WriteLine(Result);
                
            }
            else
                Console.WriteLine("Ошибка! Неправильно введено число N! N должно быть целое и больше 0");
        }
    }
}
