﻿namespace Libreria
{
    partial class interfazAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtAnho = new System.Windows.Forms.TextBox();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.butBuscar = new System.Windows.Forms.Button();
            this.butAgregar = new System.Windows.Forms.Button();
            this.butEliminar = new System.Windows.Forms.Button();
            this.butVolver = new System.Windows.Forms.Button();
            this.butActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(220, 148);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(187, 42);
            this.txtTitulo.TabIndex = 2;
            this.txtTitulo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "Autor";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(84, 364);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 35);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tipo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(220, 219);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(187, 42);
            this.txtAutor.TabIndex = 8;
            // 
            // txtAnho
            // 
            this.txtAnho.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnho.Location = new System.Drawing.Point(220, 286);
            this.txtAnho.Name = "txtAnho";
            this.txtAnho.Size = new System.Drawing.Size(187, 42);
            this.txtAnho.TabIndex = 9;
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Físico",
            "Digital"});
            this.comboBoxTipo.Location = new System.Drawing.Point(220, 361);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(187, 43);
            this.comboBoxTipo.TabIndex = 12;
            // 
            // butBuscar
            // 
            this.butBuscar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butBuscar.Location = new System.Drawing.Point(463, 151);
            this.butBuscar.Name = "butBuscar";
            this.butBuscar.Size = new System.Drawing.Size(138, 41);
            this.butBuscar.TabIndex = 13;
            this.butBuscar.Text = "Buscar";
            this.butBuscar.UseVisualStyleBackColor = true;
            this.butBuscar.Click += new System.EventHandler(this.butBuscar_Click);
            // 
            // butAgregar
            // 
            this.butAgregar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAgregar.Location = new System.Drawing.Point(79, 459);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(138, 49);
            this.butAgregar.TabIndex = 14;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // butEliminar
            // 
            this.butEliminar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminar.Location = new System.Drawing.Point(256, 459);
            this.butEliminar.Name = "butEliminar";
            this.butEliminar.Size = new System.Drawing.Size(138, 49);
            this.butEliminar.TabIndex = 15;
            this.butEliminar.Text = "Eliminar";
            this.butEliminar.UseVisualStyleBackColor = true;
            this.butEliminar.Click += new System.EventHandler(this.butEliminar_Click);
            // 
            // butVolver
            // 
            this.butVolver.BackColor = System.Drawing.Color.Transparent;
            this.butVolver.BackgroundImage = global::Libreria.Properties.Resources.volver2;
            this.butVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butVolver.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butVolver.ForeColor = System.Drawing.Color.Transparent;
            this.butVolver.Location = new System.Drawing.Point(22, 576);
            this.butVolver.Name = "butVolver";
            this.butVolver.Size = new System.Drawing.Size(55, 49);
            this.butVolver.TabIndex = 16;
            this.butVolver.UseVisualStyleBackColor = false;
            this.butVolver.Click += new System.EventHandler(this.butVolver_Click);
            // 
            // butActualizar
            // 
            this.butActualizar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butActualizar.Location = new System.Drawing.Point(463, 219);
            this.butActualizar.Name = "butActualizar";
            this.butActualizar.Size = new System.Drawing.Size(150, 41);
            this.butActualizar.TabIndex = 17;
            this.butActualizar.Text = "Actualizar";
            this.butActualizar.UseVisualStyleBackColor = true;
            this.butActualizar.Click += new System.EventHandler(this.butActualizar_Click);
            // 
            // interfazAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Libreria.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 656);
            this.Controls.Add(this.butActualizar);
            this.Controls.Add(this.butVolver);
            this.Controls.Add(this.butEliminar);
            this.Controls.Add(this.butAgregar);
            this.Controls.Add(this.butBuscar);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.txtAnho);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "interfazAdmin";
            this.Text = "interfazAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtAnho;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Button butBuscar;
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butEliminar;
        private System.Windows.Forms.Button butVolver;
        private System.Windows.Forms.Button butActualizar;
    }
}