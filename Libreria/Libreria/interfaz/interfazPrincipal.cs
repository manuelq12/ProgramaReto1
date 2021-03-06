﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria
{
    
    public partial class interfazPrincipal : Form
    {
        private Biblioteca mundo;
        private listadoLibros panelListado;
        private Form ventAgenda;
        private Form ventAdmin;
        internal object darLibrosFisicos;

        public interfazPrincipal()
        {
            
            InitializeComponent();
            mundo = new Biblioteca(1000);
            ventAgenda = new interfazAgendar(this);
            ventAdmin = new interfazAdmin(this);
            panelListado = new listadoLibros(this);
       

        }

        private void button1_Click(object sender, EventArgs e)
        {


            ventAgenda.Show();
            Visible = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ventAdmin.Show();
            Visible = false; 
        }

        private void interfazPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void interfazPrincipal_Load_1(object sender, EventArgs e)
        {
            mundo.CargarLibros();
        }

        private void butCerrarTodo_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Application.Exit();

        }

        public void AgregarLibros(string titulo, string autor, string anho, string tipo)
        {
            if (tipo.Equals("Físico"))
            {
                try
                {
                    bool agregado = mundo.AgregarLibroFisico(titulo, autor, anho, tipo);
                    if (agregado)
                    {
                        MessageBox.Show("Libro Fisico Agregado");
                    }
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }else{
                try
                {
                bool agregado = mundo.AgregarLibroDigital(titulo, autor, anho, tipo);
                if (agregado)
                {
                    MessageBox.Show("Libro Digital Agregado");
                }
            }
                catch(Exception e)
            {
                    MessageBox.Show(e.Message);
            }
            }
        }
        public void EliminarLibros(string titulo, string tipo)
        {
            try
            {
                if (tipo.Equals(Libro.fisico))
                {
                    mundo.EliminarLibroFisico(titulo);
                    MessageBox.Show("Libro Fisico Eliminado");
                }
                else
                {
                    mundo.EliminarLibroDigital(titulo);
                    MessageBox.Show("Libro Digital Eliminado");
                }
            }catch(Exception e){
                MessageBox.Show("Se ha eliminado correctamente el libro");
            }
        }

        public Libro BuscarLibros(String titulo, String tipo)
        {
            
           if (tipo.Equals("Físico"))
            {
                Libro encontrado = mundo.BuscarLibroFisico(titulo);

                if (encontrado == null)
                {
                    MessageBox.Show("El libro no se encuentra en la bibliteca");
                    return null;
                }
                else
                {
                    return encontrado;
                }

            }
            else
            {
                Libro encontrado = mundo.BuscarLibroOnline(titulo);

                if (encontrado==null)
                {
                    MessageBox.Show("El libro no se encuentra en la bliblioteca");
                    return null;
                }
                else
                {
                    return encontrado;
                }
            }

        }

        public Libro BuscarEnTablaFisicos(int index)
        {
            List<Libro> buscar = mundo.LibrosFisicos;
            Libro p = buscar.ElementAtOrDefault(index);
            return p;
        }
        public Libro BuscarEnTablaDigitales(int index)
        {
            List<Libro> buscar = mundo.LibrosOnline;
            Libro p = buscar.ElementAtOrDefault(index);
            return p;
        }

        private void butListadoLibro_Click(object sender, EventArgs e)
        {
            panelListado.Show();
            Visible = false;
        }
        public List<Libro> darLibros()
        {
            List<Libro> a = mundo.LibrosFisicos;
            List<Libro> b = mundo.LibrosOnline;
            a.AddRange(b);
            return a;
        }
        public List<Libro> DarLibrosFisicos()
        {
            List<Libro> a = mundo.LibrosFisicos;
            return a;
        }
        public List<Libro> darLibrosOnline()
        {
            List<Libro> a = mundo.LibrosOnline;
            return a;
        }

        private void labCentro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
