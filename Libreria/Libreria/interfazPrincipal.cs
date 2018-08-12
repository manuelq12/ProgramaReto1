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

            Form ventAgenda = new interfazAgendar(this);
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
        public void AgregarLibroFisico(String titulo, String autor, String anho, int edicion, String tip){
            mundo.agregarLibroFisico(titulo, autor, anho, edicion, tip);
            MessageBox.Show("Se agrego correctamente");
        }
        public void AgregarLibroDigital(String titulo, String autor, String anho, int edicion, String tip)
        {
            mundo.agregarLibroDigital(titulo, autor, anho, edicion, tip);
            Console.WriteLine("se agrego");
            MessageBox.Show("Se agrego correctamente");
        }
        private void butCerrarTodo_Click(object sender, EventArgs e)
        {

            this.Dispose();
            Application.Exit();

        }

        public void agregarLibros()
        {

        }

        public void eliminarLibros()
        {

        }

        public void buscarLibros()
        {

        }



    }
}
