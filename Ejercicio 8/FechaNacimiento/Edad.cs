using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FechaNacimiento
{
    //Clase
    class Edad
    {
        //Atributos
        public int dia, mes, año, edad, añoactual = 2021;

        //Metodos
        public void CalcularEdad()
        {
            //conjunto de procesos
            edad = añoactual - año;

        }
    }
}
