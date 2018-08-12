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
        public const String ruta = "~/Resources/DatosLibros.csv";
        private Libro[] libros;
        private int index;

        public List<Libro> LibrosFisicos { get; set; }
        public List<Libro> LibrosOnline { get; set; }

        public Biblioteca(int tamanho)
        {
            LibrosFisicos = new List<Libro>(tamanho);
            LibrosOnline = new List<Libro>(tamanho);

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

        //Desde aqui 

        public bool agregarLibroFisico(String titulo, String autor, String anho, int edicion, String tipo)
        {
            bool retorno = true;
            foreach (Libro b in LibrosFisicos)
                if (titulo.Equals(b.Titulo)) throw new Exception("Ya existe dicho libro fisico");
            if (LibrosFisicos.Capacity == LibrosFisicos.Count) throw new Exception("Lista llena");
            Libro a = new Libro(titulo, autor, anho, edicion, 0, tipo);
            LibrosFisicos.Add(a);
            return retorno;
        }
        public bool agregarLibroDigital(String titulo, String autor, String anho, int edicion, String tipo)
        {
            bool retorno = true;
            foreach (Libro b in LibrosOnline)
                if (titulo.Equals(b.Titulo)) throw new Exception("Ya existe dicho libro fisico");
            if (LibrosOnline.Capacity == LibrosOnline.Count) throw new Exception("Lista llena");
            Libro a = new Libro(titulo, autor, anho, edicion, 0, tipo);
            LibrosOnline.Add(a);
            return retorno;
        }
        public Libro buscarLibroFisico(String nombre)
        {
            Libro buscar = null;
            foreach (Libro b in LibrosFisicos)
                if (nombre.Equals(b.Titulo)) buscar = b;
            return buscar;
        }
        public Libro buscarLibroOnline(String nombre)
        {
            Libro buscar = null;
            foreach (Libro b in LibrosOnline)
                if (nombre.Equals(b.Titulo)) buscar = b;
            return buscar;
        }
        
        public void EliminarLibroDigital (String nombre){
            foreach(Libro b in LibrosOnline)
                if(nombre.Equals(b.Titulo))LibrosOnline.Remove(b);
        }

         public void EliminarLibroFisico (String nombre){
            foreach(Libro b in LibrosFisico)
                if(nombre.Equals(b.Titulo))LibrosFisico.Remove(b);
            }
        public void cargarLibros()
        {
            Console.WriteLine("a");
            String line;
            try
            {
                StreamReader sr = new StreamReader(ruta);
                line = "";
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
                    this.AgregarLibro(nombre, autor, anho, 0, tipo);
                    if (tipo.Equals("Fisico") == true) agregarLibroFisico(nombre, autor, anho, 0, tipo);
                    else agregarLibroDigital(nombre, autor, anho, 0, tipo);
                }
                Console.WriteLine("Hola");
                foreach(Libro a in Libros)
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
