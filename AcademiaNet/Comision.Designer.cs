﻿namespace AcademiaNet
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
            components = new System.ComponentModel.Container();
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
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dgvComisiones).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(11, 77);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(158, 35);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(504, 77);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(158, 35);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Enabled = false;
            btnModificar.Location = new System.Drawing.Point(176, 77);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new System.Drawing.Size(158, 33);
            btnModificar.TabIndex = 2;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.Location = new System.Drawing.Point(341, 77);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new System.Drawing.Size(158, 35);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(398, 49);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(90, 20);
            label1.TabIndex = 4;
            label1.Text = "Descripción:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(11, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 20);
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
            dgvComisiones.Location = new System.Drawing.Point(11, 161);
            dgvComisiones.Name = "dgvComisiones";
            dgvComisiones.ReadOnly = true;
            dgvComisiones.RowHeadersVisible = false;
            dgvComisiones.RowHeadersWidth = 51;
            dgvComisiones.RowTemplate.Height = 29;
            dgvComisiones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvComisiones.Size = new System.Drawing.Size(649, 300);
            dgvComisiones.TabIndex = 6;
            dgvComisiones.CellClick += dgvComisiones_CellClick;
            dgvComisiones.CellDoubleClick += dgvComisiones_CellDoubleClick;
            // 
            // txtDescripción
            // 
            txtDescripción.Location = new System.Drawing.Point(503, 45);
            txtDescripción.Name = "txtDescripción";
            txtDescripción.Size = new System.Drawing.Size(157, 27);
            txtDescripción.TabIndex = 7;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new System.Drawing.Point(160, 117);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new System.Drawing.Size(500, 27);
            txtBuscar.TabIndex = 8;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(398, 13);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(40, 20);
            label3.TabIndex = 9;
            label3.Text = "Plan:";
            label3.Click += label3_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(11, 49);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(127, 20);
            label4.TabIndex = 10;
            label4.Text = "Año especialidad:";
            // 
            // txtAnioEspecialidad
            // 
            txtAnioEspecialidad.Location = new System.Drawing.Point(160, 45);
            txtAnioEspecialidad.Name = "txtAnioEspecialidad";
            txtAnioEspecialidad.Size = new System.Drawing.Size(167, 27);
            txtAnioEspecialidad.TabIndex = 12;
            // 
            // cmbIdPlan
            // 
            cmbIdPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbIdPlan.FormattingEnabled = true;
            cmbIdPlan.Location = new System.Drawing.Point(503, 12);
            cmbIdPlan.Name = "cmbIdPlan";
            cmbIdPlan.Size = new System.Drawing.Size(157, 28);
            cmbIdPlan.TabIndex = 13;
            cmbIdPlan.SelectedIndexChanged += cmbIdPlan_SelectedIndexChanged;
            cmbIdPlan.DataSourceChanged += cmbIdPlan_DataSourceChanged;
            cmbIdPlan.ValueMemberChanged += cmbIdPlan_ValueMemberChanged;
            cmbIdPlan.SelectedValueChanged += cmbIdPlan_SelectedValueChanged;
            // 
            // txtEspecialidad
            // 
            txtEspecialidad.AutoSize = true;
            txtEspecialidad.Location = new System.Drawing.Point(11, 15);
            txtEspecialidad.Name = "txtEspecialidad";
            txtEspecialidad.Size = new System.Drawing.Size(96, 20);
            txtEspecialidad.TabIndex = 14;
            txtEspecialidad.Text = "Especialidad:";
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new System.Drawing.Point(160, 11);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new System.Drawing.Size(167, 28);
            cmbEspecialidad.TabIndex = 15;
            cmbEspecialidad.SelectedIndexChanged += cmbEspecialidad_SelectedIndexChanged;
            cmbEspecialidad.SelectedValueChanged += cmbEspecialidad_SelectedValueChanged_1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Comision
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(675, 473);
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
        private System.Windows.Forms.Timer timer1;
    }
}