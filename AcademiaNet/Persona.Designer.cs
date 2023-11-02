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
            btnModificar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            txtEmail = new System.Windows.Forms.TextBox();
            txtDireccion = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            txtApellido = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dgvPersonas = new System.Windows.Forms.DataGridView();
            label5 = new System.Windows.Forms.Label();
            txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(341, 127);
            btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(321, 31);
            btnModificar.TabIndex = 45;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(667, 127);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(321, 31);
            btnEliminar.TabIndex = 44;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(997, 127);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(315, 31);
            btnCancelar.TabIndex = 43;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(11, 127);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(321, 31);
            btnAgregar.TabIndex = 42;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(815, 88);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(497, 27);
            txtEmail.TabIndex = 38;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(815, 51);
            txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(497, 27);
            txtDireccion.TabIndex = 37;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(815, 11);
            txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(497, 27);
            txtTelefono.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(665, 92);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(53, 20);
            label6.TabIndex = 34;
            label6.Text = "Email: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(665, 53);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 20);
            label7.TabIndex = 33;
            label7.Text = "Direccion: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(665, 15);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 20);
            label8.TabIndex = 32;
            label8.Text = "Telefono: ";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new System.Drawing.Point(161, 88);
            dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new System.Drawing.Size(497, 27);
            dtpFechaNacimiento.TabIndex = 31;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(161, 49);
            txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(497, 27);
            txtApellido.TabIndex = 30;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(161, 12);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(497, 27);
            txtNombre.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(11, 96);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(156, 20);
            label4.TabIndex = 27;
            label4.Text = "Fecha de Nacimiento: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(11, 53);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 20);
            label3.TabIndex = 26;
            label3.Text = "Apellido: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 20);
            label2.TabIndex = 25;
            label2.Text = "Nombre: ";
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.AllowUserToResizeColumns = false;
            dgvPersonas.AllowUserToResizeRows = false;
            dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new System.Drawing.Point(11, 204);
            dgvPersonas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.ReadOnly = true;
            dgvPersonas.RowHeadersVisible = false;
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.RowTemplate.Height = 25;
            dgvPersonas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPersonas.Size = new System.Drawing.Size(1301, 619);
            dgvPersonas.TabIndex = 23;
            dgvPersonas.CellClick += dgvPersonas_CellClick;
            dgvPersonas.CellDoubleClick += dgvPersonas_CellDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(11, 169);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(59, 20);
            label5.TabIndex = 46;
            label5.Text = "Buscar: ";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(77, 165);
            txtBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(1235, 27);
            txtBuscar.TabIndex = 47;
            txtBuscar.TextChanged += textBox1_TextChanged;
            // 
            // Persona
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1333, 839);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(txtEmail);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvPersonas);
            Name = "Persona";
            Text = "Personas";
            Load += Profesor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
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