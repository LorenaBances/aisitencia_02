using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aisitencia_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int maxPersonas = 50;
            int contador = 0;

            Console.Clear();

            Console.WriteLine("Ingrese un número máximo de personas: " + maxPersonas);
            Console.WriteLine("========================================");
            Console.WriteLine("El número máximo establecido es de " + maxPersonas + " personas, presione una tecla para comenzar a contar...");
            Console.ReadKey();

            Console.Clear();

            while (true)
            {
                Console.WriteLine("=================================");
                Console.WriteLine("| Asistentes actuales | " + contador);
                Console.WriteLine("| Aforo | " + ((double)contador / maxPersonas * 100).ToString("0.0") + "%");
                Console.WriteLine("| Máximo | " + maxPersonas + " personas");
                Console.WriteLine("=================================");

                Console.WriteLine("Presione");
                Console.WriteLine("[ i ] si ingresa una persona");
                Console.WriteLine("[ s ] si sale una persona");
                Console.WriteLine("[ x ] para terminar");

                Console.Write("Ingrese su opción: ");

                string opcion = Console.ReadLine().ToLower();

                switch (opcion)
                {
                    case "i":
                        if (contador < maxPersonas)
                        {
                            contador++;
                            Console.WriteLine("Persona ingresada exitosamente: ");
                        }
                        else
                        {

                            Console.WriteLine("Se ha alcanzado el número máximo de personas: ");
                        }
                        break;

                    case "s":
                        if (contador > 0)
                        {
                            contador--;
                            Console.WriteLine("Persona retirada exitosamente: ");
                        }
                        else
                        {
                            Console.WriteLine("No hay personas para retirar: ");
                        }
                        break;

                    case "x":
                        Console.WriteLine("Terminando el programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, ingrese una opción válida (i, s o x).");
                        break;                     
                }

                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
            }
        }
    }
}
