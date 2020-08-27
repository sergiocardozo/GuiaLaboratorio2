using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int divisor;
            bool primo;

            Console.Write("Ingrese un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 2; i <= numero; i++)
            {
                for (divisor = 2, primo = true; divisor < i && primo == true; divisor++)
                {
                    if (i % divisor == 0)
                        primo = false;
                }
                if (primo == true)
                    Console.WriteLine($"{i:#,###.00}");
            }
            Console.ReadKey();
        }
    }
}
