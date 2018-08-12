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
        public listadoLibros()
        {
            InitializeComponent();
        }

       

        private void butLibrosFisicos_Click(object sender, EventArgs e)
        {

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
    }
}
