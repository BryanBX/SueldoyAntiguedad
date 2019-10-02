using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldoyAntiguedad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("             Sueldo y Antiguedad               ");
            Console.WriteLine("");

            double sueldo = 0, antiguedad = 0, aumento = 0;

            Console.WriteLine("Ingrese sueldo");
            sueldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese antiguedad");
            antiguedad = double.Parse(Console.ReadLine());

            if (sueldo < 500 && antiguedad >= 10)
                aumento = (sueldo * 0.2) + sueldo;
            if (sueldo < 500 && antiguedad < 10)
                aumento = (sueldo * 0.05) + sueldo;
            if (sueldo >= 500)
                aumento = sueldo;
            Console.WriteLine("Su sueldo es {0}",aumento);
            
            Console.ReadKey();

        }
    }
}
