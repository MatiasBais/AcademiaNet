namespace AcademiaNet
{
    partial class CursoProfesor
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
            dgvCursos = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            nupaño = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupaño).BeginInit();
            SuspendLayout();
            // 
            // dgvCursos
            // 
            dgvCursos.AllowUserToAddRows = false;
            dgvCursos.AllowUserToDeleteRows = false;
            dgvCursos.AllowUserToResizeRows = false;
            dgvCursos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Location = new System.Drawing.Point(12, 41);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.ReadOnly = true;
            dgvCursos.RowHeadersVisible = false;
            dgvCursos.RowTemplate.Height = 25;
            dgvCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCursos.Size = new System.Drawing.Size(447, 509);
            dgvCursos.TabIndex = 0;
            dgvCursos.CellDoubleClick += dgvCursos_CellDoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 15);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(35, 15);
            label1.TabIndex = 1;
            label1.Text = "Año: ";
            // 
            // nupaño
            // 
            nupaño.Location = new System.Drawing.Point(53, 12);
            nupaño.Maximum = new decimal(new int[] { 2050, 0, 0, 0 });
            nupaño.Minimum = new decimal(new int[] { 1970, 0, 0, 0 });
            nupaño.Name = "nupaño";
            nupaño.Size = new System.Drawing.Size(120, 23);
            nupaño.TabIndex = 2;
            nupaño.Value = new decimal(new int[] { 2023, 0, 0, 0 });
            nupaño.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // CursoProfesor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(471, 562);
            Controls.Add(nupaño);
            Controls.Add(label1);
            Controls.Add(dgvCursos);
            Name = "CursoProfesor";
            Text = "CursoProfesor";
            Load += CursoProfesor_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupaño).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupaño;
    }
}