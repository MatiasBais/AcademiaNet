namespace AcademiaNet
{
    partial class Comision
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
            btnAgregar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnModificar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            dgvComisiones = new System.Windows.Forms.DataGridView();
            txtDescripción = new System.Windows.Forms.TextBox();
            txtBuscar = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            txtAnioEspecialidad = new System.Windows.Forms.TextBox();
            cmbIdPlan = new System.Windows.Forms.ComboBox();
            txtEspecialidad = new System.Windows.Forms.Label();
            cmbEspecialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(10, 58);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(138, 26);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(441, 58);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(138, 26);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(154, 58);
            btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(138, 25);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(298, 58);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(138, 26);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(348, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Buscar:";
            // 
            // dgvComisiones
            // 
            dgvComisiones.AllowUserToAddRows = false;
            dgvComisiones.AllowUserToDeleteRows = false;
            dgvComisiones.AllowUserToResizeRows = false;
            dgvComisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComisiones.Location = new System.Drawing.Point(10, 121);
            dgvComisiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvComisiones.Name = "dgvComisiones";
            dgvComisiones.ReadOnly = true;
            dgvComisiones.RowHeadersVisible = false;
            dgvComisiones.RowHeadersWidth = 51;
            dgvComisiones.RowTemplate.Height = 29;
            dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvComisiones.Size = new System.Drawing.Size(568, 225);
            dgvComisiones.TabIndex = 6;
            dgvComisiones.CellClick += dgvComisiones_CellClick;
            dgvComisiones.CellDoubleClick += dgvComisiones_CellDoubleClick;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new System.Drawing.Point(440, 34);
            txtDescripción.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new System.Drawing.Size(138, 23);
            txtDescripción.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(140, 88);
            txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(438, 23);
            txtBuscar.TabIndex = 8;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(348, 10);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(33, 15);
            label3.TabIndex = 9;
            label3.Text = "Plan:";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(10, 37);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 15);
            label4.TabIndex = 10;
            label4.Text = "Año especialidad:";
            // 
            // txtAnioEspecialidad
            // 
            txtAnioEspecialidad.Location = new System.Drawing.Point(140, 34);
            txtAnioEspecialidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtAnioEspecialidad.Name = "txtAnioEspecialidad";
            txtAnioEspecialidad.Size = new System.Drawing.Size(147, 23);
            txtAnioEspecialidad.TabIndex = 12;
            // 
            // cmbIdPlan
            // 
            cmbIdPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbIdPlan.FormattingEnabled = true;
            cmbIdPlan.Location = new System.Drawing.Point(440, 9);
            cmbIdPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmbIdPlan.Name = "cmbIdPlan";
            cmbIdPlan.Size = new System.Drawing.Size(138, 23);
            cmbIdPlan.TabIndex = 13;
            cmbIdPlan.SelectedIndexChanged += cmbIdPlan_SelectedIndexChanged;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.AutoSize = true;
            txtEspecialidad.Location = new System.Drawing.Point(10, 11);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new System.Drawing.Size(75, 15);
            txtEspecialidad.TabIndex = 14;
            txtEspecialidad.Text = "Especialidad:";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new System.Drawing.Point(140, 8);
            cmbEspecialidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new System.Drawing.Size(147, 23);
            cmbEspecialidad.TabIndex = 15;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            // 
            // Comision
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(591, 355);
            Controls.Add(cmbEspecialidad);
            Controls.Add(txtEspecialidad);
            Controls.Add(cmbIdPlan);
            Controls.Add(txtAnioEspecialidad);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtBuscar);
            Controls.Add(txtDescripción);
            Controls.Add(dgvComisiones);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "Comision";
            Text = "Comision";
            Load += Comision_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvComisiones;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtAnioEspecialidad;
        private System.Windows.Forms.ComboBox cmbIdPlan;
        private System.Windows.Forms.Label txtEspecialidad;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
    }
}