using System;

namespace CalculadoraFunciones
{
    class Program
    {
        // Variables globales para almacenar los valores ingresados
        static double numero1;
        static double numero2;

        static void Main(string[] args)
        {
            bool continuar = true;
            
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== CALCULADORA CON FUNCIONES ===\n");
                
                // Solicitar los valores al usuario
                Console.Write("Ingrese el primer número: ");
                while (!double.TryParse(Console.ReadLine(), out numero1))
                {
                    Console.Write("Por favor, ingrese un número válido: ");
                }

                Console.Write("Ingrese el segundo número: ");
                while (!double.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.Write("Por favor, ingrese un número válido: ");
                }

                // Llamar al procedimiento que muestra el menú y ejecuta la operación
                MostrarMenuYEjecutar();

                // Preguntar si desea continuar
                Console.Write("\n¿Desea realizar otro cálculo? (s/n): ");
                string respuesta = Console.ReadLine().ToLnower();
                continuar = (respuesta == "s" || respuesta == "si");
            }
            
            Console.WriteLine("\n¡Gracias por usar la calculadora!");
        }

        // Procedimiento que muestra el menú y ejecuta la función correspondiente
        static void MostrarMenuYEjecutar()
        {
            int opcion;
            
            Console.WriteLine("\n--- TIPO DE CÁLCULO ---");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.Write("Seleccione una opción (1-3): ");

            // Validar la entrada del usuario
            while (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
            {
                Console.Write("Opción inválida. Por favor, seleccione 1, 2 o 3: ");
            }

            // Ejecutar la función según la opción seleccionada
            Console.WriteLine("\n--- RESULTADO ---");
            
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"La suma de {numero1} + {numero2} = {Sumar()}");
                    break;
                case 2:
                    Console.WriteLine($"La resta de {numero1} - {numero2} = {Restar()}");
                    break;
                case 3:
                    Console.WriteLine($"La multiplicación de {numero1} * {numero2} = {Multiplicar()}");
                    break;
            }
        }

        // Función para sumar
        static double Sumar()
        {
            return numero1 + numero2;
        }

        // Función para restar
        static double Restar()
        {
            return numero1 - numero2;
        }

        // Función para multiplicar
        static double Multiplicar()
        {
            return numero1 * numero2;
        }
    }
}