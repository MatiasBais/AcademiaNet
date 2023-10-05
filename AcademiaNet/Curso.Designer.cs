namespace AcademiaNet
{
    partial class Curso
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
            txtDescripcion = new System.Windows.Forms.TextBox();
            lblDescripcion = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label10 = new System.Windows.Forms.Label();
            btnModificar = new System.Windows.Forms.Button();
            btnEliminar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            btnAgregar = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            dgvCursos = new System.Windows.Forms.DataGridView();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            verInscriptosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            cmbMateria = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            txtCupo = new System.Windows.Forms.TextBox();
            lblAnio = new System.Windows.Forms.Label();
            lblPlan = new System.Windows.Forms.Label();
            lblComision = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            nudAnio = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            SuspendLayout();
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new System.Drawing.Point(191, 144);
            txtDescripcion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new System.Drawing.Size(766, 27);
            txtDescripcion.TabIndex = 62;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new System.Drawing.Point(89, 148);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new System.Drawing.Size(90, 20);
            lblDescripcion.TabIndex = 61;
            lblDescripcion.Text = "Descripción:";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(103, 231);
            textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(1207, 27);
            textBox1.TabIndex = 60;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(-207, 36);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(52, 20);
            label10.TabIndex = 59;
            label10.Text = "Buscar";
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(337, 192);
            btnModificar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(321, 31);
            btnModificar.TabIndex = 58;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(665, 192);
            btnEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(321, 31);
            btnEliminar.TabIndex = 57;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(993, 192);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(321, 31);
            btnCancelar.TabIndex = 56;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(9, 192);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(321, 31);
            btnAgregar.TabIndex = 55;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(-206, -59);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(96, 20);
            label5.TabIndex = 53;
            label5.Text = "Especialidad:";
            // 
            // dgvCursos
            // 
            dgvCursos.AllowUserToAddRows = false;
            dgvCursos.AllowUserToDeleteRows = false;
            dgvCursos.AllowUserToResizeColumns = false;
            dgvCursos.AllowUserToResizeRows = false;
            dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.ContextMenuStrip = contextMenuStrip1;
            dgvCursos.Location = new System.Drawing.Point(9, 265);
            dgvCursos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            dgvCursos.MultiSelect = false;
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowHeadersVisible = false;
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.RowTemplate.Height = 25;
            dgvCursos.Size = new System.Drawing.Size(1301, 577);
            dgvCursos.TabIndex = 52;
            dgvCursos.CellClick += dgvCursos_CellClick;
            dgvCursos.CellDoubleClick += dgvCursos_CellDoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { verInscriptosToolStripMenuItem, profesoresToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(148, 52);
            contextMenuStrip1.Opening += contextMenuStrip1_Opening;
            // 
            // verInscriptosToolStripMenuItem
            // 
            verInscriptosToolStripMenuItem.Name = "verInscriptosToolStripMenuItem";
            verInscriptosToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            verInscriptosToolStripMenuItem.Text = "Inscriptos";
            verInscriptosToolStripMenuItem.Click += verInscriptosToolStripMenuItem_Click;
            // 
            // profesoresToolStripMenuItem
            // 
            profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            profesoresToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            profesoresToolStripMenuItem.Text = "Profesores";
            profesoresToolStripMenuItem.Click += profesoresToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(30, 235);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 20);
            label1.TabIndex = 63;
            label1.Text = "Buscar: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(89, 95);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(39, 20);
            label2.TabIndex = 64;
            label2.Text = "Año:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(283, 91);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(63, 20);
            label4.TabIndex = 67;
            label4.Text = "Materia:";
            // 
            // cmbMateria
            // 
            cmbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbMateria.FormattingEnabled = true;
            cmbMateria.Location = new System.Drawing.Point(370, 91);
            cmbMateria.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            cmbMateria.Name = "cmbMateria";
            cmbMateria.Size = new System.Drawing.Size(193, 28);
            cmbMateria.TabIndex = 68;
            cmbMateria.SelectedIndexChanged += cmbMateria_SelectedValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(1021, 148);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 20);
            label6.TabIndex = 69;
            label6.Text = "Cupo: ";
            label6.Click += label6_Click;
            // 
            // txtCupo
            // 
            txtCupo.Location = new System.Drawing.Point(1110, 141);
            txtCupo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtCupo.Name = "txtCupo";
            txtCupo.Size = new System.Drawing.Size(81, 27);
            txtCupo.TabIndex = 70;
            txtCupo.TextChanged += textBox2_TextChanged;
            txtCupo.KeyPress += txtCupo_KeyPress;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new System.Drawing.Point(403, 33);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new System.Drawing.Size(57, 20);
            lblAnio.TabIndex = 72;
            lblAnio.Text = "lblAnio";
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new System.Drawing.Point(547, 33);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new System.Drawing.Size(55, 20);
            lblPlan.TabIndex = 73;
            lblPlan.Text = "lblplan";
            // 
            // lblComision
            // 
            lblComision.AutoSize = true;
            lblComision.Location = new System.Drawing.Point(710, 33);
            lblComision.Name = "lblComision";
            lblComision.Size = new System.Drawing.Size(88, 20);
            lblComision.TabIndex = 74;
            lblComision.Text = "lblComision";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(359, 33);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(44, 20);
            label3.TabIndex = 75;
            label3.Text = "AÑO:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(498, 33);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(48, 20);
            label7.TabIndex = 76;
            label7.Text = "PLAN:";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(629, 33);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(83, 20);
            label8.TabIndex = 77;
            label8.Text = "COMISIÓN:";
            // 
            // nudAnio
            // 
            nudAnio.Location = new System.Drawing.Point(149, 92);
            nudAnio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            nudAnio.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudAnio.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            nudAnio.Name = "nudAnio";
            nudAnio.Size = new System.Drawing.Size(81, 27);
            nudAnio.TabIndex = 78;
            nudAnio.Value = new decimal(new int[] { 1900, 0, 0, 0 });
            nudAnio.ValueChanged += load_Cursos;
            // 
            // Curso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1323, 849);
            Controls.Add(nudAnio);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(lblComision);
            Controls.Add(lblPlan);
            Controls.Add(lblAnio);
            Controls.Add(txtCupo);
            Controls.Add(label6);
            Controls.Add(cmbMateria);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(btnModificar);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(dgvCursos);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Curso";
            Text = "Curso";
            Load += Curso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblPlan;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verInscriptosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
    }
}