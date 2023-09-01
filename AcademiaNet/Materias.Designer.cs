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
            lblPlan.Location = new System.Drawing.Point(582, 12);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(81, 35);
            lblPlan.TabIndex = 0;
            lblPlan.Text = "label1";
            lblPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEspecialidad.Location = new System.Drawing.Point(651, 12);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new System.Drawing.Size(180, 35);
            lblEspecialidad.TabIndex = 1;
            lblEspecialidad.Text = "lblEspecialidad";
            lblEspecialidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(342, 132);
            btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(321, 31);
            btnModificar.TabIndex = 26;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(670, 132);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(321, 31);
            btnEliminar.TabIndex = 25;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(998, 132);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(321, 31);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(14, 132);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(321, 31);
            btnAgregar.TabIndex = 23;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(14, 84);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(94, 20);
            lblDescripcion.TabIndex = 27;
            lblDescripcion.Text = "Descripcion: ";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(130, 80);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(533, 27);
            txtDescripcion.TabIndex = 28;
            // 
            // lblHSSemanales
            // 
            lblHSSemanales.AutoSize = true;
            lblHSSemanales.Location = new System.Drawing.Point(671, 84);
            lblHSSemanales.Name = "lblHSSemanales";
            lblHSSemanales.Size = new System.Drawing.Size(126, 20);
            lblHSSemanales.TabIndex = 29;
            lblHSSemanales.Text = "Horas Semanales:";
            // 
            // HSTotales
            // 
            HSTotales.AutoSize = true;
            HSTotales.Location = new System.Drawing.Point(998, 84);
            HSTotales.Name = "HSTotales";
            HSTotales.Size = new System.Drawing.Size(102, 20);
            HSTotales.TabIndex = 31;
            HSTotales.Text = "Horas Totales:";
            // 
            // dgvMaterias
            // 
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.AllowUserToResizeColumns = false;
            dgvMaterias.AllowUserToResizeRows = false;
            dgvMaterias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMaterias.Location = new System.Drawing.Point(18, 184);
            dgvMaterias.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvMaterias.Name = "dgvMaterias";
            dgvMaterias.ReadOnly = true;
            dgvMaterias.RowHeadersVisible = false;
            dgvMaterias.RowHeadersWidth = 51;
            dgvMaterias.RowTemplate.Height = 25;
            dgvMaterias.Size = new System.Drawing.Size(1301, 577);
            dgvMaterias.TabIndex = 33;
            dgvMaterias.CellClick += dgvMaterias_CellClick;
            // 
            // txtHSSemanales
            // 
            txtHSSemanales.Location = new System.Drawing.Point(803, 81);
            txtHSSemanales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtHSSemanales.Name = "txtHSSemanales";
            txtHSSemanales.Size = new System.Drawing.Size(188, 27);
            txtHSSemanales.TabIndex = 34;
            txtHSSemanales.Text = "0";
            txtHSSemanales.TextChanged += txtHSSemanales_TextChanged;
            txtHSSemanales.KeyPress += txtHSSemanales_KeyPress;
            txtHSSemanales.Leave += txtHSSemanales_Leave;
            // 
            // txtHSTotales
            // 
            txtHSTotales.Location = new System.Drawing.Point(1131, 81);
            txtHSTotales.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtHSTotales.Name = "txtHSTotales";
            txtHSTotales.Size = new System.Drawing.Size(188, 27);
            txtHSTotales.TabIndex = 35;
            txtHSTotales.Text = "0";
            txtHSTotales.KeyPress += txtHSTotales_KeyPress;
            txtHSTotales.Leave += txtHSTotales_Leave;
            // 
            // Materias
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1329, 768);
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
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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