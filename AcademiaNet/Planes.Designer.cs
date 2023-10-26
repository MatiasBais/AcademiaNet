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
            components = new System.ComponentModel.Container();
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
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvPlanes).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(75, 99);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(1238, 27);
            textBox1.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(13, 107);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(52, 20);
            label10.TabIndex = 48;
            label10.Text = "Buscar";
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(341, 60);
            btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(321, 31);
            btnModificar.TabIndex = 47;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(669, 60);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(321, 31);
            btnEliminar.TabIndex = 46;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(997, 60);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(321, 31);
            btnCancelar.TabIndex = 45;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(13, 60);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(321, 31);
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
            dgvPlanes.Location = new System.Drawing.Point(13, 133);
            dgvPlanes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvPlanes.MultiSelect = false;
            dgvPlanes.Name = "dgvPlanes";
            dgvPlanes.ReadOnly = true;
            dgvPlanes.RowHeadersVisible = false;
            dgvPlanes.RowHeadersWidth = 51;
            dgvPlanes.RowTemplate.Height = 25;
            dgvPlanes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvPlanes.Size = new System.Drawing.Size(1301, 577);
            dgvPlanes.TabIndex = 25;
            dgvPlanes.CellClick += dgvPlanes_CellClick;
            dgvPlanes.CellContentClick += dgvPlanes_CellContentClick;
            dgvPlanes.CellDoubleClick += dgvPlanes_CellDoubleClick;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new System.Drawing.Point(106, 8);
            cmbEspecialidad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new System.Drawing.Size(193, 28);
            cmbEspecialidad.TabIndex = 41;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(14, 12);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 20);
            label5.TabIndex = 37;
            label5.Text = "Especialidad:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(327, 12);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(90, 20);
            lblDescripcion.TabIndex = 50;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(413, 8);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(900, 27);
            txtDescripcion.TabIndex = 51;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Planes
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1323, 731);
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
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Timer timer1;
    }
}