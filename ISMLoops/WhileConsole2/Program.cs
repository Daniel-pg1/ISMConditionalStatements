using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            double p, s = 10, s1 = 10;
            int k = 1;
            Console.WriteLine("Введите процент (0 < P < 50):");
            if (double.TryParse(Console.ReadLine(), out p) && p < 50 && p > 0)
            {
                while (s <= 200)
                {
                    s1 += s1 * p / 100;
                    s += s1;
                    k++;
                }
                Console.WriteLine($"Дни: {k}\n Общий пробег:{s}");
            }
            else
                Console.WriteLine("Ошибка! Неправильно введено число P(0 < P < 50)!");
        }
    }
}
