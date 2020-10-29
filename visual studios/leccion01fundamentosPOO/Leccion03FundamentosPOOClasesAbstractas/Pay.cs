using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion03FundamentosPOOClasesAbstractas
{
    public class Pay : Comida
    {
        public override void ImprimirComida(string Nombre)
        {
            Console.WriteLine("El {0} es muy delicioso", Nombre);
        }
    }
}
