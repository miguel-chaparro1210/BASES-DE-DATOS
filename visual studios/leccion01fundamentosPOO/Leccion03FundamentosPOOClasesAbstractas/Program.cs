using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion03FundamentosPOOClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comida objComida = new Comida (); // De la clase abstracta no puedo crear objetos 

            Sopa objsopa = new Sopa();
            objsopa.ComidaId = 1;
            objsopa.NombreComida = "sopa de fideos";
            //objsopa.ImprimirComida("sopa");

            Ensalada objensalada = new Ensalada();
            objensalada.ComidaId = 2;
            objensalada.NombreComida = "ensalada de Aguacate";
            //objensalada.ImprimirComida("Aguacate");

            Pavo objpavo = new Pavo();
            objpavo.ComidaId = 3;
            objpavo.NombreComida = "Pavo relleno";
            //objpavo.ImprimirComida("pavo");

            Pay objpay = new Pay();
            objpay.ComidaId = 1;
            objpay.NombreComida = "pay de frutas";
            //objpay.ImprimirComida("pay");

            List<Comida> LstComida = new List<Comida>();

            LstComida.Add(objsopa);
            LstComida.Add(objensalada);
            LstComida.Add(objpavo);
            LstComida.Add(objpay);

            foreach (Comida item in LstComida)
            {
                Console.WriteLine("El ID {0} pertenece a la comida {1}", item.ComidaId , item.NombreComida);
                item.ImprimirComida(item.NombreComida);
            }
            Console.ReadKey();
        }
    }
}
