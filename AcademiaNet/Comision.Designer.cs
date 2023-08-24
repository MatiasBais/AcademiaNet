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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvComisiones = new System.Windows.Forms.DataGridView();
            this.txtDescripción = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnioEspecialidad = new System.Windows.Forms.TextBox();
            this.cmbIdPlan = new System.Windows.Forms.ComboBox();
            this.txtEspecialidad = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(9, 34);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 26);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(383, 34);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 26);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Location = new System.Drawing.Point(133, 35);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(120, 25);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Location = new System.Drawing.Point(259, 34);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 26);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(803, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar:";
            // 
            // dgvComisiones
            // 
            this.dgvComisiones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComisiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComisiones.Location = new System.Drawing.Point(10, 111);
            this.dgvComisiones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvComisiones.Name = "dgvComisiones";
            this.dgvComisiones.ReadOnly = true;
            this.dgvComisiones.RowHeadersVisible = false;
            this.dgvComisiones.RowHeadersWidth = 51;
            this.dgvComisiones.RowTemplate.Height = 29;
            this.dgvComisiones.Size = new System.Drawing.Size(900, 141);
            this.dgvComisiones.TabIndex = 6;
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(895, 6);
            this.txtDescripción.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(138, 23);
            this.txtDescripción.TabIndex = 7;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(103, 64);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 23);
            this.txtBuscar.TabIndex = 8;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Plan:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(465, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Año especialidad:";
            // 
            // txtAnioEspecialidad
            // 
            this.txtAnioEspecialidad.Location = new System.Drawing.Point(595, 8);
            this.txtAnioEspecialidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAnioEspecialidad.Name = "txtAnioEspecialidad";
            this.txtAnioEspecialidad.Size = new System.Drawing.Size(147, 23);
            this.txtAnioEspecialidad.TabIndex = 12;
            // 
            // cmbIdPlan
            // 
            this.cmbIdPlan.FormattingEnabled = true;
            this.cmbIdPlan.Location = new System.Drawing.Point(325, 9);
            this.cmbIdPlan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbIdPlan.Name = "cmbIdPlan";
            this.cmbIdPlan.Size = new System.Drawing.Size(95, 23);
            this.cmbIdPlan.TabIndex = 13;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.AutoSize = true;
            this.txtEspecialidad.Location = new System.Drawing.Point(10, 14);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(75, 15);
            this.txtEspecialidad.TabIndex = 14;
            this.txtEspecialidad.Text = "Especialidad:";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(100, 8);
            this.cmbEspecialidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(133, 23);
            this.cmbEspecialidad.TabIndex = 15;
            // 
            // Comision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 260);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.cmbIdPlan);
            this.Controls.Add(this.txtAnioEspecialidad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.txtDescripción);
            this.Controls.Add(this.dgvComisiones);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Comision";
            this.Text = "Comision";
            ((System.ComponentModel.ISupportInitialize)(this.dgvComisiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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