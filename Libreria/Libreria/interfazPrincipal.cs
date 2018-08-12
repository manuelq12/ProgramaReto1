using System;
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

        public interfazPrincipal()
        {
            
            InitializeComponent();
            mundo = new Biblioteca(1000);
            panelListado = new listadoLibros(this);
            mundo.CargarLibros();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form ventAgenda = new interfazAgendar(this);
            ventAgenda.Show();
            Visible = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        
            Form ventAdmin = new interfazAdmin(this);
            ventAdmin.Show();
            Visible = false; 
        }

        private void interfazPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void interfazPrincipal_Load_1(object sender, EventArgs e)
        {
            
        }

        private void butCerrarTodo_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Application.Exit();

        }

        public void AgregarLibros(string titulo, string autor, string anho, int edicion, string tipo)
        {
            if (tipo.Equals("fisico"))
            {
                try
                {
                    bool agregado = mundo.AgregarLibroFisico(titulo, autor, anho, edicion, tipo);
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
                bool agregado = mundo.AgregarLibroDigital(titulo, autor, anho, edicion, tipo);
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
        public void EliminarLibros()
        {
            
        }

        public void BuscarLibros(String titulo, String tipo)
        {
            if (tipo.Equals("Físico"))
            {
                   
            }
            else
            {

            }
        }

        public void actualizarLibro()
        {

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
        public List<Libro> darLibrosFisicos()
        {
            List<Libro> a = mundo.LibrosFisicos;
            return a;
        }
        public List<Libro> darLibrosOnline()
        {
            List<Libro> a = mundo.LibrosOnline;
            return a;
        }
    }
}
