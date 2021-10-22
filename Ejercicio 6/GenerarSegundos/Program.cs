using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarSegundos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjuntos de operaciones

            //Instanciar clase Segundos
            Segundos objsegundos = new Segundos();

            Console.WriteLine("EJERCICIO 6: CALCULAR LOS SEGUNDOS TOTALES ");
            Console.WriteLine("__________________________________________________");

            Console.Write("Introduce los dias: ");
            objsegundos.dias = int.Parse(Console.ReadLine());

            Console.Write("Introduce las horas: ");
            objsegundos.horas = int.Parse(Console.ReadLine());

            Console.Write("Introduce los minutos: ");
            objsegundos.minutos = int.Parse(Console.ReadLine());

            //Proceso
            objsegundos.SegundosTotales();

            Console.WriteLine("El total de segundos es: " + objsegundos.SegundosT);

            //Salida
            Console.ReadKey();
        }
    }
}
