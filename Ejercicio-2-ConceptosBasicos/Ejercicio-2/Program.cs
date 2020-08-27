using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string seguir;

            do
            {
                Console.Write("Ingresar un numero: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 0)
                {
                    Console.WriteLine("Error Vuelva a ingresar el numero");
                }
                Console.WriteLine($"El cuadrado del numero ingresado es: {Math.Pow(numero, 2)}");
                Console.WriteLine($"El cubo del numero ingresado es: {Math.Pow(numero, 3)}");

                Console.WriteLine("Desea continuar (si/no)");
                seguir = Console.ReadLine();

            } while (seguir != "no");

            Console.ReadKey();
        }
    }
}
