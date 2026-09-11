using System;
namespace Lab2_EstructuraDeDatos
{
	public class ListaDoble
	{
		private NodoDoble cabeza;
        private NodoDoble cola;
        public ListaDoble(NodoDoble cabeza, NodoDoble cola)
		{
			this.cabeza = cabeza;
			this.cola = cola;
		}


		public void agregarFinal(int dato)
		{
			NodoDoble nuevo = new NodoDoble(dato);
			
			if (cabeza == null)
			{
				cabeza = nuevo;
				cola = nuevo;
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
            }
            else
            {
                nuevo.Siguiente = cabeza;
                cabeza.Anterior = nuevo;
                cabeza = nuevo;
            }
        }


    }

}
