using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lección02FundamentosPOOHerenciaSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear objeto 

            Televisor objTelevisor1 = new Televisor();

            //Acceso a las prioridades generalizadas//

            objTelevisor1.CableElectrico = "3 mtros";
            objTelevisor1.Interruptor = "Digital";

            //Acceso a las prioridades especializadas//

            objTelevisor1.BotonCanales = "Digital";
            objTelevisor1.BotonVolumen = "Digital";

            objTelevisor1.Encender();      //Acceso a las prioridades generalizadas//
            objTelevisor1.CambiarVolumen(true , 10 );   //Acceso a las prioridades especializadas//
            objTelevisor1.CambiarCanal(705);           //Acceso a las prioridades especializadas//
            objTelevisor1.Apagar();       //Acceso a las prioridades generalizadas//

            
            Lavadora objlavadora1 = new Lavadora();

            objlavadora1.CableElectrico = "5 mtros";
            objlavadora1.Interruptor = "Digital";

            objlavadora1.PerillaCiclosLavado = "4";
            objlavadora1.CapacidadCarga = "3 Litros";

            objlavadora1.Encender();      //Acceso a las prioridades generalizadas//
            objlavadora1.LlenarAgua(3);   //Acceso a las prioridades especializadas//
            objlavadora1.VaciarAgua();           //Acceso a las prioridades especializadas//
            objlavadora1.Apagar();       //Acceso a las prioridades generalizadas//

            Console.ReadKey(true);
        }
    }
}
