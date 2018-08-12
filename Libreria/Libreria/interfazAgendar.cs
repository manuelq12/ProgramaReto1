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
        public interfazAgendar()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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
            limpiar limpiarBox = new limpiar();
            limpiarBox.borrarCampos(this);


            if (checkBoxFisico.Checked == false)
            {
                MessageBox.Show("Solo puedes agendar libros que estan en físico");

             
            }
            else
            {
             
              

            }
        }

        private void checkBoxFisico_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    
    }
}
