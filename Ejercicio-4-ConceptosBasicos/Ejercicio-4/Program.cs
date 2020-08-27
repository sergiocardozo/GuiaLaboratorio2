using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int primosEncontrados;
            int divisor;
            int i;
            Console.WriteLine("Numeros Perfectos");
            for (i = 1, primosEncontrados = 0; primosEncontrados < 4; i++, acumulador = 0)
            {
                for(divisor = 1; divisor < i; divisor++)
                {
                    if (i % divisor == 0)
                        acumulador += divisor;
                }
                if(acumulador == i)
                {
                    Console.WriteLine($"{i}");
                    primosEncontrados++;
                }
            }
            
            Console.ReadKey();
        }
    }
}
