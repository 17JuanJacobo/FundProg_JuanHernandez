using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreCarrera
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjunto de operaciones

            //Instanciar clase Nombre Carrera
            NombreCarrera objCarrera = new NombreCarrera();

            Console.WriteLine("EJERCICIO 5: DETERMINAR EL NOMBRE COMPLETO DE LA CARRERA ");
            Console.WriteLine("_________________________________________________________");

            //Datos de entrada
            Console.Write("Introduce la carrera: ");
            objCarrera.respuesta = Convert.ToString(Console.ReadLine());

            //Proceso
            objCarrera.NombreCarreraCompleto();

            //Salida
            Console.ReadKey();

            
        }
    }
}
