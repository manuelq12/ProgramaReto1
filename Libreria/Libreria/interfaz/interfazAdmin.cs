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
    public partial class interfazAdmin : Form
    {

        private interfazPrincipal conexionPrincipal;


        public interfazAdmin(interfazPrincipal principal)
        {
            conexionPrincipal = principal;
            InitializeComponent();

        }


        


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            Form ventInicio = new interfazPrincipal();

            ventInicio.Visible = true;
            ventInicio.Show();
            this.Visible = false;
            
        }

        private void butAgregar_Click(object sender, EventArgs e)
        {

            String titulo = txtTitulo.Text;
            String anho = txtAnho.Text;
            String autor = txtAutor.Text;
            String tipo = comboBoxTipo.Text;
            

            if (titulo == "" || anho == "" || autor == "" || tipo == "")
            {
                MessageBox.Show("Algún campo se encuentra sin llenar");
            }
            else
            {

                if (tipo == "Físico")
                {
                    conexionPrincipal.AgregarLibros(titulo, autor, anho, "Físico");

                }
                else
                {
                    conexionPrincipal.AgregarLibros(titulo, autor, anho, "Digital");
                    
                }

            }


            limpiar limparTxt = new limpiar();
            limparTxt.borrarCampos(this);


        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
            if (!comboBoxTipo.Text.Equals(""))
            {
                conexionPrincipal.EliminarLibros(txtTitulo.Text, comboBoxTipo.Text);

            }else{
                MessageBox.Show("Debe escoger el tipo del libro que desea eliminar");
            }
           

            limpiar limpiarTxt = new limpiar();
            limpiarTxt.borrarCampos(this);
            
        }




        private void butActualizar_Click(object sender, EventArgs e)
        {

            String titulo = txtTitulo.Text;
            String anho = txtAnho.Text;
            String autor = txtAutor.Text;
            String tipo = comboBoxTipo.Text;
      
        

                if (titulo == "" || anho == "" || autor == "" || tipo == "" )
                {
                    MessageBox.Show("Algún campo se encuentra sin llenar");
                }
                else
                {

                Libro libro = conexionPrincipal.BuscarLibros(titulo, tipo);
                if ( libro== null) MessageBox.Show("No se encuentra el libro solicitado");
                else
                {
                    conexionPrincipal.EliminarLibros(txtTitulo.Text, comboBoxTipo.Text);
                    if (tipo == "Físico")
                    {
                        conexionPrincipal.AgregarLibros(titulo, autor, anho, "Físico");

                    }
                    else
                    {
                        conexionPrincipal.AgregarLibros(titulo, autor, anho, "Digital");

                    }
                    MessageBox.Show("Se actualizó el libro correctamente");
                }


                }


            limpiar limparTxt = new limpiar();
            limparTxt.borrarCampos(this);



        }

        private void butBuscar_Click(object sender, EventArgs e)
        {

            String titulo = txtTitulo.Text;
            String tipo = comboBoxTipo.Text;

            if (titulo=="" || tipo=="")
            {
                MessageBox.Show("Por favor ingrese el título y el tipo (Físico o Digital)");
            }
            else
            {
                Libro libro = conexionPrincipal.BuscarLibros(titulo,tipo);

                String tituloL = libro.Titulo;
                String autor = libro.Autor;
                String anho = libro.Anho;
 
                txtTitulo.Text = tituloL;
                txtAutor.Text = autor;
                txtAnho.Text = anho;



            }



        }
    }
}
