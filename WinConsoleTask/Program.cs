using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsoleTask
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                        System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            double x, y, z;
            Console.WriteLine("Введiть х: ");
            if (double.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine("Введiть y: ");
                if (double.TryParse(Console.ReadLine(), out y))
                {
                    Console.WriteLine("Введiть z: ");
                   if( double.TryParse(Console.ReadLine(), out z))
                    {
                        double r;
                        r = (2.0 * Math.Cos(x * x) - 1.0 / 2.0)
                    / (1.0 / 2.0 + Math.Sin(Math.Pow(y, 2.0 - z)))
                    + (Math.Pow(z, 2) / (7.0 - z / 3.0));
                        Console.WriteLine("Вiдповiдь = " + Math.Round(r, 2));

                    }
                    else
                        Console.WriteLine("Помилка введення значення z!");
                    
                }
                else
                    Console.WriteLine("Помилка введення значення y!");
                
            }
            else
                Console.WriteLine("Помилка введення значення x!");
            



        }
    }
}
