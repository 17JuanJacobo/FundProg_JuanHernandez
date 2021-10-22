using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarNumeroPar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjuntos de operaciones

            //Instanciar clase Numero o crear clase
            Numero objNumeroe = new Numero();

            Console.WriteLine("EJERCICIO 2: DETERMINAR SI UN NUMERO ENTERO ES PAR ");
            Console.WriteLine("___________________________________________________");

            //Datos de entrada
            Console.Write("Introduce un numero entero: ");
            objNumeroe.numeroe = int.Parse(Console.ReadLine());

            //Proceso
            objNumeroe.EncontrarNumeroPar();

            //Salida
            Console.ReadKey();
        }
    }
}
