using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas;

            Console.Write("Ingrese numero de filas que va a tener la piramide: ");
            filas = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= filas; i++)
            {
                for (int j = i; j <= filas ; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
