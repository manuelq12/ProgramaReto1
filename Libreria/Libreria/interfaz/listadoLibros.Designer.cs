namespace Libreria
{
    partial class listadoLibros
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
            this.butLibrosFisicos = new System.Windows.Forms.Button();
            this.butLibrosDigital = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabla = new System.Windows.Forms.DataGridView();
            this.butAgendar = new System.Windows.Forms.Button();
            this.butSelectA = new System.Windows.Forms.Button();
            this.butEliminarFisicos = new System.Windows.Forms.Button();
            this.butEliminarDigitales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).BeginInit();
            this.SuspendLayout();
            // 
            // butLibrosFisicos
            // 
            this.butLibrosFisicos.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLibrosFisicos.Location = new System.Drawing.Point(56, 26);
            this.butLibrosFisicos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.butLibrosFisicos.Name = "butLibrosFisicos";
            this.butLibrosFisicos.Size = new System.Drawing.Size(178, 46);
            this.butLibrosFisicos.TabIndex = 1;
            this.butLibrosFisicos.Text = "Libros en Físico";
            this.butLibrosFisicos.UseVisualStyleBackColor = true;
            this.butLibrosFisicos.Click += new System.EventHandler(this.butLibrosFisicos_Click);
            // 
            // butLibrosDigital
            // 
            this.butLibrosDigital.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLibrosDigital.Location = new System.Drawing.Point(267, 26);
            this.butLibrosDigital.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.butLibrosDigital.Name = "butLibrosDigital";
            this.butLibrosDigital.Size = new System.Drawing.Size(189, 46);
            this.butLibrosDigital.TabIndex = 2;
            this.butLibrosDigital.Text = "Libros en Digital";
            this.butLibrosDigital.UseVisualStyleBackColor = true;
            this.butLibrosDigital.Click += new System.EventHandler(this.butLibrosDigital_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Libreria.Properties.Resources.volver2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 42);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabla
            // 
            this.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla.Location = new System.Drawing.Point(-6, 103);
            this.tabla.Margin = new System.Windows.Forms.Padding(1);
            this.tabla.Name = "tabla";
            this.tabla.RowTemplate.Height = 40;
            this.tabla.Size = new System.Drawing.Size(522, 212);
            this.tabla.TabIndex = 5;
            this.tabla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_CellContentClick);
            // 
            // butAgendar
            // 
            this.butAgendar.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butAgendar.Location = new System.Drawing.Point(614, 21);
            this.butAgendar.Name = "butAgendar";
            this.butAgendar.Size = new System.Drawing.Size(182, 57);
            this.butAgendar.TabIndex = 6;
            this.butAgendar.Text = "Pagina Agendar";
            this.butAgendar.UseVisualStyleBackColor = true;
            this.butAgendar.Click += new System.EventHandler(this.butAgendar_Click);
            // 
            // butSelectA
            // 
            this.butSelectA.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSelectA.Location = new System.Drawing.Point(614, 84);
            this.butSelectA.Name = "butSelectA";
            this.butSelectA.Size = new System.Drawing.Size(184, 58);
            this.butSelectA.TabIndex = 7;
            this.butSelectA.Text = "Agendar Seleccionado";
            this.butSelectA.UseVisualStyleBackColor = true;
            this.butSelectA.Click += new System.EventHandler(this.butSelectA_Click);
            // 
            // butEliminarFisicos
            // 
            this.butEliminarFisicos.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminarFisicos.Location = new System.Drawing.Point(24, 319);
            this.butEliminarFisicos.Name = "butEliminarFisicos";
            this.butEliminarFisicos.Size = new System.Drawing.Size(166, 50);
            this.butEliminarFisicos.TabIndex = 8;
            this.butEliminarFisicos.Text = "Eliminar Físicos";
            this.butEliminarFisicos.UseVisualStyleBackColor = true;
            this.butEliminarFisicos.Click += new System.EventHandler(this.button2_Click);
            // 
            // butEliminarDigitales
            // 
            this.butEliminarDigitales.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butEliminarDigitales.Location = new System.Drawing.Point(196, 319);
            this.butEliminarDigitales.Name = "butEliminarDigitales";
            this.butEliminarDigitales.Size = new System.Drawing.Size(181, 50);
            this.butEliminarDigitales.TabIndex = 9;
            this.butEliminarDigitales.Text = "Eliminar Digitales";
            this.butEliminarDigitales.UseVisualStyleBackColor = true;
            this.butEliminarDigitales.Click += new System.EventHandler(this.butEliminarDigitales_Click);
            // 
            // listadoLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Libreria.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 441);
            this.Controls.Add(this.butEliminarDigitales);
            this.Controls.Add(this.butEliminarFisicos);
            this.Controls.Add(this.butSelectA);
            this.Controls.Add(this.butAgendar);
            this.Controls.Add(this.tabla);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butLibrosDigital);
            this.Controls.Add(this.butLibrosFisicos);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "listadoLibros";
            this.Text = "listadoLibros";
            this.Load += new System.EventHandler(this.listadoLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button butLibrosFisicos;
        private System.Windows.Forms.Button butLibrosDigital;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tabla;
        private System.Windows.Forms.Button butAgendar;
        private System.Windows.Forms.Button butSelectA;
        private System.Windows.Forms.Button butEliminarFisicos;
        private System.Windows.Forms.Button butEliminarDigitales;
    }
}