using System;

namespace Lab2_EstructuraDeDatos
{
    public partial class ListaDoble
    {
        public int? MoverAdelante_Impl()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return null;
            }

            if (actualNavegacion == null)
            {
                actualNavegacion = cabeza;
                if (actualNavegacion == null) return null;
                if (actualNavegacion.Siguiente != null)
                {
                    actualNavegacion = actualNavegacion.Siguiente;
                    return actualNavegacion.Dato;
                }
                Console.WriteLine("No hay un siguiente elemento.");
                return null;
            }

            if (actualNavegacion.Siguiente == null)
            {
                Console.WriteLine("No hay un siguiente elemento.");
                return null;
            }

            actualNavegacion = actualNavegacion.Siguiente;
            return actualNavegacion.Dato;
        }
    }
}
