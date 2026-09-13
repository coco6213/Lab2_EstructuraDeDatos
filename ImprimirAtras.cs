using System;

namespace Lab2_EstructuraDeDatos
{
    public partial class ListaDoble
    {

        public int? MoverAtras_Impl()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return null;
            }

            if (actualNavegacion == null)
            {
                actualNavegacion = cola;
                if (actualNavegacion == null) return null;
                if (actualNavegacion.Anterior != null)
                {
                    actualNavegacion = actualNavegacion.Anterior;
                    return actualNavegacion.Dato;
                }
                Console.WriteLine("No hay un elemento anterior.");
                return null;
            }

            if (actualNavegacion.Anterior == null)
            {
                Console.WriteLine("No hay un elemento anterior.");
                return null;
            }

            actualNavegacion = actualNavegacion.Anterior;
            return actualNavegacion.Dato;
        }
    }
}
