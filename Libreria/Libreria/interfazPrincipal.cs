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
