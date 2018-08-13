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

        }

        private void butAgregar_Click(object sender, EventArgs e)
        {
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
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
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
                        }
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }


            }





        }

        private void butEliminar_Click(object sender, EventArgs e)
        {
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
                    }
                    else
                    {
                        mundo.EliminarLibroDigital(titulo);
                        MessageBox.Show("Libro digital eliminado");

                    }



                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else
            {
                MessageBox.Show("El campo Titulo o Tipo se encuentran sin llenar");
            }

           



        }
    }
}
