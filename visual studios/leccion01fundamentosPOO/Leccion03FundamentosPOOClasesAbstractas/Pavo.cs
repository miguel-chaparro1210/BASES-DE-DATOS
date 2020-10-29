using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion03FundamentosPOOClasesAbstractas
{
    public class Pavo : Comida
    {
        public override void ImprimirComida(string Nombre)
        {
            Console.WriteLine("El exceso de {0} es malo para la salud", Nombre);
        }
    }
}
