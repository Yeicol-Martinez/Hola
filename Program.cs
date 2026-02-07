
using Practica_2;
using System;

namespace Practica_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Aplicación Matemática Genérica ===");
            Console.WriteLine("Seleccione el tipo de dato:");
            Console.WriteLine("1. int");
            Console.WriteLine("2. double");
            Console.WriteLine("3. decimal");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    EjecutarAplicacion<int>(int.Parse);
                    break;
                case "2":
                    EjecutarAplicacion<double>(double.Parse);
                    break;
                case "3":
                    EjecutarAplicacion<decimal>(decimal.Parse);
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }

        static void EjecutarAplicacion<T>(Func<string, T> parser)
        {
            ListaNumeros<T> lista = new ListaNumeros<T>();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("\nMenú:");
                Console.WriteLine("1. Agregar número");
                Console.WriteLine("2. Sumar");
                Console.WriteLine("3. Restar");
                Console.WriteLine("4. Multiplicar");
                Console.WriteLine("5. Dividir");
                Console.WriteLine("6. Salir");

                Console.Write("Seleccione una opción: ");
                string opcion = Console.ReadLine();

                try
                {
                    switch (opcion)
                    {
                        case "1":
                            Console.Write("Ingrese un número: ");
                            T numero = parser(Console.ReadLine());
                            lista.AgregarNumero(numero);
                            Console.WriteLine("Número agregado correctamente.");
                            break;

                        case "2":
                            MostrarResultado(lista, Operaciones.Sumar);
                            break;

                        case "3":
                            MostrarResultado(lista, Operaciones.Restar);
                            break;

                        case "4":
                            MostrarResultado(lista, Operaciones.Multiplicar);
                            break;

                        case "5":
                            MostrarResultado(lista, Operaciones.Dividir);
                            break;

                        case "6":
                            continuar = false;
                            break;

                        default:
                            Console.WriteLine("Opción no válida.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Entrada inválida. Ingrese un valor numérico.");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Error: División por cero no permitida.");
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }

        static void MostrarResultado<T>(
            ListaNumeros<T> lista,
            OperacionMatematica<T> operacion)
        {
            T resultado = lista.EjecutarOperacion(operacion);
            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}

