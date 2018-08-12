using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Libreria
{
    public class Libro
    {
        public const string fisico = "Fisico";
        public const string digital = "Digital";

        private String titulo;
        private String autor;
        private String anho;
        private String tipo;

        public Libro(String pTitulo, String pAutor, String pAño, String tipo)
        {
            Titulo = pTitulo;
            Autor = pAutor;
            Anho = pAño;
            this.Tipo = tipo;
        }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string Anho { get => anho; set => anho = value; }
        public string Tipo { get => tipo; set => tipo = value; }
    }

}
