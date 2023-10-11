namespace AcademiaNet
{
    partial class menuProfesor
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
            linkLabel1 = new System.Windows.Forms.LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(171, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new System.Drawing.Point(171, 82);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new System.Drawing.Size(43, 15);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Cursos";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // menuProfesor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(440, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "menuProfesor";
            Text = "menuProfesor";
            Load += menuProfesor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}