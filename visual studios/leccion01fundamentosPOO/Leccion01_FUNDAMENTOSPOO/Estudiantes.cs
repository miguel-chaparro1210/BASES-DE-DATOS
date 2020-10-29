using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion01_FUNDAMENTOSPOO
{
    //Clase concreta con encapsulamiento 
    class Estudiantes
    {

        private int id;   // Atributo (campo) privado
        private string nombre;
        private int edad;
        public string email;

        public int ID    // Propiedad publica que encapsula el atributo privado
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombres
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Edad
        {
            get { return edad; }
            set {
                if ((value > 0) && (value < 100))
                {
                    edad = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException ("valor fuera de rango");
                }   
            }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
