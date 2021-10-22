using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncontrarNumeroPar
{
    //Clase
    class Numero
    {
        //Atributos
        public int numeroe;

        //Metodos
        public void EncontrarNumeroPar() 
        {
            //Conjuntos de operaciones
            if (numeroe % 2 == 0) 
            {
                Console.Write("El numero " + numeroe + " es par");
            }
            else 
            {
                Console.Write("El numero " + numeroe + " no es par");
            }
        }
    }
}
