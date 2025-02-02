using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEdades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista mLista = new Lista();
            Nodo mNodo;
            int edadMayor = int.MinValue;
            int edadMenor = int.MaxValue;

            // Agregando 5 edades
            mLista.AgregarEdad(25);
            mLista.AgregarEdad(18);
            mLista.AgregarEdad(35);
            mLista.AgregarEdad(42);
            mLista.AgregarEdad(29);

            Console.WriteLine("Edades:");
            mNodo = mLista.GetInicio();
            while (mNodo != null)
            {
                int edadActual = mNodo.GetEdad();
                Console.WriteLine(edadActual);

                // Encontrar edad mayor y menor
                if (edadActual > edadMayor)
                    edadMayor = edadActual;
                if (edadActual < edadMenor)
                    edadMenor = edadActual;

                mNodo = mNodo.GetSiguiente();
            }

            Console.WriteLine("Edad Mayor: " + edadMayor);
            Console.WriteLine("Edad Menor: " + edadMenor);

            Console.ReadKey();
        }
    }
}