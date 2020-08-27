using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime();
            TimeSpan dias;

            Console.Write("Ingresar fecha de nacimiento: ");
            fecha = DateTime.Parse(Console.ReadLine());
            dias = DateTime.Now - fecha;

            Console.WriteLine($"Dias vividos desde {fecha:dd/MM/yyyy}: {dias}");

            Console.ReadLine();
        }
    }
}
