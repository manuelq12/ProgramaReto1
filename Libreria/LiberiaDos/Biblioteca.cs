﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    class Biblioteca
    {
        public const String ruta = "../../Resources/DatosLibros.csv";
        public List<Libro> LibrosFisicos { get; set; }
        public List<Libro> LibrosOnline { get; set; }
        public double porcentajeFisicos{ get; set; }
        public int numLibros { get; set; }

    public Biblioteca(int tamanho)
        {
            LibrosFisicos = new List<Libro>(tamanho);
            LibrosOnline = new List<Libro>(tamanho);
            porcentajeFisicos = 0;
            numLibros = 0;
        }
        private List<Libro> Libros(){
          
            List<Libro> union = LibrosFisicos.Union(LibrosOnline).ToList<Libro>();
            return union;
        }
        public bool AgregarLibroFisico(String titulo, String autor, String anho, String tipo)
        {
            bool retorno = true;
            foreach (Libro b in LibrosFisicos)
                if (titulo.Equals(b.Titulo)) throw new Exception("Ya existe dicho libro fisico");
            if (LibrosFisicos.Capacity == LibrosFisicos.Count) throw new Exception("Lista llena");
            Libro a = new Libro(titulo, autor, anho, tipo);
            LibrosFisicos.Add(a);
            Libros();
            return retorno;
        }
        public bool AgregarLibroDigital(String titulo, String autor, String anho, String tipo)
        {
            bool retorno = true;
            foreach (Libro b in LibrosOnline)
                if (titulo.Equals(b.Titulo)) throw new Exception("Ya existe dicho libro fisico");
            if (LibrosOnline.Capacity == LibrosOnline.Count) throw new Exception("Lista llena");
            Libro a = new Libro(titulo, autor, anho, tipo);
            LibrosOnline.Add(a);
            Libros();
            return retorno;
        }
        public Libro BuscarLibroFisico(String nombre)
        {
            Libro buscar = null;
            foreach (Libro b in LibrosFisicos)
                if (nombre.Equals(b.Titulo)) buscar = b;
            return buscar;
        }
        public Libro BuscarLibroOnline(String nombre)
        {
            Libro buscar = null;
            foreach (Libro b in LibrosOnline)
                if (nombre.Equals(b.Titulo)) buscar = b;
            return buscar;
        }
        public void actualizarLibro(Libro a, int tipo)
        {
            int contador = 0;
            if(tipo == 0)
            {
                for( int i=0; i < LibrosFisicos.Count; i++)
                {
                    if (a.Titulo.Equals(LibrosFisicos[i])) LibrosFisicos[i] = a;
                }
                   
            }
            else if (tipo == 1)
            {
                foreach (Libro b in LibrosOnline)
                    if (a.Titulo.Equals(b.Titulo)) LibrosOnline[contador] = a;
                    contador++;
            }
            else
            {
                foreach (Libro b in LibrosFisicos)
                    if (a.Titulo.Equals(b.Titulo)) LibrosFisicos[contador] = a;
                    contador++;
                contador = 0;
                foreach (Libro b in LibrosOnline)
                    if (a.Titulo.Equals(b.Titulo)) LibrosOnline[contador] = a;
                    contador++;
            }
        }
        
        public void EliminarLibroDigital (String nombre){
            foreach(Libro b in LibrosOnline)
                if(nombre.Equals(b.Titulo))LibrosOnline.Remove(b);
            Libros();
        }

         public void EliminarLibroFisico (String nombre){
            foreach(Libro b in LibrosFisicos)
                if(nombre.Equals(b.Titulo))LibrosFisicos.Remove(b);
            Libros();
            }
        public void CargarLibros()
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader(ruta);
                line = sr.ReadLine();
                while ((line = sr.ReadLine()) != null)
                {
                    String[] prueba = line.Split(',');
                    String nombre="";
                    String autor = "";
                    String anho = "";
                    Random rnd = new Random();
                    if (prueba.Length > 4)
                    {
                        int contador = 0;
                        string nueva = "";
                        foreach(String a in prueba)
                        {
                            if(contador!=0 || contador< prueba.Length -2)
                            {
                                nueva += a;
                            }
                            contador++;
                        }
                        nombre = nueva;
                    }
                    else
                    {
                        if( 1 <prueba.Length) nombre = prueba[1];
                    }

                    if( 2<prueba.Length ) autor = prueba[2];
                    if (3<prueba.Length) anho = prueba[3];
                    String tipo= (rnd.Next(0, 6) < 3 ? "Fisico" : "Digital");
                    if (!nombre.Equals(""))
                    {
                    if (tipo.Equals("Fisico") == true) AgregarLibroFisico(nombre, autor, anho, tipo);
                    else AgregarLibroDigital(nombre, autor, anho, tipo);
                    }
                }
                sr.Close();
            }

            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        public void actualizarPorcentaje()
        {
            numLibros = LibrosOnline.Count + LibrosFisicos.Count;
            porcentajeFisicos = ((double)LibrosFisicos.Count / numLibros) * 100;
        }
    }


}
