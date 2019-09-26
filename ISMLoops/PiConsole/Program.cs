using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 0, piVieta = 1;
            int number;
            Console.WriteLine("Введите количество итераций: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    x = Math.Sqrt(0.5 + 0.5 * Math.Sqrt(x));
                    piVieta *= x;
                }
                piVieta = 2.0 / piVieta;
                Console.WriteLine($"ПИ за Виета: {piVieta}\n");

                double piWallis = 1;
                x = 1;
                for (int i = 1; i <= number; i+=2)
                {
                    x *= (i * (i + 2.0)) / ((i + 1.0) * (i + 1));
                }
                piWallis = 2.0 / x;
                Console.WriteLine($"ПИ за Wallis: {piWallis}\n");
                double piBrouncker = 1;
                x = 0;
                for (int i = 3; i <= number; i += 2)
                {
                    x = 2 + Math.Pow(i, 2) / x;
                }
                piBrouncker = 4.0 / (1 + 1.0 / x);
                Console.WriteLine($"ПИ за Brouncker: {piBrouncker}\n");

                double piLeibniz = 1;
                x = 0;
                for (int i = 1; i <= number; i += 4)
                {
                    x += ((1.0 / i) - 1.0 / (i + 2));
                }
                piLeibniz = x * 4;

                Console.WriteLine($"ПИ за Leibniz: {piLeibniz}\n");
            }
            else
                Console.WriteLine("Ошибка! Введите целое число!");








        }
    }
}
