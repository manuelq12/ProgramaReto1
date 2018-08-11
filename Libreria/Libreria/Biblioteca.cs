using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class Biblioteca
    {
        private Libro[] libros;
        private int index;

        public Biblioteca(int tamanho)
        {
            this.libros = new Libro[tamanho];
            Index = 0;
        }

        public Libro[] Libros { get => libros; set => libros = value; }
        public int Index { get => index; set => index = value; }

        public void AgregarLibro(String titulo, String autor, String anho, int edicion, String tipo)
        {
            if (index <= this.libros.Length - 1)
            {
                Libro agregar = new Libro(titulo, autor, anho, edicion, this.index,tipo );
                this.libros[this.index] = agregar;
                index++;
            }

        }
        public void EliminarLibro(int index)
        {
            if (index > -1 && index < libros.Length)
            {
                libros[index] = null;
            }
        }
        public int BuscarLibro(String titulo)
        {
            int resultado = -1;
            foreach (Libro s in libros)
                if (s.Titulo.Equals(titulo))
                {
                    resultado = s.Index;
                }

            return resultado;

        }
    }

}
