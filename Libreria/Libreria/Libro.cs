using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public class Libro
    {
        

        public const string FISICO = "Fisico";
        public const string DIGITAL = "Digitial";

        // hola xd lol
        private String titulo;
        private String autor;
        private String anho;
        private int edicion;
        private int index;
        private String tipo;

        public Libro(String pTitulo, String pAutor, String pAño, int pEdicion, int pIndex, String tipo)
        {
            titulo = pTitulo;
            autor = pAutor;
            anho = pAño;
            edicion = pEdicion;
            index = pIndex;
            this.Tipo = tipo;
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

        public string Tipo { get => tipo; set => tipo = value; }

        public String toString()
        {
            return "[ " + titulo + ", " + autor + ", " + anho + ", " + edicion + " ]";
        }

    }

}
