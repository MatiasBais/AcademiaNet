﻿namespace AcademiaNet
{
    partial class InscripcionesPorCurso
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
            dgvInscripciones = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            btnAceptar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            cbxCondicion = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            nudNota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNota).BeginInit();
            SuspendLayout();
            // 
            // dgvInscripciones
            // 
            dgvInscripciones.AllowUserToAddRows = false;
            dgvInscripciones.AllowUserToDeleteRows = false;
            dgvInscripciones.AllowUserToResizeRows = false;
            dgvInscripciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvInscripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInscripciones.Location = new System.Drawing.Point(12, 70);
            dgvInscripciones.Name = "dgvInscripciones";
            dgvInscripciones.ReadOnly = true;
            dgvInscripciones.RowHeadersVisible = false;
            dgvInscripciones.RowTemplate.Height = 25;
            dgvInscripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvInscripciones.Size = new System.Drawing.Size(495, 368);
            dgvInscripciones.TabIndex = 0;
            dgvInscripciones.CellClick += dgvInscripciones_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Condición:";
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Location = new System.Drawing.Point(12, 41);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new System.Drawing.Size(244, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new System.Drawing.Point(262, 41);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(243, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cbxCondicion
            // 
            cbxCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbxCondicion.Enabled = false;
            cbxCondicion.FormattingEnabled = true;
            cbxCondicion.Items.AddRange(new object[] { "Inscripto", "Regular", "Aprobado" });
            cbxCondicion.Location = new System.Drawing.Point(83, 12);
            cbxCondicion.Name = "cbxCondicion";
            cbxCondicion.Size = new System.Drawing.Size(173, 23);
            cbxCondicion.TabIndex = 5;
            cbxCondicion.SelectedIndexChanged += cbxCondicion_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(262, 15);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 15);
            label2.TabIndex = 7;
            label2.Text = "Nota:";
            // 
            // nudNota
            // 
            nudNota.Enabled = false;
            nudNota.Location = new System.Drawing.Point(332, 12);
            nudNota.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudNota.Name = "nudNota";
            nudNota.Size = new System.Drawing.Size(173, 23);
            nudNota.TabIndex = 8;
            // 
            // InscripcionesPorCurso
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(517, 450);
            Controls.Add(nudNota);
            Controls.Add(label2);
            Controls.Add(cbxCondicion);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label1);
            Controls.Add(dgvInscripciones);
            Name = "InscripcionesPorCurso";
            Text = "Inscripciones";
            Load += InscripcionesPorCurso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInscripciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNota).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInscripciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cbxCondicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudNota;
    }
}