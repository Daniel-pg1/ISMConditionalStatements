using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, x1, x2, x3, y1, y2, y3;
            Console.WriteLine("Введите координату точки х: ");
            if(double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введите координату точки у: ");
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Введите координату вершины треугольника x1: ");
                    if (double.TryParse(Console.ReadLine(), out x1))
                    {
                        Console.WriteLine("Введите координату вершины треугольника y1: ");
                        if (double.TryParse(Console.ReadLine(), out y1))
                        {
                            Console.WriteLine("Введите координату вершины треугольника x2: ");
                            if (double.TryParse(Console.ReadLine(), out x2))
                            {
                                Console.WriteLine("Введите координату вершины треугольника y2: ");
                                if (double.TryParse(Console.ReadLine(), out y2))
                                {
                                    Console.WriteLine("Введите координату вершины треугольника x3: ");
                                    if (double.TryParse(Console.ReadLine(), out x3))
                                    {
                                        Console.WriteLine("Введите координату вершины треугольника y3: ");
                                        if (double.TryParse(Console.ReadLine(), out y3))
                                        {
                                             if ((x1 ==x2 && x2== x3) || (y1 == y2 && y2 == y3))
                                            {
                                                Console.WriteLine("Ошибка! Такого треугольника не существует");
                                            }
                                            else
                                            {
                                                double f1= (x1 - x) * (y2 - y1) - (x2 - x1) * (y1 - y);
                                                double f2 = (x2 - x) * (y3 - y2) - (x3 - x2) * (y2 - y);
                                                double f3 = (x3 - x) * (y1 - y3) - (x1 - x3) * (y3 - y);
                                                if((f1 >= 0 && f2 >= 0 && f3 >= 0) || (f1 <= 0 && f2 <= 0 && f3 <= 0))
                                                {
                                                    Console.WriteLine("Точка принадлежит треугольнику");
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Точка не принадлежит треугольнику");
                                                }

                                            }


                                        }
                                        else
                                        {
                                            Console.WriteLine("Ошибка! Неправильно введена координата y3!");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Ошибка! Неправильно введена координата х3!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка! Неправильно введена координата y2!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Ошибка! Неправильно введена координата х2!");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Ошибка! Неправильно введена координата y1!");
                        }

                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Неправильно введена координата х1!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Неправильно введена координата у!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Неправильно ввведена координата х!");
            }
        }
    }
}
