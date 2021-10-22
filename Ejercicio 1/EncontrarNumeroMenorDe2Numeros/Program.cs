using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarNumeroMenorDe2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjuntos de operaciones

            //Instanciar clase Numero
            Numero objNumeroe = new Numero();

            Console.WriteLine("EJERCICIO 1: ENCONTRAR EL NUMERO MENOR DE 2 NUMEROS ");
            Console.WriteLine("____________________________________________________");

            Console.Write("Introduce el primer numero: ");
            objNumeroe.numero1 = int.Parse(Console.ReadLine());
            
            Console.Write("Introduce el segundo numero: ");
            objNumeroe.numero2 = int.Parse(Console.ReadLine());

            //Proceso
            objNumeroe.EncontrarNumeroMenorDe2numeros();

            //Salida
            Console.ReadKey();
        }
    }
}
