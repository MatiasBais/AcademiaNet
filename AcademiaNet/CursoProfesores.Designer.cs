﻿namespace AcademiaNet
{
    partial class CursoProfesores
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
            label1 = new System.Windows.Forms.Label();
            dgvProf = new System.Windows.Forms.DataGridView();
            dgvProfCurso = new System.Windows.Forms.DataGridView();
            btnAgregar = new System.Windows.Forms.Button();
            btnQuitar = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            txtProf = new System.Windows.Forms.TextBox();
            txtProfCurso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfCurso).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(291, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dgvProf
            // 
            dgvProf.AllowUserToAddRows = false;
            dgvProf.AllowUserToDeleteRows = false;
            dgvProf.AllowUserToResizeRows = false;
            dgvProf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProf.Location = new System.Drawing.Point(10, 73);
            dgvProf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvProf.Name = "dgvProf";
            dgvProf.ReadOnly = true;
            dgvProf.RowHeadersVisible = false;
            dgvProf.RowHeadersWidth = 51;
            dgvProf.RowTemplate.Height = 29;
            dgvProf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProf.Size = new System.Drawing.Size(325, 256);
            dgvProf.TabIndex = 1;
            // 
            // dgvProfCurso
            // 
            dgvProfCurso.AllowUserToAddRows = false;
            dgvProfCurso.AllowUserToDeleteRows = false;
            dgvProfCurso.AllowUserToResizeRows = false;
            dgvProfCurso.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvProfCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfCurso.Location = new System.Drawing.Point(428, 73);
            dgvProfCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dgvProfCurso.Name = "dgvProfCurso";
            dgvProfCurso.ReadOnly = true;
            dgvProfCurso.RowHeadersVisible = false;
            dgvProfCurso.RowHeadersWidth = 51;
            dgvProfCurso.RowTemplate.Height = 29;
            dgvProfCurso.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvProfCurso.Size = new System.Drawing.Size(325, 256);
            dgvProfCurso.TabIndex = 2;
            dgvProfCurso.CellDoubleClick += dgvProfCurso_CellDoubleClick;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(340, 70);
            btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(82, 22);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar ->";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new System.Drawing.Point(340, 97);
            btnQuitar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new System.Drawing.Size(82, 22);
            btnQuitar.TabIndex = 4;
            btnQuitar.Text = "<- Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(65, 15);
            label2.TabIndex = 5;
            label2.Text = "Profesores:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(428, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(116, 15);
            label3.TabIndex = 6;
            label3.Text = "Profesores del curso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(10, 50);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(43, 15);
            label4.TabIndex = 7;
            label4.Text = "Filtrar: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(428, 53);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(43, 15);
            label5.TabIndex = 8;
            label5.Text = "Filtrar: ";
            // 
            // txtProf
            // 
            txtProf.Location = new System.Drawing.Point(63, 48);
            txtProf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtProf.Name = "txtProf";
            txtProf.Size = new System.Drawing.Size(273, 23);
            txtProf.TabIndex = 9;
            txtProf.TextChanged += txtProf_TextChanged;
            // 
            // txtProfCurso
            // 
            txtProfCurso.Location = new System.Drawing.Point(480, 48);
            txtProfCurso.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            txtProfCurso.Name = "txtProfCurso";
            txtProfCurso.Size = new System.Drawing.Size(273, 23);
            txtProfCurso.TabIndex = 10;
            txtProfCurso.TextChanged += txtProfCurso_TextChanged;
            // 
            // CursoProfesores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(762, 338);
            Controls.Add(txtProfCurso);
            Controls.Add(txtProf);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProfCurso);
            Controls.Add(dgvProf);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "CursoProfesores";
            Text = "CursoProfesores";
            Load += CursoProfesores_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProf).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfCurso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProf;
        private System.Windows.Forms.DataGridView dgvProfCurso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProf;
        private System.Windows.Forms.TextBox txtProfCurso;
    }
}