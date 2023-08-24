namespace AcademiaNet
{
    partial class Persona
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(298, 95);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(281, 23);
            this.btnModificar.TabIndex = 45;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(584, 95);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(281, 23);
            this.btnEliminar.TabIndex = 44;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(872, 95);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(276, 23);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(10, 95);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(281, 23);
            this.btnAgregar.TabIndex = 42;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(713, 66);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(435, 23);
            this.txtEmail.TabIndex = 38;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(713, 38);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(435, 23);
            this.txtDireccion.TabIndex = 37;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(713, 8);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(435, 23);
            this.txtTelefono.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(582, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 34;
            this.label6.Text = "Email: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(582, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Direccion: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(582, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 32;
            this.label8.Text = "Telefono: ";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(141, 66);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(435, 23);
            this.dtpFechaNacimiento.TabIndex = 31;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(141, 37);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(435, 23);
            this.txtApellido.TabIndex = 30;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(141, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(435, 23);
            this.txtNombre.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Fecha de Nacimiento: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Apellido: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre: ";
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AllowUserToResizeColumns = false;
            this.dgvPersonas.AllowUserToResizeRows = false;
            this.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(10, 153);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.RowHeadersVisible = false;
            this.dgvPersonas.RowHeadersWidth = 51;
            this.dgvPersonas.RowTemplate.Height = 25;
            this.dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonas.Size = new System.Drawing.Size(1138, 464);
            this.dgvPersonas.TabIndex = 23;
            this.dgvPersonas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellClick);
            this.dgvPersonas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 46;
            this.label5.Text = "Buscar: ";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(67, 124);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(1081, 23);
            this.txtBuscar.TabIndex = 47;
            this.txtBuscar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 629);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvPersonas);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Persona";
            this.Text = "Profesor";
            this.Load += new System.EventHandler(this.Profesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}