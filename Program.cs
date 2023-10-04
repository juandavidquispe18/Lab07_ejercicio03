using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el año hasta el cual desea buscar años bisiestos: ");
            int año_limite = int.Parse(Console.ReadLine());

            Console.WriteLine("Años bisiestos desde 1900 hasta " + año_limite + ":");

            for (int año = 1900; año <= año_limite; año++) {

                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0)) {

                    Console.WriteLine(año);
                }
            }
            Console.ReadKey();
        }
    }
}
