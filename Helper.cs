using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaN1
{
    public class Helper
    {
        public static void Llenar(Coleccionable c)
        {
            Random ran = new Random();

            for (int i = 0; i < 20; i++)
            {
                c.Agregar(new Numero(ran.Next(1, 10000)));
            }
        }
        public static void Informar(Coleccionable c)
        {
            Console.WriteLine("Cantidad de elementos: " + c.Cuantos());
            Console.WriteLine("Elemento Maximo: " + c.Maximo());
            Console.WriteLine("Elemento Minimo: " + c.Minimo());
            try
            {
                //Error de Casteo

                /*Console.Write("Ingrese un numero para buscar en la coleccion: ");
                if (int.TryParse(Console.ReadLine(), out int numeroIngresado))
                {
                    Numero numeroBuscado = new Numero(numeroIngresado);
                    if (c.Contiene(numeroBuscado))
                    {
                        Console.WriteLine("El elemento leido esta en la coleccion.");
                    }
                    else
                    {
                        Console.WriteLine("El elemento leido no esta en la coleccion.");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no valida.");
                }*/
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void LlenarAlumnos(Coleccionable c)
        {
            Random random = new Random();
            string[] nombres = { "Ana", "Luis", "Carlos", "Marta", "Pedro", "Sofia", "Juan", "Maria", "Ramona", "Jose", "Claudio" };
            for (int i = 0; i < 20; i++)
            {
                string nombre = nombres[random.Next(nombres.Length)];
                int dni = random.Next(10000000, 99999999);
                int legajo = random.Next(1000, 9999);
                double promedio = random.NextDouble() * 10;
                c.Agregar(new Alumno(legajo, promedio, nombre, dni));
            }
        }
    }
}
