using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaNacimiento
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjunto de operaciones 

            //Instanciar clase Edad
            Edad objedad = new Edad();

            Console.WriteLine("EJERCICIO 8: DETERMINAR LA EDAD DE UNA PERSONA ");
            Console.WriteLine("_______________________________________________");

            //Datos de entrada
            Console.WriteLine("Introdusca su fecha de nacimiento ");

            Console.Write("Introdusca el dia: ");
            objedad.dia = int.Parse(Console.ReadLine());

            Console.Write("Introdusca el mes en numero: ");
            objedad.mes = int.Parse(Console.ReadLine());

            Console.Write("Introdusca el año: ");
            objedad.año = int.Parse(Console.ReadLine());

            //Proceso
            objedad.CalcularEdad();

            Console.WriteLine("Su edad es: " + objedad.edad);

            //Salida
            Console.ReadKey();


        }
    }
}
