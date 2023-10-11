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
            btnAgregar.Location = new System.Drawing.Point(10, 34);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(137, 22);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(10, 60);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(137, 22);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(153, 34);
            btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(137, 22);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(153, 60);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(137, 22);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(72, 15);
            label1.TabIndex = 4;
            label1.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 88);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 15);
            label2.TabIndex = 5;
            label2.Text = "Buscar:";
            // 
            // dgvEspecialidades
            // 
            dgvEspecialidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEspecialidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEspecialidades.Location = new System.Drawing.Point(10, 111);
            dgvEspecialidades.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvEspecialidades.Name = "dgvEspecialidades";
            dgvEspecialidades.ReadOnly = true;
            dgvEspecialidades.RowHeadersVisible = false;
            dgvEspecialidades.RowHeadersWidth = 51;
            dgvEspecialidades.RowTemplate.Height = 29;
            dgvEspecialidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEspecialidades.Size = new System.Drawing.Size(280, 141);
            dgvEspecialidades.TabIndex = 6;
            dgvEspecialidades.CellClick += dgvEspecialidades_CellClick;
            dgvEspecialidades.CellDoubleClick += dgvEspecialidades_CellDoubleClick;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new System.Drawing.Point(153, 9);
            txtDescripción.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new System.Drawing.Size(138, 23);
            txtDescripción.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(153, 86);
            txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(138, 23);
            txtBuscar.TabIndex = 8;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // Especialidad
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(298, 260);
            Controls.Add(txtBuscar);
            Controls.Add(txtDescripción);
            Controls.Add(dgvEspecialidades);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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