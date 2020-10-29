using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion03FundamentosPOOClasesAbstractas
{
    public class Ensalada : Comida
    {
        public override void ImprimirComida(string Nombre)
        {
            Console.WriteLine("La {0} es buena para la salud", Nombre);
        }
    }
}
