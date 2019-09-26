using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            Console.WriteLine("Введите число А:");
            if (int.TryParse(Console.ReadLine(), out A))
            {
                Console.WriteLine("Введите число B (A < B):");
                if (int.TryParse(Console.ReadLine(), out B))
                {
                    if (A < B)
                    {
                        int Result = 1;
                        for (int i = A; i <= B; i++)
                            Result *= i;
                        Console.WriteLine(Result);
                    }
                    else
                        Console.WriteLine("А должно быть меньше B!");
                }
                else
                    Console.WriteLine("Ошибка! Неправильно введено число B! Введите целое число!");
            }
            else
                Console.WriteLine("Ошибка!Неправльно введено число А! Введите целое число!");
        }
    }
}
