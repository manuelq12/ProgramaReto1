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
        public interfazPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form ventAgenda = new interfazAgendar();
            ventAgenda.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form ventAdmin = new interfazAdmin();
            ventAdmin.Show();

        }
    }
}
