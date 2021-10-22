using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjuntos de operaciones

            //Instanciar clase promedio
            Promedio objPromedioC = new Promedio();

            Console.WriteLine("EJERCICIO 7: CALCULAR EL PROMEDIO DE 4 NUMEROS Y ENCONTRAR EL MAS CERCANO AL PROMEDIO ");
            Console.WriteLine("______________________________________________________________________________________");

            //Datos de entrada 
            Console.Write("Introduce el primer numero: ");
            objPromedioC.numero1 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Introduce el segundo numero: ");
            objPromedioC.numero2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Introduce el tercer numero: ");
            objPromedioC.numero3 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Introduce el cuarto numero: ");
            objPromedioC.numero4 = Convert.ToDecimal(Console.ReadLine());

            //Proseso
            objPromedioC.CalcularPromedioCercano();
            
            //Salida
            Console.ReadKey();

        }
    }
}
