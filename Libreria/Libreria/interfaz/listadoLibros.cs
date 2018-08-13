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
            butSelectA.Enabled = true;
            butEliminarDigitales.Enabled = false;
            butEliminarFisicos.Enabled = true;
            refrescarFisicos();
        }

        private void listadoLibros_Load(object sender, EventArgs e)
        {
            butEliminarDigitales.Enabled = false;
            butEliminarFisicos.Enabled = false;
            butSelectA.Enabled = false;
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


        private void butLibrosDigital_Click(object sender, EventArgs e)
        {
            butEliminarDigitales.Enabled = true;
            butEliminarFisicos.Enabled = false;
            refrescarDigitales();
            butSelectA.Enabled = false;
            
            
        }

        private void butAgendar_Click(object sender, EventArgs e)
        {
            Form agendar = new interfazAgendar(principal);
            agendar.Visible = true;
            agendar.Show();
            this.Visible = false;
        }

        private void butSelectA_Click(object sender, EventArgs e)
        {
            int fila = tabla.CurrentRow.Index;
            Libro p = principal.BuscarEnTablaFisicos(fila);
            principal.EliminarLibros(p.Titulo, p.Tipo);
            p.Tipo = Libro.digital;
            principal.AgregarLibros(p.Titulo, p.Autor, p.Anho, p.Tipo);
            refrescarFisicos();
            
        }

        private void refrescarFisicos()
        {
            tabla.DataSource = null;
            tabla.DataSource = principal.DarLibrosFisicos();
            tabla.Refresh();
        }
        private void refrescarDigitales()
        {
            tabla.DataSource = null;
            tabla.DataSource = principal.darLibrosOnline();
            tabla.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fila = tabla.CurrentRow.Index;
            Libro p = principal.BuscarEnTablaFisicos(fila);
            principal.EliminarLibros(p.Titulo, p.Tipo);
            refrescarFisicos();

        }

        private void butEliminarDigitales_Click(object sender, EventArgs e)
        {
            int fila = tabla.CurrentRow.Index;
            Libro p = principal.BuscarEnTablaDigitales(fila);
            principal.EliminarLibros(p.Titulo, p.Tipo);
            refrescarDigitales();
        }

       
    }
}
