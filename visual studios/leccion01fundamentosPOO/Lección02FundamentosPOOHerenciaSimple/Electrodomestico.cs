using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección02FundamentosPOOHerenciaSimple
{
   public class Electrodomestico
    {
        //Atributos

        public string Interruptor { get; set; }

        public string CableElectrico { get; set; }


        //Metodos

        public void Encender() 
        {
            Console.WriteLine("Encendiendo el electrodomestico");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando el electrodomestico");
        }
    }
}
