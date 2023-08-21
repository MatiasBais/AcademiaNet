namespace AcademiaNet
{
    partial class Especialidad
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
            dgvEspecialidades = new System.Windows.Forms.DataGridView();
            txtDescripción = new System.Windows.Forms.TextBox();
            txtBuscar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(12, 45);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(157, 29);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(12, 80);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(157, 29);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(175, 45);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(157, 29);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(175, 80);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(157, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 20);
            label1.TabIndex = 4;
            label1.Text = "Descripción:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 118);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 20);
            label2.TabIndex = 5;
            label2.Text = "Buscar:";
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new System.Drawing.Point(12, 148);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersVisible = false;
            dgvEspecialidades.RowHeadersWidth = 51;
            dgvEspecialidades.RowTemplate.Height = 29;
            dgvEspecialidades.Size = new System.Drawing.Size(320, 188);
            dgvEspecialidades.TabIndex = 6;
            dgvEspecialidades.CellDoubleClick += dgvEspecialidades_CellDoubleClick;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new System.Drawing.Point(175, 12);
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new System.Drawing.Size(157, 27);
            txtDescripción.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(175, 115);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(157, 27);
            txtBuscar.TabIndex = 8;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // Especialidad
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(341, 347);
            Controls.Add(txtBuscar);
            Controls.Add(txtDescripción);
            Controls.Add(dgvEspecialidades);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Name = "Especialidad";
            Text = "Especialidad";
            Load += Especialidad_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEspecialidades).EndInit();
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
        private System.Windows.Forms.DataGridView dgvEspecialidades;
        private System.Windows.Forms.TextBox txtDescripción;
        private System.Windows.Forms.TextBox txtBuscar;
    }
}