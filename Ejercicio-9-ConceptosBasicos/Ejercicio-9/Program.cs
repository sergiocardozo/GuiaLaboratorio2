using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, incremento = 0;

            Console.Write("Ingrese la altura de la piramide: ");
            altura = Convert.ToInt32(Console.ReadLine());

            while(incremento <= altura)
            {
                incremento++;
                for (int i = 0; i < incremento; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
