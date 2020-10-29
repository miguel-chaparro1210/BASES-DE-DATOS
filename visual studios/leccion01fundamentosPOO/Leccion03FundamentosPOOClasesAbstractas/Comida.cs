using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion03FundamentosPOOClasesAbstractas
{
    public abstract class Comida
    {
        public int ComidaId { get; set; }        //puede definir campos, propiedades y metodos convencionales.
        public string NombreComida { get; set; }

        public abstract void ImprimirComida(String Nombre);   //puede definir campos, propiedades y metodos abstractos.
    }
}
