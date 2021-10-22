using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    class Promedio
    {
        //Atributos
        public decimal numero1, numero2, numero3, numero4, promedio, resta1, resta2, resta3, resta4;

        //Metodos
        public void CalcularPromedioCercano()
        {
            promedio = (numero1 + numero2 + numero3 + numero4) / 4;
            resta1 = (promedio - numero1) * (promedio - numero1);
            resta2 = (promedio - numero2) * (promedio - numero2);
            resta3 = (promedio - numero3) * (promedio - numero3);
            resta4 = (promedio - numero4) * (promedio - numero4);

            //Condiciones
            if (resta1 < resta2)
            {
                if (resta1 < resta3)
                {
                    if (resta1 < resta4)
                    {
                        Console.WriteLine("El promedio es " + promedio);
                        Console.WriteLine("El número mas cercano al promedio es " + numero1);
                    }
                    else
                    {
                        Console.WriteLine("El promedio es " + promedio);
                        Console.WriteLine("El número mas cercano al promedio es " + numero4);
                    }
                }
                else if (resta3 < resta4)
                {
                    Console.WriteLine("El promedio es " + promedio);
                    Console.WriteLine("El número mas cercano al promedio es " + numero3);
                }
                else
                {
                    Console.WriteLine("El promedio es " + promedio);
                    Console.WriteLine("El número mas cercano al promedio es " + numero4);
                }

            }

            else if (resta2 < resta3)
            {
                if (resta2 < resta4)
                {
                    Console.WriteLine("El promedio es " + promedio);
                    Console.WriteLine("El número mas cercano al promedio es " + numero2);
                }
                else
                {
                    Console.WriteLine("El promedio es " + promedio);
                    Console.WriteLine("El número mas cercano al promedio es " + numero4);
                }
            }
            else
            {
                if (resta3 < resta4)
                {
                    Console.WriteLine("El promedio es " + promedio);
                    Console.WriteLine("El número mas cercano al promedio es " + numero3);
                }
                else
                {
                    Console.WriteLine("El promedio es " + promedio);
                    Console.WriteLine("El número mas cercano al promedio es " + numero4);
                }

            }
    }
}

}
