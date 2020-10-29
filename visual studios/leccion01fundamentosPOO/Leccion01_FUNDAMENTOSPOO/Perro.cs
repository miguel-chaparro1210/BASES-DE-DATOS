using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion01_FUNDAMENTOSPOO
{
    class Perro
    {
        //propiedades
        public int Id  { get; set; }
        public string Nombre { get; set; }

        public string Raza { get; set; }

        public string Color { get; set; }

        //Metodos
        public void Ladrar()
        {
            Console.WriteLine("Guau Guau");
        }

        public void Comer()
        {
            Console.WriteLine("chomp chomp");
        }

        public void Dormir()
        {
            Console.WriteLine("zzzzzzzz");
        }
    }
}
