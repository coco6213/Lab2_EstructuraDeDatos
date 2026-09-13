using System;

namespace Lab2_EstructuraDeDatos
{
    public class Historial
    {
        private NodoDoble? actual;

        public Historial()
        {
          
            actual = new NodoDoble(0);
        }

        public void Agregar(int opcion)
        {
            if (actual == null)
            {
                actual = new NodoDoble(opcion);
                return;
            }

            // Evita duplicar la opción si ya estamos posicionados en ella
            if (actual.Dato == opcion) return;

            NodoDoble nuevo = new NodoDoble(opcion);

            actual.Siguiente = nuevo;
            nuevo.Anterior = actual;
            actual = nuevo;
        }

        public int? Retroceder()
        {
            if (actual == null || actual.Anterior == null)
            {
                Console.WriteLine("\n[!] No hay una opción anterior (ya estás en el Inicio).");
                return null;
            }

            actual = actual.Anterior;
            return actual.Dato;
        }

        public int? Avanzar()
        {
            if (actual == null || actual.Siguiente == null)
            {
                Console.WriteLine("\n[!] No hay una opción siguiente.");
                return null;
            }

            actual = actual.Siguiente;
            return actual.Dato;
        }

    }
}