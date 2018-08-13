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
    public partial class listadoLibros : Form
    {
        private interfazPrincipal principal;
        public listadoLibros(interfazPrincipal a)
        {
            principal = a;
            InitializeComponent();
        }

       

        private void butLibrosFisicos_Click(object sender, EventArgs e)
        {           
            tabla.DataSource = null;
            tabla.DataSource = principal.darLibrosFisicos();
            tabla.Refresh();
        }

        private void listadoLibros_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ventPrincipal = new interfazPrincipal();
            ventPrincipal.Show();
            ventPrincipal.Visible = true;
            this.Visible = false;
        }

        private void tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void butLibros_Click(object sender, EventArgs e)
        {
            tabla.DataSource = null;
            tabla.DataSource = principal.darLibros();
        }

        private void butLibrosDigital_Click(object sender, EventArgs e)
        {
            tabla.DataSource = null;
            tabla.DataSource = principal.darLibrosOnline();
        }
    }
}
