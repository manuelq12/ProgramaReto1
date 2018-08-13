﻿using Libreria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberiaDos
{
    public partial class interfazPrincipal : Form
    {

        private Biblioteca mundo;
        private int indice;
        private int tipo;
        public interfazPrincipal()
        {
            InitializeComponent();
            mundo = new Biblioteca(1000);
            mundo.CargarLibros();
            indice = 0;
            tipo = 0;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void butActualizar_Click(object sender, EventArgs e)
        {
            limpiar limpiarCampos = new limpiar();
            String titulo = txtTitulo.Text;
            String anho = txtAnho.Text;
            String autor = txtAutor.Text;
            String tipo = comboBox1.Text;

            if (titulo == "" || anho == "" || autor == "" || tipo == "")
            {
                MessageBox.Show("Algún campo se encuentra sin llenar");

            }
            else
            {
               // Actualizar libro
            }




        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            limpiar limpiarCampos = new limpiar();

            String titulo = txtTitulo.Text;
            String anho = txtAnho.Text;
            String autor = txtAutor.Text;
            String tipo = comboBox1.Text;

            if (titulo == "" || anho == "" || autor == "" || tipo == "")
            {
                MessageBox.Show("Algún campo se encuentra sin llenar");
            }
            else
            {
                if (tipo == "Físico")
                {
                    //Agregar en el listado de libros fisicos
                    try
                    {
                        bool agregado = mundo.AgregarLibroFisico(titulo, autor, anho, tipo);
                        if (agregado)
                        {
                            MessageBox.Show("Libro físico agregado");
                            limpiarCampos.borrarCampos(this);
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                        limpiarCampos.borrarCampos(this);
                    }

                }
                else
                {
                    //Agregaren el listado de libros digitales
                    try
                    {
                        bool agregado = mundo.AgregarLibroDigital(titulo, autor, anho, tipo);
                        if (agregado)
                        {
                            MessageBox.Show("Libro digital agregado");
                            limpiarCampos.borrarCampos(this);
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                        limpiarCampos.borrarCampos(this);
                    }
                }


            }





        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            limpiar limpiarCampos = new limpiar();

            String titulo = txtTitulo.Text;
            String anho = txtAnho.Text;
            String autor = txtAutor.Text;
            String tipo = comboBox1.Text;


            if (titulo != "" && tipo != "")
            {
                try
                {

                    if (tipo == "Físico")
                    {
                        Console.WriteLine("Paso primer condicional");
                        mundo.EliminarLibroFisico(titulo);
                        Console.WriteLine("Cagada");
                        MessageBox.Show("Libro físico eliminado");
                        limpiarCampos.borrarCampos(this);
                    }
                    else
                    {
                        Console.WriteLine("paso segundo");
                        mundo.EliminarLibroDigital(titulo);
                        MessageBox.Show("Libro digital eliminado");
                        limpiarCampos.borrarCampos(this);
                    }



                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                    limpiarCampos.borrarCampos(this);
                }
            }
            else
            {
                MessageBox.Show("El campo Titulo o Tipo se encuentran sin llenar");
            }





        }
        public void actualizarInfo(String titulo, String autor, String anho, String tipo)
        {
            mundo.actualizarPorcentaje();
            actualizarPorcentaje();
            txtTitulo.Text=titulo;
            txtAnho.Text= anho;
            txtAutor.Text= autor;
            comboBox1.Text= tipo;

        }

        private void interfazPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void butLibrosFisico_Click(object sender, EventArgs e)
        {
            tipo = 0;
        }

        private void butLibrosDigital_Click(object sender, EventArgs e)
        {
            tipo = 1;
        }

        private void butLibrosGeneral_Click(object sender, EventArgs e)
        {
            tipo = 2;
        }
        public void actualizarPorcentaje()
        {
            textBox1.Text = mundo.porcentajeFisicos+"%";
            textBox2.Text = 100-mundo.porcentajeFisicos + "%";
        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            String titulo = txtTitulo.Text;
            String tipo = comboBox1.Text;

            if (tipo == "Físico")
            {
                Libro libro = mundo.BuscarLibroFisico(titulo);
                if (libro==null)
                {
                    MessageBox.Show("El libro no se encuentra en la biblioteca");
                }
                else
                {
                   
                    String tituloL = libro.Titulo;
                    String autor = libro.Autor;
                    String anho = libro.Anho;

                    txtTitulo.Text = tituloL;
                    txtAutor.Text = autor;
                    txtAnho.Text = anho;


                }
            }
            else
            {
                Libro libro = mundo.BuscarLibroOnline(titulo);
                if (libro == null)
                {
                    MessageBox.Show("El libro no se encuentra en la biblioteca");
                }
                else
                {

                    String tituloL = libro.Titulo;
                    String autor = libro.Autor;
                    String anho = libro.Anho;

                    txtTitulo.Text = tituloL;
                    txtAutor.Text = autor;
                    txtAnho.Text = anho;


                }
            }


        }

        private void butSiguiente_Click_1(object sender, EventArgs e)
        {
            try
            {
                indice++;
                int mira = 0;
                if (tipo == 0) mira = mundo.LibrosFisicos.Count;
                else if (tipo == 1) mira = mundo.LibrosOnline.Count;
                else mira = mundo.LibrosFisicos.Count + mundo.LibrosOnline.Count;
                if (indice >= mira) indice = 0;
                else
                {
                    Libro a;
                    if (tipo == 0)
                    {
                        a = mundo.LibrosFisicos[indice];
                    }
                    else if (tipo == 1)
                    {
                        a = mundo.LibrosOnline[indice];
                    }
                    else
                    {
                        List<Libro> fisicos = mundo.LibrosFisicos;
                        List<Libro> online = mundo.LibrosOnline;
                        fisicos.AddRange(online);
                        a = fisicos[indice];
                    }
                    mundo.actualizarPorcentaje();
                    actualizarPorcentaje();
                    actualizarInfo(a.Titulo, a.Autor, a.Anho, a.Tipo);
                }
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }


        }

        private void butAnterior_Click_1(object sender, EventArgs e)
        {
            indice--;
            int mira = 0;
            if (tipo == 0) mira = mundo.LibrosFisicos.Count;
            else if (tipo == 1) mira = mundo.LibrosOnline.Count;
            else mira = mundo.LibrosFisicos.Count + mundo.LibrosOnline.Count;
            if (indice < 0) indice = mira - 1;
            else
            {
                Libro a;
                if (tipo == 0)
                {
                    a = mundo.LibrosFisicos[indice];
                }
                else if (tipo == 1)
                {
                    a = mundo.LibrosOnline[indice];
                }
                else
                {
                    List<Libro> fisicos = mundo.LibrosFisicos;
                    List<Libro> online = mundo.LibrosOnline;
                    fisicos.AddRange(online);
                    a = fisicos[indice];
                }
                mundo.actualizarPorcentaje();
                actualizarPorcentaje();
                actualizarInfo(a.Titulo, a.Autor, a.Anho, a.Tipo);
            }
        }
    }
}
