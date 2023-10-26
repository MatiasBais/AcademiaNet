namespace AcademiaNet
{
    partial class Usuario
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
            components = new System.ComponentModel.Container();
            dgvUsuarios = new System.Windows.Forms.DataGridView();
            cmbTipo = new System.Windows.Forms.ComboBox();
            cmbEspecialidad = new System.Windows.Forms.ComboBox();
            cmbPlan = new System.Windows.Forms.ComboBox();
            txtClave = new System.Windows.Forms.TextBox();
            txtLegajo = new System.Windows.Forms.TextBox();
            txtNombreUsuario = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            lblEspecialidad = new System.Windows.Forms.Label();
            lblPlan = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            btnModificar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            cmbHabilitado = new System.Windows.Forms.ComboBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.AllowUserToResizeColumns = false;
            dgvUsuarios.AllowUserToResizeRows = false;
            dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new System.Drawing.Point(14, 171);
            dgvUsuarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.RowTemplate.Height = 25;
            dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new System.Drawing.Size(1306, 652);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Alumno", "Profesor", "Administrador" });
            cmbTipo.Location = new System.Drawing.Point(822, 51);
            cmbTipo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new System.Drawing.Size(497, 28);
            cmbTipo.TabIndex = 5;
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new System.Drawing.Point(914, 89);
            cmbEspecialidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new System.Drawing.Size(159, 28);
            cmbEspecialidad.TabIndex = 6;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            // 
            // cmbPlan
            // 
            cmbPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbPlan.FormattingEnabled = true;
            cmbPlan.Location = new System.Drawing.Point(1159, 89);
            cmbPlan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbPlan.Name = "cmbPlan";
            cmbPlan.Size = new System.Drawing.Size(159, 28);
            cmbPlan.TabIndex = 6;
            // 
            // txtClave
            // 
            txtClave.Location = new System.Drawing.Point(161, 89);
            txtClave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new System.Drawing.Size(497, 27);
            txtClave.TabIndex = 3;
            txtClave.UseSystemPasswordChar = true;
            // 
            // txtLegajo
            // 
            txtLegajo.Location = new System.Drawing.Point(161, 12);
            txtLegajo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtLegajo.Name = "txtLegajo";
            txtLegajo.Size = new System.Drawing.Size(497, 27);
            txtLegajo.TabIndex = 1;
            txtLegajo.Text = "0";
            txtLegajo.KeyPress += txtLegajo_KeyPress;
            txtLegajo.Leave += txtLegajo_Leave;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new System.Drawing.Point(161, 51);
            txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new System.Drawing.Size(497, 27);
            txtNombreUsuario.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 16);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(57, 20);
            label1.TabIndex = 8;
            label1.Text = "Legajo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 55);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(142, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre de Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(14, 93);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(52, 20);
            label3.TabIndex = 10;
            label3.Text = "Clave: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(665, 16);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 20);
            label4.TabIndex = 11;
            label4.Text = "Habilitado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(665, 55);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(117, 20);
            label5.TabIndex = 12;
            label5.Text = "Tipo de Usuario:";
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new System.Drawing.Point(822, 93);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(96, 20);
            lblEspecialidad.TabIndex = 13;
            lblEspecialidad.Text = "Especialidad:";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new System.Drawing.Point(1081, 93);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(40, 20);
            lblPlan.TabIndex = 14;
            lblPlan.Text = "Plan:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(14, 171);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(0, 20);
            label8.TabIndex = 52;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(343, 128);
            btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(321, 31);
            btnModificar.TabIndex = 51;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(670, 128);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(321, 31);
            btnEliminar.TabIndex = 50;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(999, 128);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(321, 31);
            btnCancelar.TabIndex = 49;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(14, 128);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(321, 31);
            btnAgregar.TabIndex = 48;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbHabilitado
            // 
            cmbHabilitado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbHabilitado.FormattingEnabled = true;
            cmbHabilitado.Items.AddRange(new object[] { "Habilitado", "No Habilitado" });
            cmbHabilitado.Location = new System.Drawing.Point(822, 12);
            cmbHabilitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbHabilitado.Name = "cmbHabilitado";
            cmbHabilitado.Size = new System.Drawing.Size(497, 28);
            cmbHabilitado.TabIndex = 53;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Usuario
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1333, 839);
            Controls.Add(cmbHabilitado);
            Controls.Add(label8);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(lblPlan);
            Controls.Add(lblEspecialidad);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombreUsuario);
            Controls.Add(txtLegajo);
            Controls.Add(txtClave);
            Controls.Add(cmbPlan);
            Controls.Add(cmbEspecialidad);
            Controls.Add(cmbTipo);
            Controls.Add(dgvUsuarios);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Usuario";
            Text = "Usuario";
            Load += Usuario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.ComboBox cmbPlan;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbHabilitado;
        private System.Windows.Forms.Timer timer1;
    }
}