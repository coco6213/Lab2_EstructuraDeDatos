using System;

namespace Lab2_EstructuraDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDoble lista = new ListaDoble();
            Historial historial = new Historial(); 
            int opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("====================================");
                Console.WriteLine("       --------------------         ");
                Console.WriteLine("====================================");
                Console.WriteLine("1. Agregar al inicio");
                Console.WriteLine("2. Agregar al final");
                Console.WriteLine("3. Eliminar");
                Console.WriteLine("4. Imprimir adelante");
                Console.WriteLine("5. Imprimir atrás");
                Console.WriteLine("6. Ir hacia atrás (navegar)");
                Console.WriteLine("7. Ir hacia adelante (navegar)");
                Console.WriteLine("8. Salir");
                Console.WriteLine("====================================");
                Console.Write("Registra la opción requerida: ");
                string entrada = Console.ReadLine() ?? "";

                if (!int.TryParse(entrada, out opcion))
                    opcion = 0;

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el número a agregar al inicio: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out int datoInicio))
                        {
                            lista.agregarInicio(datoInicio);
                            Console.WriteLine("Elemento agregado al inicio.");
                            historial.Agregar(opcion);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        Pausar();
                        break;

                    case 2:
                        Console.Write("Ingrese el número a agregar al final: ");
                        if (int.TryParse(Console.ReadLine() ?? "", out int datoFin))
                        {
                            lista.agregarFinal(datoFin);
                            Console.WriteLine("Elemento agregado al final.");
                            historial.Agregar(opcion);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        Pausar();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("3. Eliminar - Elija opción:");
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
                                    Console.Write("Ingrese la posición a eliminar (1 = primero): ");
                                    if (int.TryParse(Console.ReadLine() ?? "", out int pos))
                                    {
                                        lista.EliminarPorPosicion(pos);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Posición inválida.");
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opción inválida.");
                                    break;
                            }
                            historial.Agregar(opcion);
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida.");
                        }
                        Pausar();
                        break;

                    case 4:
                        lista.ImprimirAdelante();
                        historial.Agregar(opcion);
                        Pausar();
                        break;

                    case 5:
                        lista.ImprimirAtras();
                        historial.Agregar(opcion);
                        Pausar();
                        break;

                    case 6:
                        int? anterior = historial.Retroceder();
                        if (anterior.HasValue)
                            EjecutarOpcion(anterior.Value, lista);
                        else
                            Pausar();
                        break;


                    case 7:
                        int? siguiente = historial.Avanzar();
                        if (siguiente.HasValue)
                            EjecutarOpcion(siguiente.Value, lista);
                        else
                            Pausar();
                        break;

                    case 8:
                        Console.WriteLine("\nGracias por su preferencia");
                        break;


                    default:
                        Console.WriteLine("\nOpción inválida.");
                        Pausar();
                        break;
                }


                }
             while (opcion != 8);
        }


            // Sobrecarga que acepta la lista para permitir re-ejecución desde Historial
            static void EjecutarOpcion(int opcion, ListaDoble lista)
            {
                switch (opcion)
                {
                    case 4:
                        lista.ImprimirAdelante();
                        Pausar();
                        break;
                    case 5:
                        lista.ImprimirAtras();
                        Pausar();
                        break;
                    default:
                        Console.WriteLine("Esta acción no se puede reproducir al navegar (requiere entrada del usuario).");
                        Pausar();
                        break;
                }
            }

            static void Pausar()
        {
            Console.WriteLine("\nPresione ENTER para continuar...");
            Console.ReadLine();
        }
    }
}