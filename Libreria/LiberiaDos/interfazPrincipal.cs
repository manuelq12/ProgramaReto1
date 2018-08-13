using Libreria;
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

        public interfazPrincipal()
        {

            InitializeComponent();
            mundo = new Biblioteca(1000);
            mundo.CargarLibros();
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

                if (tipo == "Físico")
                {

                    Libro libro = mundo.BuscarLibroFisico(titulo);
                    if (libro ==null)
                    {
                        MessageBox.Show("No se encuentra el libro solicitado");
                    }
                    else
                    {
                        mundo.EliminarLibroFisico(titulo);
                        mundo.AgregarLibroFisico(titulo,autor,anho,tipo);
                        MessageBox.Show("Se actualizo el libro correctamente");
                    }
                }
                else
                {
                    Libro libro = mundo.BuscarLibroOnline(titulo);
                    if (libro==null)
                    {
                        MessageBox.Show("No se encuentra el libro solicitado");
                    }
                    else
                    {
                        mundo.EliminarLibroDigital(titulo);
                        mundo.AgregarLibroDigital(titulo, autor, anho, tipo);
                        MessageBox.Show("Se actualizó el libro correctamente");
                    }
                }


            }




        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
            limpiar limpiarCampos = new limpiar();

            String titulo = txtTitulo.Text;
            String anho = txtAnho.Text;
            String autor = txtAutor.Text;
            String tipo = comboBox1.Text;

           if (titulo==""||anho==""||autor==""||tipo=="")
            {
                MessageBox.Show("Algún campo se encuentra sin llenar");
            }
            else
            {
                if (tipo=="Físico")
                {
                    //Agregar en el listado de libros fisicos
                    try
                    {
                        bool agregado = mundo.AgregarLibroFisico(titulo,autor,anho,tipo);
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


            if (titulo!="" && tipo!="")
            {
                try
                {

                    if (tipo == "Físico")
                    {
                        mundo.EliminarLibroFisico(titulo);
                        MessageBox.Show("Libro físico eliminado");
                        limpiarCampos.borrarCampos(this);
                    }
                    else
                    {
                        mundo.EliminarLibroDigital(titulo);
                        MessageBox.Show("Libro digital eliminado");
                        limpiarCampos.borrarCampos(this);
                    }



                }
                catch (Exception a)
                {
                    MessageBox.Show("MierDAAAAAAA");
                    limpiarCampos.borrarCampos(this);
                }
            }
            else
            {
                MessageBox.Show("El campo Titulo o Tipo se encuentran sin llenar");
            }

           



        }
    }
}
