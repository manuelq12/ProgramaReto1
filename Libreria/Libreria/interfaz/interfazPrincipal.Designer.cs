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
            this.butCerrarTodo = new System.Windows.Forms.Button();
            this.butListadoLibro = new System.Windows.Forms.Button();
            this.labCentro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Libreria.Properties.Resources.Icesi_Ciencia_Tec_Inn;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(46, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 86);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
           
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(27, 206);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Agendar Libro";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butCerrarTodo
            // 
            this.butCerrarTodo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCerrarTodo.ForeColor = System.Drawing.Color.Red;
            this.butCerrarTodo.Location = new System.Drawing.Point(535, 10);
            this.butCerrarTodo.Margin = new System.Windows.Forms.Padding(2);
            this.butCerrarTodo.Name = "butCerrarTodo";
            this.butCerrarTodo.Size = new System.Drawing.Size(56, 32);
            this.butCerrarTodo.TabIndex = 3;
            this.butCerrarTodo.Text = "X";
            this.butCerrarTodo.UseVisualStyleBackColor = true;
            this.butCerrarTodo.Click += new System.EventHandler(this.butCerrarTodo_Click);
            // 
            // butListadoLibro
            // 
            this.butListadoLibro.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butListadoLibro.Location = new System.Drawing.Point(202, 205);
            this.butListadoLibro.Margin = new System.Windows.Forms.Padding(2);
            this.butListadoLibro.Name = "butListadoLibro";
            this.butListadoLibro.Size = new System.Drawing.Size(152, 48);
            this.butListadoLibro.TabIndex = 5;
            this.butListadoLibro.Text = "Listado";
            this.butListadoLibro.UseVisualStyleBackColor = true;
            this.butListadoLibro.Click += new System.EventHandler(this.butListadoLibro_Click);
            // 
            // labCentro
            // 
            this.labCentro.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCentro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labCentro.Location = new System.Drawing.Point(347, 55);
            this.labCentro.Name = "labCentro";
            this.labCentro.Size = new System.Drawing.Size(241, 42);
            this.labCentro.TabIndex = 7;
            this.labCentro.Text = "Centro de Registro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Biblioteca ICESI";
            // 
            // interfazPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Libreria.Properties.Resources.FONDO;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labCentro);
            this.Controls.Add(this.butListadoLibro);
            this.Controls.Add(this.butCerrarTodo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "interfazPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.interfazPrincipal_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button butCerrarTodo;
        private System.Windows.Forms.Button butListadoLibro;
        private System.Windows.Forms.Label labCentro;
        private System.Windows.Forms.Label label1;
    }
}