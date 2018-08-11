using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public class Libro
    {
        private String titulo;
        private String autor;
        private String anho;
        private int edicion;
        private int index;

        public Libro(String pTitulo, String pAutor, String pAño, int pEdicion, int pIndex)
        {
            titulo = pTitulo;
            autor = pAutor;
            anho = pAño;
            edicion = pEdicion;
            index = pIndex;
        }

        public String Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }
        public String Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public String Anho
        {
            get
            {
                return anho;
            }
            set
            {
                anho = value;
            }
        }
        public int Edicion
        {
            get
            {
                return edicion;
            }
            set
            {
                edicion = value;
            }
        }
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public String toString()
        {
            return "[ " + titulo + ", " + autor + ", " + anho + ", " + edicion + " ]";
        }

    }

}
