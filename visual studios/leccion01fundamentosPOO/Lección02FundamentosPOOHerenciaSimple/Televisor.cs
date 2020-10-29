using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección02FundamentosPOOHerenciaSimple
{
    public class Televisor : Electrodomestico
    {
        public string BotonVolumen { get; set; }

        public string BotonCanales { get; set; }
        public void CambiarVolumen(bool tipoVolumen, int cantidadvolumen)
        {
            string tipo = null;

            if (tipoVolumen== true)
            {
                tipo = "subiendo";
            }
            else
            {
                tipo = "Bajando";
            }

            Console.WriteLine("{0} {1} de volumen", tipo,cantidadvolumen);      
        }

        public void CambiarCanal(int numeroCanal)
        {
            Console.WriteLine("Cambiando al canal {0}", numeroCanal);
        }
    }
}