using System;

namespace Lab2_EstructuraDeDatos
{
    class Program
    {
        static ListaDoble lista = new ListaDoble();

        static void Main(string[] args)
        {
            Run();
        }

        static void Run()
        {
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("        REGISTRO Y NAVEGACIÓN       ");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Agregar al inicio");
                Console.WriteLine("2. Agregar al final");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Navegar");
                Console.WriteLine("5. Salir");
                Console.WriteLine("====================================");
                Console.Write("Registra la opción requerida: ");
                string entrada = Console.ReadLine() ?? "";

                if (!int.TryParse(entrada, out opcion))
                    opcion = 0;

                switch (opcion)
                {
                    case 1:
                        AgregarInicio();
                        break;
                    case 2:
                        AgregarFinal();
                        break;
                    case 3:
                        EliminarMenu();
                        break;
                    case 4:
                        NavegarMenu();
                        break;
                    case 5:
                        Console.WriteLine("\nGracias por su preferencia");
                        break;
                    default:
                        Console.WriteLine("\nOpción inválida.");
                        Pausar();
                        break;
                }

            } while (opcion != 5);
        }

        static void AgregarInicio()
        {
            Console.Write("Ingrese el número a agregar al inicio: ");
            if (int.TryParse(Console.ReadLine() ?? "", out int datoInicio))
            {
                lista.agregarInicio(datoInicio);
                Console.WriteLine("Elemento agregado al inicio.");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            Pausar();
        }

        static void AgregarFinal()
        {
            Console.Write("Ingrese el número a agregar al final: ");
            if (int.TryParse(Console.ReadLine() ?? "", out int datoFin))
            {
                lista.agregarFinal(datoFin);
                Console.WriteLine("Elemento agregado al final.");
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            Pausar();
        }

        static void EliminarMenu()
        {
            Console.Clear();
            Console.WriteLine(" Eliminar - Elija opción:");
            Console.WriteLine("1. Eliminar inicio");
            Console.WriteLine("2. Eliminar fin");
            Console.WriteLine("3. Eliminar por posición");
            Console.Write("Seleccione: ");
            string entradaDel = Console.ReadLine() ?? "";
            if (int.TryParse(entradaDel, out int sub))
            {
                switch (sub)
                {
                    case 1:
                        lista.EliminarInicio();
                        break;
                    case 2:
                        lista.EliminarFin();
                        break;
                    case 3:
                        lista.EliminarPorPosicionInteractiva();
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            Pausar();
        }

        static void NavegarMenu()
        {
            bool salirNavegacion = false;

            while (!salirNavegacion)
            {
                Console.Clear();
                int? actual = lista.ObtenerActual();
                if (actual.HasValue)
                    Console.WriteLine($"Actual: {actual.Value}");
                else
                    Console.WriteLine("No hay elemento seleccionado. Usa 'Ir hacia adelante' o 'Ir hacia atrás' para iniciar.");

                Console.WriteLine("==== NAVEGACIÓN ====");
                Console.WriteLine("1. Ir hacia adelante");
                Console.WriteLine("2. Ir hacia atrás");
                Console.WriteLine("3. Salir navegación");
                Console.Write("Seleccione: ");
                string nav = Console.ReadLine() ?? "";
                if (!int.TryParse(nav, out int navOpc)) navOpc = 0;
                switch (navOpc)
                {
                    case 1:
                        int? a = lista.MoverAdelante_Impl();
                        if (a.HasValue)
                            Console.WriteLine($"Actual: {a.Value}");
                        Pausar();
                        break;
                    case 2:
                        int? b = lista.MoverAtras_Impl();
                        if (b.HasValue)
                            Console.WriteLine($"Actual: {b.Value}");
                        Pausar();
                        break;
                    case 3:
                        salirNavegacion = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        Pausar();
                        break;
                }
            }
        }

        static void Pausar()
        {
            Console.WriteLine("\nPresione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}
