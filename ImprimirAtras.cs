using System;

namespace Lab2_EstructuraDeDatos
{
    public partial class ListaDoble
    {
        public void ImprimirAtras()
        {
            if (cola == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            NodoDoble? actual = cola;
            Console.Write("Lista (atrás): ");
            while (actual != null)
            {
                Console.Write(actual.Dato + " ");
                actual = actual.Anterior;
            }
            Console.WriteLine();
        }
    }
}
