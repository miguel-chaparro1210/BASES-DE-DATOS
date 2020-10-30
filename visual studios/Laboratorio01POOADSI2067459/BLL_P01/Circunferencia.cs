using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_P01
{
    public class Circunferencia
    {
        private double radio;

        public Circunferencia()
        {
            this.radio = 0;
        }
        public Circunferencia(double r)
        {
            this.radio = r;
        }

        public void ModificarRadio(double radio)
        {
            if (radio < 0)
            {
                throw new ArgumentException("Valor no permitido");
            }
            else if (radio.GetType()== typeof(double) || radio.GetType() == typeof(int))
            {
                this.radio = radio;
            }
            else
            {
                radio = 0;
            }
        }

        public double ConsultarRadio()
        {
            return this.radio;

        }
        public double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);

        }
        public double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;

        }

    }
}
