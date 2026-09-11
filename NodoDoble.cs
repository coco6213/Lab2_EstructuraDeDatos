using System;
namespace Lab2_EstructuraDeDatos
{
    public class NodoDoble
    {
        public int Dato { get; set; }

        public NodoDoble? Siguiente { get; set; }

        public NodoDoble? Anterior { get; set; }

        public NodoDoble(int dato)
        {
            Dato = dato;
            Siguiente = null;
            Anterior = null;
        }
    }
}