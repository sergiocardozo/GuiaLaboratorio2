using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5_ConceptosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            double aumento = 1, numero, i, j, sumaAtras, sumaAdelante;

            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());

            while(aumento < numero)
            {
                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                for (i = 1; i < aumento; i++)
                {
                    sumaAtras += i;
                }
                for (j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante += j;
                }
                if (sumaAtras == sumaAdelante)
                    Console.WriteLine($"Es centro numerico {aumento}");
            }
            Console.ReadKey();
        }
    }
}
