using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirPesosDolares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjuntos de operaciones

            //Instanciar clase Conversion Moneda 
            ConversionMoneda objMoneda = new ConversionMoneda();

            Console.WriteLine("PROGRAMA 3: CONVERTIR PESOS EN DOLARES ");
            Console.WriteLine("_______________________________________");

            Console.Write("Introduce la cantidad de pesos a convertir: $ ");
            objMoneda.pesos = int.Parse(Console.ReadLine());

            Console.Write("Introduce el valor del dolar: ");
            objMoneda.valordolar = decimal.Parse(Console.ReadLine());

            //Proceso
            objMoneda.ConvertirPesosDolares();

            //Salida
            Console.Write("Los dolares en total son: USD "  + objMoneda.dolaresTotal );

            Console.ReadKey();

        }
    }
}
