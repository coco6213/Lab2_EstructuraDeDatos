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
                        historial.Agregar(opcion);
                        break;

                    case 2:
                        historial.Agregar(opcion);
                        break;

                    case 3:
                        historial.Agregar(opcion);
                        break;

                    case 4:
                        historial.Agregar(opcion);
                        break;

                    case 5:
                        historial.Agregar(opcion);
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
            static void EjecutarOpcion(int opcion)
            {
                switch (opcion)
                {
                   
                    case 1:
                        
                        break;
                    case 2:
                        
                        break;
                    case 3:
                       
                        break;
                    case 4:
                       
                        break;
                    case 5:
                       
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