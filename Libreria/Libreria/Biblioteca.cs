using System;
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

        public Biblioteca(int tamanho)
        {
            LibrosFisicos = new List<Libro>(tamanho);
            LibrosOnline = new List<Libro>(tamanho);



        }
        private List<Libro> Libros(){
          
            List<Libro> union = LibrosFisicos.Union(LibrosOnline).ToList<Libro>();
            return union;
        }
       
        //Desde aqui 
        //

        public bool AgregarLibroFisico(String titulo, String autor, String anho, int edicion, String tipo)
        {
            bool retorno = true;
            foreach (Libro b in LibrosFisicos)
                if (titulo.Equals(b.Titulo)) throw new Exception("Ya existe dicho libro fisico");
            if (LibrosFisicos.Capacity == LibrosFisicos.Count) throw new Exception("Lista llena");
            Libro a = new Libro(titulo, autor, anho, edicion, 0, tipo);
            LibrosFisicos.Add(a);
            Libros();
            return retorno;
        }
        public bool AgregarLibroDigital(String titulo, String autor, String anho, int edicion, String tipo)
        {
            bool retorno = true;
            foreach (Libro b in LibrosOnline)
                if (titulo.Equals(b.Titulo)) throw new Exception("Ya existe dicho libro fisico");
            if (LibrosOnline.Capacity == LibrosOnline.Count) throw new Exception("Lista llena");
            Libro a = new Libro(titulo, autor, anho, edicion, 0, tipo);
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
                    int num;
                    String nombre;
                    String autor;
                    String anho;
                    Random rnd = new Random();
                    if (prueba.Length > 4)
                    {
                        int contador = 0;
                        string nueva = "";
                        foreach(String a in prueba)
                        {
                            if(contador !=0 || contador< prueba.Length -2)
                            {
                                nueva += a;
                            }
                            contador++;
                        }
                        nombre = nueva;
                    }
                    else
                    {
                        nombre = prueba[1]; 
                    }
                    num = int.Parse(prueba[0]);
                    autor = prueba[2];
                    anho = prueba[3];
                    String tipo= (rnd.Next(0, 6) < 4 ? "Fisico" : "Digital");

                    if (tipo.Equals("Fisico") == true) AgregarLibroFisico(nombre, autor, anho, 0, tipo);
                    else AgregarLibroDigital(nombre, autor, anho, 0, tipo);
                }

                foreach(Libro a in Libros())
                {
                    Console.WriteLine(a.Titulo);
                }
                Console.ReadLine();
                sr.Close();
            }

            catch( Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("a");
            Console.ReadLine();
        }
    }

}
