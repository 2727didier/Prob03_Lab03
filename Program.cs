using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob03_Lab03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startYear = 1900;
            int currentYear = DateTime.Now.Year;

            Console.WriteLine($"Años bisiestos desde {startYear} hasta {currentYear}:");

            for (int year = startYear; year <= currentYear; year++)
            {
                if (EsBisiesto(year))
                {
                    Console.WriteLine(year);
                }
            }
        }

        static bool EsBisiesto(int year)
        {
            // Un año es bisiesto si es divisible por 4, pero no por 100, o es divisible por 400.
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }

}
    
