using BLL_P01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL_WindowsFormsApp_Punto01
{
    public partial class Form1 : Form
    {
        Circunferencia objMoneda;
        Circunferencia objRueda;

        int objeto = 0;
        string nombreobjeto = null;
        public Form1()
        {
            objMoneda = new Circunferencia(1.4);
            objRueda = new Circunferencia(10.2);
            InitializeComponent();
        }
        private void buttonCapturarRadio_Click(object sender, EventArgs e)
        {
            try
            {

                if (radioButtonMoneda.Checked == true || radioButtonRueda.Checked == true)
                {
                    if (radioButtonRueda.Checked)
                    {
                        objeto = 1;
                        nombreobjeto = "Rueda";
                    }
                    else if (radioButtonMoneda.Checked)
                    {
                        objeto = 2;
                        nombreobjeto = "Moneda";
                    }
                    else
                    {
                        objeto = 0;
                        nombreobjeto = "No selecciono objeto";
                    }
                    buttonCalcularArea.Enabled = true;
                    buttonCalcularPerimetro.Enabled = true;
                }
                else
                {
                    throw new InvalidOperationException("Operación invalida. Debe selecionar un objeto");
                }
            }
            catch (Exception ex)
            {
                labelNotificaciones.Text = ex.Message;
            }

        }
        private void buttonCalcularArea_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            if (objeto == 1)
            {
                objRueda.ModificarRadio(Convert.ToDouble(textBoxRegistrodevalor.Text));
                resultado = objRueda.CalcularArea();
            }
            else if (objeto == 2)
            {
                objMoneda.ModificarRadio(Convert.ToDouble(textBoxRegistrodevalor.Text));
                resultado = objMoneda.CalcularArea();
            }
            string mensaje = "El area de objeto " + nombreobjeto + " es; " + resultado;
            string titulo = "Cerrar ventana";
            MessageBoxButtons objbuttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, objbuttons, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }
        private void buttonCalcularPerimetro_Click(object sender, EventArgs e)
        {
            double resultado = 0;
            if (objeto == 1)
            {
                objRueda.ModificarRadio(Convert.ToDouble(textBoxRegistrodevalor.Text));
                resultado = objRueda.CalcularPerimetro();
            }
            else if (objeto == 2)
            {
                objMoneda.ModificarRadio(Convert.ToDouble(textBoxRegistrodevalor.Text));
                resultado = objMoneda.CalcularPerimetro();
            }
            string mensaje = "El perimetro del objeto " + nombreobjeto + " es; " + resultado;
            string titulo = "Cerrar ventana";
            MessageBoxButtons objbuttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(mensaje, titulo, objbuttons, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }

        }
        private void buttonSalir_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Quiere salir de la aplicación?";
            string titulo = "Cerrar ventana";
            MessageBoxButtons objbuttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(mensaje, titulo, objbuttons, MessageBoxIcon.Information);
            if (result == DialogResult.Abort)
            {
                this.Close();
            }
            else if (result == DialogResult.Retry)
            {

            }
            else
            {

            }
        }
    }
}
