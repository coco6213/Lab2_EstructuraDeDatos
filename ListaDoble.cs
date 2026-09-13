using System;
namespace Lab2_EstructuraDeDatos
{
	public partial class ListaDoble
	{
		private NodoDoble? cabeza;
		private NodoDoble? cola;

		private NodoDoble? actualNavegacion;

		public ListaDoble()
		{
			cabeza = null;
			cola = null;
			actualNavegacion = null;
		}


		public void agregarFinal(int dato)
		{
			NodoDoble nuevo = new NodoDoble(dato);
			
			if (cabeza == null)
			{
				cabeza = nuevo;
				cola = nuevo;
				actualNavegacion = cabeza;
			}
			else
			{
				cola.Siguiente = nuevo;
				nuevo.Anterior = cola;
				cola = nuevo;
			}
		}

		
		public void agregarInicio(int dato)
        {
            NodoDoble nuevo = new NodoDoble(dato);

            if (cabeza == null)
            {
                cabeza = nuevo;
                cola = nuevo;
				actualNavegacion = cabeza;
            }
            else
            {
                nuevo.Siguiente = cabeza;
                cabeza.Anterior = nuevo;
                cabeza = nuevo;
            }
        }

		public int? ObtenerActual()
		{
			if (actualNavegacion == null && cabeza != null)
			{
				actualNavegacion = cabeza;
				return actualNavegacion.Dato;
			}
			return actualNavegacion?.Dato;
		}

    }

}
