namespace ConexionABaseDatosYUsoDataGreedView {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_cargarDatos = new System.Windows.Forms.Button();
            this.dataGridView_datos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datos)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_nombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_nombre.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre.Location = new System.Drawing.Point(82, 15);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_nombre.Size = new System.Drawing.Size(267, 26);
            this.textBox_nombre.TabIndex = 0;
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_apellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_apellido.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_apellido.Location = new System.Drawing.Point(82, 47);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_apellido.Size = new System.Drawing.Size(267, 26);
            this.textBox_apellido.TabIndex = 1;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_direccion.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_direccion.Location = new System.Drawing.Point(82, 79);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_direccion.Size = new System.Drawing.Size(267, 26);
            this.textBox_direccion.TabIndex = 2;
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.BackColor = System.Drawing.SystemColors.Control;
            this.textBox_telefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_telefono.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_telefono.Location = new System.Drawing.Point(82, 111);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox_telefono.Size = new System.Drawing.Size(267, 26);
            this.textBox_telefono.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono";
            // 
            // button_cargarDatos
            // 
            this.button_cargarDatos.BackColor = System.Drawing.Color.Lavender;
            this.button_cargarDatos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_cargarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_cargarDatos.FlatAppearance.BorderSize = 0;
            this.button_cargarDatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cargarDatos.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cargarDatos.Location = new System.Drawing.Point(458, 12);
            this.button_cargarDatos.Name = "button_cargarDatos";
            this.button_cargarDatos.Size = new System.Drawing.Size(242, 123);
            this.button_cargarDatos.TabIndex = 11;
            this.button_cargarDatos.Text = "CARGAR";
            this.button_cargarDatos.UseVisualStyleBackColor = false;
            this.button_cargarDatos.Click += new System.EventHandler(this.button_cargarDatos_Click);
            // 
            // dataGridView_datos
            // 
            this.dataGridView_datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_datos.Location = new System.Drawing.Point(9, 144);
            this.dataGridView_datos.Name = "dataGridView_datos";
            this.dataGridView_datos.Size = new System.Drawing.Size(790, 294);
            this.dataGridView_datos.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_datos);
            this.Controls.Add(this.button_cargarDatos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.textBox_nombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_cargarDatos;
        private System.Windows.Forms.DataGridView dataGridView_datos;
    }
}

