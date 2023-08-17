namespace AcademiaNet
{
    partial class Alumnos
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
            dgvPersonas = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtLegajo = new System.Windows.Forms.TextBox();
            txtNombre = new System.Windows.Forms.TextBox();
            txtApellido = new System.Windows.Forms.TextBox();
            dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            txtEmail = new System.Windows.Forms.TextBox();
            txtDireccion = new System.Windows.Forms.TextBox();
            txtTelefono = new System.Windows.Forms.TextBox();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            cmbEspecialidad = new System.Windows.Forms.ComboBox();
            cmbPlan = new System.Windows.Forms.ComboBox();
            label9 = new System.Windows.Forms.Label();
            btnAgregar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.AllowUserToAddRows = false;
            dgvPersonas.AllowUserToDeleteRows = false;
            dgvPersonas.AllowUserToResizeColumns = false;
            dgvPersonas.AllowUserToResizeRows = false;
            dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Location = new System.Drawing.Point(14, 211);
            dgvPersonas.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersVisible = false;
            dgvPersonas.RowHeadersWidth = 51;
            dgvPersonas.RowTemplate.Height = 25;
            dgvPersonas.Size = new System.Drawing.Size(1301, 612);
            dgvPersonas.TabIndex = 0;
            dgvPersonas.CellDoubleClick += dgvPersonas_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Legajo: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 51);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 89);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 20);
            label3.TabIndex = 3;
            label3.Text = "Apellido: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(14, 132);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(156, 20);
            label4.TabIndex = 4;
            label4.Text = "Fecha de Nacimiento: ";
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(163, 8);
            txtLegajo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(497, 27);
            txtLegajo.TabIndex = 5;
            txtLegajo.Text = "0";
            txtLegajo.TextChanged += txtLegajo_TextChanged;
            txtLegajo.KeyDown += txtLegajo_KeyDown;
            txtLegajo.KeyPress += txtLegajo_KeyPress;
            txtLegajo.Leave += txtLegajo_Leave;
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(163, 47);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(497, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new System.Drawing.Point(163, 85);
            txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new System.Drawing.Size(497, 27);
            txtApellido.TabIndex = 7;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new System.Drawing.Point(163, 124);
            dtpFechaNacimiento.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new System.Drawing.Size(497, 27);
            dtpFechaNacimiento.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(817, 85);
            txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(497, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new System.Drawing.Point(817, 47);
            txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new System.Drawing.Size(497, 27);
            txtDireccion.TabIndex = 14;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new System.Drawing.Point(817, 8);
            txtTelefono.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new System.Drawing.Size(497, 27);
            txtTelefono.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(667, 128);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 20);
            label5.TabIndex = 12;
            label5.Text = "Especialidad:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(667, 89);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(53, 20);
            label6.TabIndex = 11;
            label6.Text = "Email: ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(667, 51);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(79, 20);
            label7.TabIndex = 10;
            label7.Text = "Direccion: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(667, 12);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(74, 20);
            label8.TabIndex = 9;
            label8.Text = "Telefono: ";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new System.Drawing.Point(817, 124);
            cmbEspecialidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new System.Drawing.Size(193, 28);
            cmbEspecialidad.TabIndex = 16;
            cmbEspecialidad.SelectedValueChanged += cmbEspecialidad_SelectedValueChanged;
            // 
            // cmbPlan
            // 
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new System.Drawing.Point(1112, 124);
            cmbPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new System.Drawing.Size(202, 28);
            cmbPlan.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(1029, 128);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(40, 20);
            label9.TabIndex = 17;
            label9.Text = "Plan:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(14, 172);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(321, 31);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(998, 172);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(321, 31);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(670, 172);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(321, 31);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(342, 172);
            btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(321, 31);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // Alumnos
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1333, 839);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbPlan);
            Controls.Add(label9);
            Controls.Add(cmbEspecialidad);
            Controls.Add(txtEmail);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(txtLegajo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPersonas);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Alumnos";
            Text = "Persona";
            Load += Persona_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
    }
}