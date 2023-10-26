namespace AcademiaNet
{
    partial class EstadoAcademico
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
            dgvEstadoAcademico = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvEstadoAcademico).BeginInit();
            SuspendLayout();
            // 
            // dgvEstadoAcademico
            // 
            dgvEstadoAcademico.AllowUserToAddRows = false;
            dgvEstadoAcademico.AllowUserToDeleteRows = false;
            dgvEstadoAcademico.AllowUserToResizeRows = false;
            dgvEstadoAcademico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstadoAcademico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstadoAcademico.Location = new System.Drawing.Point(11, 60);
            dgvEstadoAcademico.Name = "dgvEstadoAcademico";
            dgvEstadoAcademico.ReadOnly = true;
            dgvEstadoAcademico.RowHeadersVisible = false;
            dgvEstadoAcademico.RowHeadersWidth = 51;
            dgvEstadoAcademico.RowTemplate.Height = 29;
            dgvEstadoAcademico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvEstadoAcademico.Size = new System.Drawing.Size(1255, 403);
            dgvEstadoAcademico.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(352, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 20);
            label1.TabIndex = 1;
            label1.Text = "Estado academico de: ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(561, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new System.Drawing.Point(1172, 24);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new System.Drawing.Size(94, 29);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // EstadoAcademico
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1296, 475);
            Controls.Add(btnImprimir);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEstadoAcademico);
            Name = "EstadoAcademico";
            Text = "EstadoAcademico";
            Load += EstadoAcademico_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEstadoAcademico).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstadoAcademico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimir;
    }
}