namespace AcademiaNet
{
    partial class Materias
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
            lblPlan = new System.Windows.Forms.Label();
            lblEspecialidad = new System.Windows.Forms.Label();
            btnModificar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            lblDescripcion = new System.Windows.Forms.Label();
            txtDescripcion = new System.Windows.Forms.TextBox();
            lblHSSemanales = new System.Windows.Forms.Label();
            HSTotales = new System.Windows.Forms.Label();
            dgvMaterias = new System.Windows.Forms.DataGridView();
            txtHSSemanales = new System.Windows.Forms.TextBox();
            txtHSTotales = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).BeginInit();
            SuspendLayout();
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblPlan.Location = new System.Drawing.Point(509, 9);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(65, 28);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "label1";
            lblPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lblPlan.Click += label1_Click;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEspecialidad.Location = new System.Drawing.Point(570, 9);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(142, 28);
            lblEspecialidad.TabIndex = 1;
            lblEspecialidad.Text = "lblEspecialidad";
            lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            lblEspecialidad.Click += label2_Click;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(299, 99);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(281, 23);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(586, 99);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(281, 23);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(873, 99);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(281, 23);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(12, 99);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(281, 23);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(33, 63);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(75, 15);
            lblDescripcion.TabIndex = 27;
            lblDescripcion.Text = "Descripcion: ";
            lblDescripcion.Click += label1_Click_1;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(114, 60);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(416, 23);
            txtDescripcion.TabIndex = 28;
            // 
            // lblHSSemanales
            // 
            lblHSSemanales.AutoSize = true;
            lblHSSemanales.Location = new System.Drawing.Point(587, 63);
            lblHSSemanales.Name = "lblHSSemanales";
            lblHSSemanales.Size = new System.Drawing.Size(100, 15);
            lblHSSemanales.TabIndex = 29;
            lblHSSemanales.Text = "Horas Semanales:";
            lblHSSemanales.Click += lblHSSemanales_Click;
            // 
            // HSTotales
            // 
            HSTotales.AutoSize = true;
            HSTotales.Location = new System.Drawing.Point(893, 63);
            HSTotales.Name = "HSTotales";
            HSTotales.Size = new System.Drawing.Size(80, 15);
            HSTotales.TabIndex = 31;
            HSTotales.Text = "Horas Totales:";
            HSTotales.Click += HSTotales_Click;
            // 
            // dgvMaterias
            // 
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.AllowUserToResizeColumns = false;
            dgvMaterias.AllowUserToResizeRows = false;
            dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Location = new System.Drawing.Point(16, 138);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowHeadersVisible = false;
            dgvMaterias.RowHeadersWidth = 51;
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.Size = new System.Drawing.Size(1138, 433);
            dgvMaterias.TabIndex = 33;
            dgvMaterias.CellClick += dgvMaterias_CellClick;
            // 
            // txtHSSemanales
            // 
            txtHSSemanales.Location = new System.Drawing.Point(693, 60);
            txtHSSemanales.Name = "txtHSSemanales";
            txtHSSemanales.Size = new System.Drawing.Size(107, 23);
            txtHSSemanales.TabIndex = 34;
            txtHSSemanales.Text = "0";
            // 
            // txtHSTotales
            // 
            txtHSTotales.Location = new System.Drawing.Point(979, 60);
            txtHSTotales.Name = "txtHSTotales";
            txtHSTotales.Size = new System.Drawing.Size(107, 23);
            txtHSTotales.TabIndex = 35;
            txtHSTotales.Text = "0";
            // 
            // Materias
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1198, 450);
            Controls.Add(txtHSTotales);
            Controls.Add(txtHSSemanales);
            Controls.Add(dgvMaterias);
            Controls.Add(HSTotales);
            Controls.Add(lblHSSemanales);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(lblEspecialidad);
            Controls.Add(lblPlan);
            Name = "Materias";
            Text = "Materias";
            Load += Materias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMaterias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblHSSemanales;
        private System.Windows.Forms.Label HSTotales;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.TextBox txtHSSemanales;
        private System.Windows.Forms.TextBox txtHSTotales;
    }
}