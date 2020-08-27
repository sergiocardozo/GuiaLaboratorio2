using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            float año;

            Console.Write("Ingrese un año: ");
            año = float.Parse(Console.ReadLine());

            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                Console.WriteLine("Es año biciesto");
            else
                Console.WriteLine("No es biciesto");

            Console.ReadLine();
        }
    }
}
