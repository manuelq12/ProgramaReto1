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
            this.butLibros = new System.Windows.Forms.Button();
            this.butLibrosFisicos = new System.Windows.Forms.Button();
            this.butLibrosDigital = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butLibros
            // 
            this.butLibros.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLibros.Location = new System.Drawing.Point(44, 32);
            this.butLibros.Name = "butLibros";
            this.butLibros.Size = new System.Drawing.Size(155, 57);
            this.butLibros.TabIndex = 0;
            this.butLibros.Text = "Libros";
            this.butLibros.UseVisualStyleBackColor = true;
            // 
            // butLibrosFisicos
            // 
            this.butLibrosFisicos.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLibrosFisicos.Location = new System.Drawing.Point(257, 32);
            this.butLibrosFisicos.Name = "butLibrosFisicos";
            this.butLibrosFisicos.Size = new System.Drawing.Size(237, 57);
            this.butLibrosFisicos.TabIndex = 1;
            this.butLibrosFisicos.Text = "Libros en Físico";
            this.butLibrosFisicos.UseVisualStyleBackColor = true;
            this.butLibrosFisicos.Click += new System.EventHandler(this.butLibrosFisicos_Click);
            // 
            // butLibrosDigital
            // 
            this.butLibrosDigital.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLibrosDigital.Location = new System.Drawing.Point(562, 32);
            this.butLibrosDigital.Name = "butLibrosDigital";
            this.butLibrosDigital.Size = new System.Drawing.Size(237, 57);
            this.butLibrosDigital.TabIndex = 2;
            this.butLibrosDigital.Text = "Libros en Digital";
            this.butLibrosDigital.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Libreria.Properties.Resources.volver2;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 462);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 51);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listadoLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Libreria.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 525);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butLibrosDigital);
            this.Controls.Add(this.butLibrosFisicos);
            this.Controls.Add(this.butLibros);
            this.Name = "listadoLibros";
            this.Text = "listadoLibros";
            this.Load += new System.EventHandler(this.listadoLibros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butLibros;
        private System.Windows.Forms.Button butLibrosFisicos;
        private System.Windows.Forms.Button butLibrosDigital;
        private System.Windows.Forms.Button button1;
    }
}