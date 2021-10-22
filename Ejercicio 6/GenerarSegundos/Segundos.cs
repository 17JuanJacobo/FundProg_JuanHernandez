using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerarSegundos
{
    //Clase
    class Segundos
    {
        //Atributos
        public int dias, horas, minutos, SegundosT;
        
        //Metodos
        public void SegundosTotales()
        {
            //Conjuntos de operaciones
            SegundosT = (dias * 86400) + (horas * 3600) + (minutos * 60);
        }
    }
}
