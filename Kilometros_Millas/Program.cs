using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kilometros_Millas
{
    class Program
    {
        static void Main(string[] args)
        {
            //este programa convierte de kilometros a milla

            double millas, kilometros, resultados;

            Console.WriteLine("Digite la cantidad de millas");
            millas = double.Parse(Console.ReadLine());

            kilometros = millas  / 0.62137;
            kilometros = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("La cantidad de millas a kilometros es:  " + kilometros);
            Console.ReadKey();


        }
    }
}
