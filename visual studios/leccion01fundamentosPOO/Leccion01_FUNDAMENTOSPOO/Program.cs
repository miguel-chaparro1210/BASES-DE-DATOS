using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion01_FUNDAMENTOSPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            //crear un objeto de programación de la clase Perro 
            // forma #1

            Perro objPerro1 = new Perro(); //crea una instancia (new) de la clase perro

            objPerro1.Id = 1;
            objPerro1.Nombre = "Dante";
            objPerro1.Raza = "Pitbull";
            objPerro1.Color = "Cafe";

            //forma #2

            Perro objPerro2 = new Perro()
            {
                Id= 2, 
                Nombre= "Peter",
                Raza = "Boxer",
                Color = "negro" 
            };


            Perro objPerro3 = new Perro()
            {
                Id = 3,
                Nombre = "Zeus",
                Raza = "Pitbull",
                Color = "negro"
            };

            Perro objPerro4 = new Perro()
            {
                Id = 4,
                Nombre = "Tomas",
                Raza = "Boxer",
                Color = "Amarillo"
            };

            List<Perro> perros = new List<Perro>();

            //Agregando miembro a la colección 
            perros.Add(objPerro1);
            perros.Add(objPerro2);
            perros.Add(objPerro3);
            perros.Add(objPerro4);

            //optimizamos el acceso a los datos de la colección
            foreach (Perro item in perros)
            {
                Console.WriteLine("El perro {0} llamado {1} de Raza {2} y su color es : {3}",
                    item.Id,
                    item.Nombre,
                    item.Raza,
                    item.Color
                    );
            }



            //Accedemos a los comportamientos 

            objPerro1.Comer();

            objPerro2.Dormir();

            Console.WriteLine("eL Perro N°, {0} llamado {1} come: ", objPerro1.Id, objPerro1.Nombre);
                objPerro1.Comer();

            Console.WriteLine("eL Perro N°, {0} llamado {1} cuando duerme hace el siguiente sonido : ", objPerro2.Id, objPerro2.Nombre);
            objPerro1.Dormir();

            //Accedemos al comportamiento

            Estudiantes objEstudiantes1 = new Estudiantes()
            {
                ID = 1000215308,
                Nombres = "Miguel Chaparro",
                Edad = 18 ,
                Email = "machaparro80@misena.edu.co"
            };

            Estudiantes objEstudiantes2 = new Estudiantes();

            objEstudiantes2.ID = 1030549748;
            objEstudiantes2.Nombres = "Johana Blanco";
            objEstudiantes2.Edad = 32;
            objEstudiantes2.Email = "ljblanco84@misena.edu.co";

            Estudiantes objEstudiantes3 = new Estudiantes();

            objEstudiantes3.ID = 1030549999;
            objEstudiantes3.Nombres = "Leidy Cortez";
            objEstudiantes3.Edad = 34;
            objEstudiantes3.Email = "ljcortez84@misena.edu.co";

            //Dos o mas objetos del mismo tipo conforman una colección 
            //A travez de una lista defino una colección
            List<Estudiantes> estudiantes = new List<Estudiantes>();

            //Agregando miembro a la colección 
            estudiantes.Add(objEstudiantes1);
            estudiantes.Add(objEstudiantes2);
            estudiantes.Add(objEstudiantes3);

            //optimizamos el acceso a los datos de la colección
            foreach(Estudiantes item in estudiantes)
            {
                Console.WriteLine("El estudiante {0} llamado {1} tiene {2} años y su correo es : {3}",
                    item.ID,
                    item.Nombres,
                    item.Edad,
                    item.Email
                    );
            }

            Student objstudent1 = new Student()
            {
                clavematricula = "c-123",
                nombre = "Bruno Lopez",
                grado = 3,
                grupo = "a",
                promedio = (int)87.4,
            };

            Student objstudent2 = new Student()
            {
                clavematricula = "d-153",
                nombre = "Lionel Alvarez",
                grado = 5,
                grupo = "b",
                promedio = (int)88.2,
            };

            Student objstudent3 = new Student()
            {
                clavematricula = "f-189",
                nombre = "Francisco Maturana",
                grado = 4,
                grupo = "c",
                promedio = (int)82.7,
            };

            Student objstudent4 = new Student()
            {
                clavematricula = "m-433",
                nombre = "Carlos Valderrama",
                grado = 2,
                grupo = "a",
                promedio = (int)90.4,
            };

            List<Student> estudents = new List<Student>();

            estudents.Add(objstudent1);
            estudents.Add(objstudent2);
            estudents.Add(objstudent3);
            estudents.Add(objstudent4);

            foreach (Student item in estudents)
            {
                Console.WriteLine("La clave de matricula {0} pertenece al nombre  {1} del grado {2} y grupo {3}  su promedio es : {4}",
                    item.clavematricula,
                    item.nombre,
                    item.grado,
                    item.grupo,
                    item.promedio
                    );
            }

            //Objeto de la clase producto

            Producto objproducto = new Producto();

            objproducto.ProductoId = 1;
            objproducto.Nombre = "salchichas";
            objproducto.Valor = 1500;
            int cantidad = 3;

            double resultado = objproducto.CalcularPrecio(cantidad);

            Console.WriteLine("las {0} unidades de {1} es: {2} ", cantidad, objproducto.Nombre, resultado);

            //segundo objeto producto

            Producto objProducto2 = new Producto(2, "Arroz", 2500);
            int cantidad2 = 5;

            double resultado2 = objProducto2.CalcularPrecio(cantidad2);

            Console.WriteLine("las {0} unidades de {1} es: {2} ", cantidad2, objProducto2.Nombre, resultado2);

            Console.ReadKey();

        }
    }
}


