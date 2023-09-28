namespace AcademiaNet
{
    partial class Login
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
            label2 = new System.Windows.Forms.Label();
            txtNombreUsuario = new System.Windows.Forms.TextBox();
            txtClave = new System.Windows.Forms.TextBox();
            btnIngresar = new System.Windows.Forms.Button();
            btnCancelar = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 12);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 51);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Clave:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new System.Drawing.Point(78, 8);
            txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new System.Drawing.Size(124, 27);
            txtNombreUsuario.TabIndex = 2;
            // 
            // txtClave
            // 
            txtClave.Location = new System.Drawing.Point(78, 47);
            txtClave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtClave.Name = "txtClave";
            txtClave.Size = new System.Drawing.Size(124, 27);
            txtClave.TabIndex = 3;
            txtClave.UseSystemPasswordChar = true;
            txtClave.KeyPress += txtClave_KeyPress;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new System.Drawing.Point(14, 85);
            btnIngresar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new System.Drawing.Size(86, 31);
            btnIngresar.TabIndex = 4;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new System.Drawing.Point(117, 85);
            btnCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new System.Drawing.Size(86, 31);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(216, 132);
            Controls.Add(btnCancelar);
            Controls.Add(btnIngresar);
            Controls.Add(txtClave);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
    }
}