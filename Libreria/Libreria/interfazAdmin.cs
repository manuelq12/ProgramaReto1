﻿using System;
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
    public partial class interfazAdmin : Form
    {
        public interfazAdmin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void butVolver_Click(object sender, EventArgs e)
        {
            Form ventInicio = new interfazPrincipal();

            ventInicio.Visible = true;
            ventInicio.Show();
            this.Visible = false;
            
        }
    }
}
