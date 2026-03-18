using System;

namespace tareita
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int cantidadPersonas = obtenerCantidadPersonas();

            string[] nombres = new string[cantidadPersonas];
            int[] edades = new int[cantidadPersonas];

            LlenarDatos(nombres, edades, 0);

            while (PreguntarSiAgregar())
            {
                int cantidadExtra = obtenerCantidadPersonas();

                int tamanoActual = nombres.Length;
                int nuevoTamano = tamanoActual + cantidadExtra;

                string[] nuevosNombres = new string[nuevoTamano];
                int[] nuevasEdades = new int[nuevoTamano];

                for (int i = 0; i < tamanoActual; i++)
                {
                    nuevosNombres[i] = nombres[i];
                    nuevasEdades[i] = edades[i];
                }

                nombres = nuevosNombres;
                edades = nuevasEdades;

                LlenarDatos(nombres, edades, tamanoActual);
            }
            
            MostrarResultados(nombres, edades);
        }

        static void LlenarDatos(string[] nombres, int[] edades, int inicio)
        {
            for (int i = inicio; i < nombres.Length; i++)
            {
                Console.WriteLine($"\nPersona #{i + 1}");
                Console.Write("Nombre : ");
                nombres[i] = Console.ReadLine();
                edades[i] = ObtenerEdad();
            }
        }

        static bool PreguntarSiAgregar()
        {
            Console.Write("\n ¿Desea registrar mas personas? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();
            return respuesta == "s";
        }

        static int obtenerCantidadPersonas()
        {
            int cantidad;
            while (true)
            {
                Console.Write("Ingrese la cantidad de personas (minimo 1): ");
                // Corrección: Se agregó la lectura del input que faltaba
                string input = Console.ReadLine();

                if (int.TryParse(input, out cantidad) && cantidad >= 1)
                {
                    return cantidad;
                }
                else
                {
                    Console.WriteLine("Entrada invalida, debe ser un numero entero mayor o igual a 1.\n");
                }
            }
        }

        static int ObtenerEdad()
        {
            int edad;
            while (true)
            {
                Console.Write("Edad: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out edad) && edad >= 0)
                {
                    return edad;
                }
                else
                {
                    Console.WriteLine("Edad invalida. Ingrese un numero entero valido. ");
                }
            }
        }

        static void MostrarResultados(string[] nombres, int[] edades)
        {
            Console.WriteLine("\n==================================");
            Console.WriteLine("\nLista General: ");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{nombres[i]} - {edades[i]} anos");
            }

            Console.WriteLine("\n Mayores de edad: ");
            for (int i = 0; i < nombres.Length; i++)
            {
                if (edades[i] >= 18)
                    Console.WriteLine($"{nombres[i]} - {edades[i]} anos");
            }

            Console.WriteLine("\n Menores de edad: ");
            for (int i = 0; i < nombres.Length; i++)
            {
                if (edades[i] < 18)
                    Console.WriteLine($"{nombres[i]} - {edades[i]} anos");
            }

            Console.WriteLine("\n Programa finalizado ");
        }
    }
}



