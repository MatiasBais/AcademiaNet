namespace AcademiaNet
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
            txbProf = new System.Windows.Forms.TextBox();
            txtProfCurso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvProf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProfCurso).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(333, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // dgvProf
            // 
            dgvProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProf.Location = new System.Drawing.Point(12, 97);
            dgvProf.Name = "dgvProf";
            dgvProf.RowHeadersWidth = 51;
            dgvProf.RowTemplate.Height = 29;
            dgvProf.Size = new System.Drawing.Size(371, 341);
            dgvProf.TabIndex = 1;
            // 
            // dgvProfCurso
            // 
            dgvProfCurso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProfCurso.Location = new System.Drawing.Point(489, 97);
            dgvProfCurso.Name = "dgvProfCurso";
            dgvProfCurso.RowHeadersWidth = 51;
            dgvProfCurso.RowTemplate.Height = 29;
            dgvProfCurso.Size = new System.Drawing.Size(371, 341);
            dgvProfCurso.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new System.Drawing.Point(389, 94);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new System.Drawing.Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar ->";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new System.Drawing.Point(389, 129);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new System.Drawing.Size(94, 29);
            btnQuitar.TabIndex = 4;
            btnQuitar.Text = "<- Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 38);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(81, 20);
            label2.TabIndex = 5;
            label2.Text = "Profesores:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(489, 38);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(145, 20);
            label3.TabIndex = 6;
            label3.Text = "Profesores del curso:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 67);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(54, 20);
            label4.TabIndex = 7;
            label4.Text = "Filtrar: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(489, 71);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(54, 20);
            label5.TabIndex = 8;
            label5.Text = "Filtrar: ";
            // 
            // txbProf
            // 
            txbProf.Location = new System.Drawing.Point(72, 64);
            txbProf.Name = "txbProf";
            txbProf.Size = new System.Drawing.Size(311, 27);
            txbProf.TabIndex = 9;
            // 
            // txtProfCurso
            // 
            txtProfCurso.Location = new System.Drawing.Point(549, 64);
            txtProfCurso.Name = "txtProfCurso";
            txtProfCurso.Size = new System.Drawing.Size(311, 27);
            txtProfCurso.TabIndex = 10;
            // 
            // CursoProfesores
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(871, 450);
            Controls.Add(txtProfCurso);
            Controls.Add(txbProf);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProfCurso);
            Controls.Add(dgvProf);
            Controls.Add(label1);
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
        private System.Windows.Forms.TextBox txbProf;
        private System.Windows.Forms.TextBox txtProfCurso;
    }
}