using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEdades
{
    internal class Lista
    {
        private Nodo Inicio;
        private Nodo Fin;

        public Lista()
        {
            Inicio = null;
            Fin = null;
        }

        public Nodo GetInicio()
        {
            return Inicio;
        }

        public Nodo GetFin()
        {
            return Fin;
        }

        public void AgregarEdad(int Edad)
        {
            Nodo mNodo = new Nodo();
            mNodo.SetEdad(Edad);
            if (Inicio == null)
            {
                Inicio = mNodo;
                Fin = mNodo;
            }
            else
            {
                Fin.SetSiguiente(mNodo);
                mNodo.SetAnterior(Fin);
                Fin = mNodo;
            }
        }
    }
}
