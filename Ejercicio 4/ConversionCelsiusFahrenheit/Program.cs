using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionCelsiusFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjuntos de operaciones

            //Instanciar clase Conversor Temperaturas
            ConversorTemperaturas objTemperatura = new ConversorTemperaturas();

            Console.WriteLine("EJERCICIO 4: CONVERTIR GRADOS CELSIUS A FAHRENHEIT ");
            Console.WriteLine("___________________________________________________");

            //Datos de entrada
            Console.Write("Introduce la temperatura en grados °C: ");
            objTemperatura.gradosc = (decimal)double.Parse(Console.ReadLine());

            //Proceso
            objTemperatura.ConvertirCelsiusFahrenheit();

            //Salida
            Console.Write("La temperatura en grados °F es: " + objTemperatura.gradosf);
            
            Console.ReadKey();
        }
    }
}
