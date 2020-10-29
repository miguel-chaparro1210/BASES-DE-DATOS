using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion01_FUNDAMENTOSPOO
{
    class Student
    //propiedades
    {
        public string clavematricula { get; set; }
        public string nombre { get; set; }
        public int grado { get; set; }
        public string grupo { get; set; }
        public int promedio { get; set; }

        //Metodos

        public void Leer()
        {
            Console.WriteLine("El estudiante lee POO");
        }

        public void investigar()
        {
            Console.WriteLine("El estudiante investiga POO");
        }
    }
}
