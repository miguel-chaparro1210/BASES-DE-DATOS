using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion03FundamentosPOOClasesAbstractas
{
    public class Sopa : Comida
    {
        public override void ImprimirComida(string Nombre)
        {
            Console.WriteLine("La {0} es una buena fuente de energia", Nombre);

        }
    }
}
