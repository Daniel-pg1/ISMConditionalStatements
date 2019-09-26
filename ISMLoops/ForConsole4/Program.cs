using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            double Result = 0;
            Console.WriteLine("Введите число А");
            if (int.TryParse(Console.ReadLine(), out A))
            {
                Console.WriteLine("Введите число B (A < B)");
                if (int.TryParse(Console.ReadLine(), out B) && A < B)
                {
                    for (int i = A; i <= B; i++)
                        Result += i * i;
                    Console.WriteLine(Result);
                }
                else
                    Console.WriteLine("Ошибка!Неправильно введено число B! Введите целое число!");

            }
            else
                Console.WriteLine("Ошибка!Неправильно введено число А! Введите целое число!");
        }
    }

}
