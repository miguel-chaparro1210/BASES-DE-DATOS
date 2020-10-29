using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion01_FUNDAMENTOSPOO
{
    public class Producto
    {
        private int productoId; //campo de la clase con modificador de acceso "privado"

        private string nombre; // campo

        private double valor;


        // propiedades autoimplementadas
        public string Nombre { get => nombre; set => nombre = value; }
        public int ProductoId { get => productoId; set => productoId = value; }
        public double Valor { get => valor; set => valor = value; }

        //Constructor (metodo especial) ctor + tab + tab
        public Producto()
        {
            this.ProductoId = 0;
            this.Nombre = "";
            this.Valor = 0.0; // usamos el constructor para inizializar un objeto
        }

        public Producto(int productoId, string Nombre, double Valor)
        {
            this.ProductoId = ProductoId;
            this.Nombre = Nombre;
            this.Valor = Valor;
        }

        //Acción 
        public double CalcularPrecio(int cantidad)
        {
            return Valor * cantidad;
        }
        ~Producto()     //metodo especial destructor
        {
                
        }
    }
}

