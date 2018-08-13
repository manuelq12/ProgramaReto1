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
    public partial class interfazAgendar : Form
    {

        private interfazPrincipal conexionInterfazPrincipal;



        public interfazAgendar(interfazPrincipal principal)
        {
            conexionInterfazPrincipal = principal;
            InitializeComponent();

            

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
            
            if (txtTitulo.Text == "" || txtAnho.Text == "" || txtAutor.Text == "")
            {
                MessageBox.Show("Algún campo se encuentra sin llenar");
            }
            if (checkBoxFisico.Checked == false)
            {
                MessageBox.Show("Solo puedes agendar libros que estan en físico");
               
             
            }
            else
            {
             
                conexionInterfazPrincipal.AgregarLibros(txtTitulo.Text, txtAutor.Text, txtAnho.Text, Libro.fisico); 
            }
            limpiar limpiarBox = new limpiar();
            limpiarBox.borrarCampos(this);

        }

        private void butListado_Click(object sender, EventArgs e)
        {
            Form listado = new interfazAgendar(conexionInterfazPrincipal);
            listado.Visible = true;
            listado.Show();
            this.Visible = false;
        }
    }
}
