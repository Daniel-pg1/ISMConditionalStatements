using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, result = 0;
            Console.WriteLine("Введите целые числа:");
            do
            {
                if (int.TryParse(Console.ReadLine(), out num))
                {
                    result += num;
                }
                else
                    Console.WriteLine("Ошибка! Неправильно введено число! Введите целое число!");
            } while (num != 0);
            Console.WriteLine(result);
        }
    }
}
