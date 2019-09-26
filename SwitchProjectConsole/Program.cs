using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchProjectConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, dos = 0;
            do
            {
                Console.WriteLine("1. Расшифровка дня недели.");
                Console.WriteLine("2. Расшифровка месяца.");
                Console.WriteLine("3. Выполнение операций над числами.");
                Console.WriteLine("4. Выход");
                Console.WriteLine("Выберите пункт: ");
                if (int.TryParse(Console.ReadLine(), out num))
                    switch (num)
                    {
                        case 1:

                            int daynum;
                            Console.WriteLine("Введите номер дня недели (от 1 до 7): ");
                            if (int.TryParse(Console.ReadLine(), out daynum))
                                switch (daynum)
                                {
                                    case 1:
                                        Console.WriteLine("1. Понедельник");
                                        break;
                                    case 2:
                                        Console.WriteLine("2. Вторник");
                                        break;
                                    case 3:
                                        Console.WriteLine("3. Среда");
                                        break;
                                    case 4:
                                        Console.WriteLine("4. Четверг");
                                        break;
                                    case 5:
                                        Console.WriteLine("5. Пятница");
                                        break;
                                    case 6:
                                        Console.WriteLine("6. Суббота");
                                        break;
                                    case 7:
                                        Console.WriteLine("7. Воскресенье");
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка: такого дня недели не существует!");
                                        break;
                                }
                            else
                                Console.WriteLine("Ошибка! Нужно ввести номер дня!");
                            break;
                        case 2:
                            int monthnum;
                            Console.WriteLine("Введите номер месяца (от 1 до 12): ");
                            if (int.TryParse(Console.ReadLine(), out monthnum))
                                switch (monthnum)
                                {
                                    case 1:
                                        Console.WriteLine("1. Январь");
                                        break;
                                    case 2:
                                        Console.WriteLine("2. Февраль");
                                        break;
                                    case 3:
                                        Console.WriteLine("3. Март");
                                        break;
                                    case 4:
                                        Console.WriteLine("4. Апрель");
                                        break;
                                    case 5:
                                        Console.WriteLine("5. Май");
                                        break;
                                    case 6:
                                        Console.WriteLine("6. Июнь");
                                        break;
                                    case 7:
                                        Console.WriteLine("7. Июль");
                                        break;
                                    case 8:
                                        Console.WriteLine("8. Август");
                                        break;
                                    case 9:
                                        Console.WriteLine("9. Сентябрь");
                                        break;
                                    case 10:
                                        Console.WriteLine("10. Октябрь");
                                        break;
                                    case 11:
                                        Console.WriteLine("11. Ноябрь");
                                        break;
                                    case 12:
                                        Console.WriteLine("12. Декабрь");
                                        break;
                                    default:
                                        Console.WriteLine("Ошибка: такого месяца не существует!");
                                        break;
                                }
                            else
                                Console.WriteLine("Ошибка! Нужно ввести номер месяца!");
                            break;
                        case 3:
                            int opernum;
                            double a, b, result;
                            Console.WriteLine("Введите первое число: ");
                            if (double.TryParse(Console.ReadLine(), out a))
                            {
                                Console.WriteLine("Введите второе число: ");
                                if (double.TryParse(Console.ReadLine(), out b))
                                {
                                    Console.WriteLine("1. Сложение");
                                    Console.WriteLine("2. Умножение");
                                    Console.WriteLine("3. Вычитание");
                                    Console.WriteLine("4. Деление");
                                    Console.WriteLine("Выберите операцию: ");
                                    if (int.TryParse(Console.ReadLine(), out opernum))
                                    {
                                        switch (opernum)
                                        {
                                            case 1:
                                                result = a + b;
                                                Console.WriteLine("Ответ:" + result);
                                                break;
                                            case 2:
                                                result = a * b;
                                                Console.WriteLine("Ответ:" + result);
                                                break;
                                            case 3:
                                                result = a - b;
                                                Console.WriteLine("Ответ:" + result);
                                                break;
                                            case 4:
                                                result = a / b;
                                                Console.WriteLine("Ответ:" + result);
                                                break;
                                            default:
                                                Console.WriteLine("Ошибка! Нужно ввести номер пункта!");
                                                break;
                                        }
                                    }
                                    else
                                        Console.WriteLine("Ошибка! Такого пункта не существует!");

                                }
                                else
                                    Console.WriteLine("Второе число введено неверно!");
                            }
                            else
                                Console.WriteLine("Первое число введено неверно!");
                            break;
                        case 4:
                            Console.WriteLine("Нажмите любую кнопку для выхода!");
                            dos = 1;
                            break;
                        default:
                            Console.WriteLine("Ошибка при выборе пункта: такого пункта не существует!");
                            break;
                    }
                else
                    Console.WriteLine("Ошибка! Нужно ввести номер пункта!");

            } while (dos == 0);
        }
    }
}
