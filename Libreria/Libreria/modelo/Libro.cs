using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    public class Libro
    {
        

        public const string fisico = "Físico";
        public const string digital = "Digital";

        // hola xd lol
        private String titulo;
        private String autor;
        private String anho;
        private String tipo;

        public Libro(String pTitulo, String pAutor, String pAño, String tipo)
        {
            titulo = pTitulo;
            autor = pAutor;
            anho = pAño;
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

        public string Tipo { get => tipo; set => tipo = value; }

        public String ToString2()
        {
            return "[ " + titulo + ", " + autor + ", " + anho+  " ]";
        }

    }

}
