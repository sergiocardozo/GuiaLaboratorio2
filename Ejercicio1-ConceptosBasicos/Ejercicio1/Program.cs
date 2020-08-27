using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            int promedio = 0;
            int maximo = 0;
            int minimo = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingresa un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                acumulador += numero;

                if (i == 0 || numero > maximo)
                    maximo = numero;
                if (i == 0 || numero < minimo)
                    minimo = numero;

                promedio = acumulador / 5;

            }
            Console.WriteLine($"El numero minimo es {minimo}");
            Console.WriteLine($"El numero maximo es {maximo}");
            Console.WriteLine($"El numero promedio es {promedio}");

            Console.ReadKey();
        }
    }
}
