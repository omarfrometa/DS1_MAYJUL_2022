using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INTEC.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("CALCULO DE NOTAS");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("");

            double n1, n2, n3, pro;
            
            Console.WriteLine("Primer Parcial:");
            n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Parcial:");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Tercer Parcial:");
            n3 = int.Parse(Console.ReadLine());

            pro = (n1 + n2 + n3) / 3;

            Console.WriteLine($"El Promedio Final es ({pro}).");
            Console.ReadLine();
        }
    }
}
