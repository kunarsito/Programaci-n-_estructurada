using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramacionEstructurada22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadPersonas, edadPersona;
            string nombrePersona;

            // VALIDAR CANTIDAD DE PERSONAS
            Console.Write("Ingresa la cantidad de personas a clasificar: ");
            while (!int.TryParse(Console.ReadLine(), out cantidadPersonas) || cantidadPersonas < 1)
            {
                Console.WriteLine("Valor inválido. solo se permiten ingresar valores >=1.");
                Console.Write("Intenta de nuevo: ");
            }

            if (cantidadPersonas == 1)
            {
                // VALIDAR NOMBRE
                Console.Write("Ingresa el nombre de la persona: ");
                nombrePersona = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(nombrePersona) || !nombrePersona.All(char.IsLetter))
                {
                    Console.WriteLine("Nombre inválido. Solo se permiten letras.");
                    Console.Write("Intenta de nuevo: ");
                    nombrePersona = Console.ReadLine();
                }

                // VALIDAR EDAD
                Console.Write("Ingresa la edad de la persona: ");
                while (!int.TryParse(Console.ReadLine(), out edadPersona) || edadPersona < 0)
                {
                    Console.WriteLine("Edad inválida. Ingresa un número válido.");
                    Console.Write("Intenta de nuevo: ");
                }

                if (edadPersona >= 18)
                
                    Console.WriteLine(nombrePersona + " es mayor de edad");
                else
                    Console.WriteLine(nombrePersona + " es menor de edad");
                
            }
            else
            {
                List<string> nombresPersonasMayores = new List<string>();
                List<int> edadesPersonasMayores = new List<int>();

                List<string> nombresPersonasMenores = new List<string>();
                List<int> edadesPersonasMenores = new List<int>();

                for (int i = 1; i <= cantidadPersonas; i++)
                {
                    // VALIDAR NOMBRE
                    Console.Write("Ingresa el nombre de la persona " + i + ": ");
                    nombrePersona = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(nombrePersona) || !nombrePersona.All(char.IsLetter))
                    {
                        Console.WriteLine("Nombre inválido. Solo se permiten letras.");
                        Console.Write("Intenta de nuevo: ");
                        nombrePersona = Console.ReadLine();
                    }

                    // VALIDAR EDAD
                    Console.Write("Ingresa la edad de la persona " + i + ": ");
                    while (!int.TryParse(Console.ReadLine(), out edadPersona) || edadPersona < 0)
                    {
                        Console.WriteLine("Edad inválida. Ingresa un número válido.");
                        Console.Write("Intenta de nuevo: ");
                    }

                    if (edadPersona >= 18)
                    {
                        nombresPersonasMayores.Add(nombrePersona);
                        edadesPersonasMayores.Add(edadPersona);
                    }
                    else
                    {
                        nombresPersonasMenores.Add(nombrePersona);
                        edadesPersonasMenores.Add(edadPersona);
                    }
                }

                Console.WriteLine("\n-- Personas Mayores --\n");
                for (int i = 0; i < nombresPersonasMayores.Count; i++)
                {
                    Console.WriteLine(nombresPersonasMayores[i] + " - " + edadesPersonasMayores[i]);
                }

                Console.WriteLine("\n-- Personas Menores --\n");
                for (int i = 0; i < nombresPersonasMenores.Count; i++)
                {
                    Console.WriteLine(nombresPersonasMenores[i] + " - " + edadesPersonasMenores[i]);
                }
            }
        }
    }
}
