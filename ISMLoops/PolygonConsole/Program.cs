using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double s = 0;
            int x1, x2, y1, y2;
            Console.Write("Введите количество вершин многоугольника:  ");
            if (int.TryParse(Console.ReadLine(), out n))
            {
                Console.Write("Введите x1: ");

                if (int.TryParse(Console.ReadLine(), out x1))
                {
                    Console.Write("Введите y1: ");

                    if (int.TryParse(Console.ReadLine(), out y1))
                    {

                        for (int i = 2; i <= n; i++)
                        {
                            Console.Write($"Введите x{i}: ");
                            if (int.TryParse(Console.ReadLine(), out x2))
                            {
                                Console.Write($"Введите y{i}: ");
                                if (int.TryParse(Console.ReadLine(), out y2))
                                {

                                    s += (x1 + x2) * (y1 - y2);
                                    x1 = x2;
                                    y1 = y2;

                                }
                                else
                                {
                                    Console.WriteLine($"Ошибка ввода координаты y{i}!");
                                    Environment.Exit(0);
                                    break;
                                   
                                }
                            }
                            else
                            {
                                Console.WriteLine($"Ошибка ввода координаты х{i}!");
                                Environment.Exit(0);
                                break;
                            }
                        }
                        s = Math.Abs(0.5 * s);
                        Console.WriteLine($"Площадь многоугольника = {s}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка ввода координаты y1");
                    }
                }
                else
                    Console.WriteLine("Ошибка ввода координаты х1");
            }

            else
                Console.WriteLine("Ошибка! Введите целое число!");
        }
    }
}
