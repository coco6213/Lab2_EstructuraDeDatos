using System;

namespace Lab2_EstructuraDeDatos
{
    public partial class ListaDoble
    {
        public void EliminarInicio()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía. No hay nada que eliminar.");
                return;
            }

            if (cabeza == cola)
            {
                // Un solo nodo
                cabeza = null;
                cola = null;
                Console.WriteLine("Elemento eliminado (inicio). La lista quedó vacía.");
                return;
            }

            cabeza = cabeza!.Siguiente;
            if (cabeza != null)
                cabeza.Anterior = null;

            Console.WriteLine("Elemento eliminado del inicio.");
        }

        public void EliminarFin()
        {
            if (cola == null)
            {
                Console.WriteLine("La lista está vacía. No hay nada que eliminar.");
                return;
            }

            if (cabeza == cola)
            {
                cabeza = null;
                cola = null;
                Console.WriteLine("Elemento eliminado (fin). La lista quedó vacía.");
                return;
            }

            cola = cola!.Anterior;
            if (cola != null)
                cola.Siguiente = null;

            Console.WriteLine("Elemento eliminado del final.");
        }

        public void EliminarPorPosicion(int posicion)
        {
            if (posicion <= 0)
            {
                Console.WriteLine("Posición inválida. Debe ser >= 1.");
                return;
            }

            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (posicion == 1)
            {
                EliminarInicio();
                return;
            }

            NodoDoble? actual = cabeza;
            int indice = 1;

            while (actual != null && indice < posicion)
            {
                actual = actual.Siguiente;
                indice++;
            }

            if (actual == null)
            {
                Console.WriteLine("Posición fuera de rango.");
                return;
            }

            if (actual == cola)
            {
                EliminarFin();
                return;
            }

            // Conectar anterior con siguiente
            NodoDoble? ant = actual.Anterior;
            NodoDoble? sig = actual.Siguiente;

            if (ant != null)
                ant.Siguiente = sig;
            if (sig != null)
                sig.Anterior = ant;

            Console.WriteLine($"Elemento en posición {posicion} eliminado.");
        }
    }
}
