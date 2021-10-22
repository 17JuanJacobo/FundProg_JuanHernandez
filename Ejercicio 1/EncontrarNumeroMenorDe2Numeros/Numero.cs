using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarNumeroMenorDe2Numeros
{
    //Clase
    class Numero
    {
        //Atributos
        public int numero1, numero2;

        //Metodos
        public void EncontrarNumeroMenorDe2numeros()
        {
            //Conjunto de operaciones
            if (numero1 <= numero2)
            {
                Console.WriteLine("El numero menor es: " + numero1);
            }
            else if (numero2 <= numero1)
            {
                Console.WriteLine("El numero menor es: " + numero2);
            }
            else
            {
                Console.WriteLine("Sus numeros son iguales");
            }
        
        }
            
             

    }
}
