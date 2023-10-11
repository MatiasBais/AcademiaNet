namespace AcademiaNet
{
    partial class Planes
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            textBox1 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            btnModificar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            dgvPlanes = new System.Windows.Forms.DataGridView();
            cmbEspecialidad = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            lblDescripcion = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(66, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(1084, 23);
            textBox1.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(11, 80);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(42, 15);
            label10.TabIndex = 48;
            label10.Text = "Buscar";
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(298, 45);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(281, 23);
            btnModificar.TabIndex = 47;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(585, 45);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(281, 23);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(872, 45);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(281, 23);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(11, 45);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(281, 23);
            btnAgregar.TabIndex = 44;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvPlanes
            // 
            dgvPlanes.AllowUserToAddRows = false;
            dgvPlanes.AllowUserToDeleteRows = false;
            dgvPlanes.AllowUserToResizeColumns = false;
            dgvPlanes.AllowUserToResizeRows = false;
            dgvPlanes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPlanes.Location = new System.Drawing.Point(11, 100);
            dgvPlanes.MultiSelect = false;
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.ReadOnly = true;
            dgvPlanes.RowHeadersVisible = false;
            dgvPlanes.RowHeadersWidth = 51;
            dgvPlanes.RowTemplate.Height = 25;
            dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPlanes.Size = new System.Drawing.Size(1138, 433);
            dgvPlanes.TabIndex = 25;
            dgvPlanes.CellClick += dgvPlanes_CellClick;
            dgvPlanes.CellContentClick += dgvPlanes_CellContentClick;
            dgvPlanes.CellDoubleClick += dgvPlanes_CellDoubleClick;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new System.Drawing.Point(93, 6);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new System.Drawing.Size(169, 23);
            cmbEspecialidad.TabIndex = 41;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 9);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 15);
            label5.TabIndex = 37;
            label5.Text = "Especialidad:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(286, 9);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(72, 15);
            lblDescripcion.TabIndex = 50;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(361, 6);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(788, 23);
            txtDescripcion.TabIndex = 51;
            // 
            // Planes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1158, 548);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(cmbEspecialidad);
            Controls.Add(label5);
            Controls.Add(dgvPlanes);
            Name = "Planes";
            Text = "Planes";
            Load += Planes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dgvPlanes;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}