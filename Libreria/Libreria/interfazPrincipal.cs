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
        public interfazPrincipal()
        {
            
            InitializeComponent();
            mundo = new Biblioteca(1000);
            mundo.cargarLibros();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form ventAgenda = new interfazAgendar();
            ventAgenda.Show();
            Visible = false;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

        
            Form ventAdmin = new interfazAdmin();
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
                    bool agregado = mundo.agregarLibroFisico(titulo, autor, anho, edicion, tipo);
                    if (agregado)
                    {
                        MessageBox.Show("Libro Fisico Agregado");
                    }
                }
                catch
                {
                    MessageBox.Show("No se agrego el libro");
                }
            }else{
                try
                {
                bool agregado = mundo.agregarLibroDigital(titulo, autor, anho, edicion, tipo);
                if (agregado)
                {
                    MessageBox.Show("Libro Digital Agregado");
                }
            }
                catch
            {
                MessageBox.Show("No se agrego el libro");
            }
            }
        }
        public void EliminarLibros()
        {

        }

        public void BuscarLibros()
        {

        }

        private void butListadoLibro_Click(object sender, EventArgs e)
        {
            Form ventList = new listadoLibros();
            ventList.Show();
            Visible = false;
        }
    }
}
