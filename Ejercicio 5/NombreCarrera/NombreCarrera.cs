using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreCarrera
{
    //Clase
    class NombreCarrera
    {
        //Atributos
        public string respuesta;

        //Metodos
        public void NombreCarreraCompleto()
        {
            //Conjunto de operaciones
            if (respuesta == "ige")
            {
                Console.WriteLine("Ingenieria en Gestion Empresarial ");
            } 
            else if(respuesta == "itic")
            {
                Console.WriteLine("Ingenieria en Tecnologias de la Informacion y Comunicaciones ");
            }
            else if(respuesta == "iia")
            {
                Console.WriteLine("Ingenieria em Industrias Alimentarias ");
            }
            else
            {
                Console.WriteLine("Su carrera no es valida ");
            }
        }
    }
}
