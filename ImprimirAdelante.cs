using System;

namespace Lab2_EstructuraDeDatos
{
    public partial class ListaDoble
    {
        public void ImprimirAdelante()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            NodoDoble? actual = cabeza;
            Console.Write("Lista (adelante): ");
            while (actual != null)
            {
                Console.Write(actual.Dato + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
    }
}
