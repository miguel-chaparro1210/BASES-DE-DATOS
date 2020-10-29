using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección02FundamentosPOOHerenciaSimple
{
    public class Lavadora : Electrodomestico
    {

        public string  PerillaCiclosLavado { get; set; }

        public string CapacidadCarga { get; set; }

        public void LlenarAgua(int Litros)
        {
            Console.WriteLine("Agrgando {0} litros de agua", Litros );
        }

        public void VaciarAgua()
        {
            Console.WriteLine("Vaciando agua de la lavadora");
        }
    }
}
