using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEdades
{
    internal class Nodo
    {
        private int Edad;
        private Nodo Siguiente;
        private Nodo Anterior;

        public Nodo()
        {
            Edad = 0;
            Siguiente = null;
            Anterior = null;
        }

        public void SetEdad(int edad)
        {
            this.Edad = edad;
        }

        public void SetSiguiente(Nodo Siguiente)
        {
            this.Siguiente = Siguiente;
        }

        public int GetEdad()
        {
            return this.Edad;
        }

        public Nodo GetSiguiente()
        {
            return this.Siguiente;
        }

        public void SetAnterior(Nodo Anterior)
        {
            this.Anterior = Anterior;
        }

        public Nodo GetAnterior()
        {
            return this.Anterior;
        }
    }
}
