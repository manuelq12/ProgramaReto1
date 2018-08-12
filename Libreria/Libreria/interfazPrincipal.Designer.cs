namespace Libreria
{
    partial class interfazPrincipal
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Administrador = new System.Windows.Forms.Button();
            this.butCerrarTodo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butListadoLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Libreria.Properties.Resources.logo_icesi;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(220, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(380, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(142, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agendar Libro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Administrador
            // 
            this.Administrador.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrador.Location = new System.Drawing.Point(142, 273);
            this.Administrador.Name = "Administrador";
            this.Administrador.Size = new System.Drawing.Size(203, 59);
            this.Administrador.TabIndex = 2;
            this.Administrador.Text = "Administrador";
            this.Administrador.UseVisualStyleBackColor = true;
            this.Administrador.Click += new System.EventHandler(this.button2_Click);
            // 
            // butCerrarTodo
            // 
            this.butCerrarTodo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCerrarTodo.ForeColor = System.Drawing.Color.Red;
            this.butCerrarTodo.Location = new System.Drawing.Point(713, 12);
            this.butCerrarTodo.Name = "butCerrarTodo";
            this.butCerrarTodo.Size = new System.Drawing.Size(75, 39);
            this.butCerrarTodo.TabIndex = 3;
            this.butCerrarTodo.Text = "X";
            this.butCerrarTodo.UseVisualStyleBackColor = true;
            this.butCerrarTodo.Click += new System.EventHandler(this.butCerrarTodo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(-19, -19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // butListadoLibro
            // 
            this.butListadoLibro.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butListadoLibro.Location = new System.Drawing.Point(142, 358);
            this.butListadoLibro.Name = "butListadoLibro";
            this.butListadoLibro.Size = new System.Drawing.Size(203, 59);
            this.butListadoLibro.TabIndex = 5;
            this.butListadoLibro.Text = "Listado";
            this.butListadoLibro.UseVisualStyleBackColor = true;
            this.butListadoLibro.Click += new System.EventHandler(this.butListadoLibro_Click);
            // 
            // interfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Libreria.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.butListadoLibro);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butCerrarTodo);
            this.Controls.Add(this.Administrador);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "interfazPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.interfazPrincipal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Administrador;

        private System.Windows.Forms.Button butCerrarTodo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butListadoLibro;
    }
}