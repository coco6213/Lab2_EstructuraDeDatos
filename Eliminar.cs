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

            NodoDoble? eliminado = cabeza;

            if (cabeza == cola)
            {
                cabeza = null;
                cola = null;
                Console.WriteLine("Elemento eliminado (inicio). La lista quedó vacía.");
                return;
            }

            NodoDoble? antiguaCabeza = cabeza;
            cabeza = cabeza!.Siguiente;
            if (cabeza != null)
                cabeza.Anterior = null;

            if (actualNavegacion == antiguaCabeza)
                actualNavegacion = cabeza;

            Console.WriteLine("Elemento eliminado del inicio.");
        }

        public void EliminarFin()
        {
            if (cola == null)
            {
                Console.WriteLine("La lista está vacía. No hay nada que eliminar.");
                return;
            }

            NodoDoble? antiguaCola = cola;

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

            if (actualNavegacion == antiguaCola)
                actualNavegacion = cola;

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

            NodoDoble? ant = actual.Anterior;
            NodoDoble? sig = actual.Siguiente;

            if (ant != null)
                ant.Siguiente = sig;
            if (sig != null)
                sig.Anterior = ant;

            if (actualNavegacion == actual)
            {
                if (sig != null)
                    actualNavegacion = sig;
                else
                    actualNavegacion = cabeza;
            }

            Console.WriteLine($"Elemento en posición {posicion} eliminado.");
        }
        public void ImprimirConIndices()
        {
            if (cabeza == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            NodoDoble? actual = cabeza;
            int indice = 1;
            Console.Write("Lista con posiciones: ");
            while (actual != null)
            {
                Console.Write($"{indice}:{actual.Dato} ");
                actual = actual.Siguiente;
                indice++;
            }
            Console.WriteLine();
        }

        public void EliminarPorPosicionInteractiva()
        {
            ImprimirConIndices();

            Console.Write("Ingrese la posición a eliminar (1 = primero): ");
            string entrada = Console.ReadLine() ?? "";
            if (int.TryParse(entrada, out int pos))
            {
                EliminarPorPosicion(pos);
            }
            else
            {
                Console.WriteLine("Posición inválida.");
            }
        }
    }
}
