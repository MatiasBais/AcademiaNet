namespace AcademiaNet
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarPlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarComisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.especialidadesToolStripMenuItem,
            this.comisionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarPersonasToolStripMenuItem});
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.personasToolStripMenuItem.Text = "Personas";
            // 
            // administrarPersonasToolStripMenuItem
            // 
            this.administrarPersonasToolStripMenuItem.Name = "administrarPersonasToolStripMenuItem";
            this.administrarPersonasToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.administrarPersonasToolStripMenuItem.Text = "Administrar Personas";
            this.administrarPersonasToolStripMenuItem.Click += new System.EventHandler(this.administrarPersonasToolStripMenuItem_Click);
            // 
            // especialidadesToolStripMenuItem
            // 
            this.especialidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarEspecialidadesToolStripMenuItem,
            this.administrarPlanesToolStripMenuItem});
            this.especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            this.especialidadesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.especialidadesToolStripMenuItem.Text = "Especialidades";
            // 
            // administrarEspecialidadesToolStripMenuItem
            // 
            this.administrarEspecialidadesToolStripMenuItem.Name = "administrarEspecialidadesToolStripMenuItem";
            this.administrarEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.administrarEspecialidadesToolStripMenuItem.Text = "Administrar Especialidades";
            this.administrarEspecialidadesToolStripMenuItem.Click += new System.EventHandler(this.administrarEspecialidadesToolStripMenuItem_Click);
            // 
            // administrarPlanesToolStripMenuItem
            // 
            this.administrarPlanesToolStripMenuItem.Name = "administrarPlanesToolStripMenuItem";
            this.administrarPlanesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.administrarPlanesToolStripMenuItem.Text = "Administrar Planes";
            this.administrarPlanesToolStripMenuItem.Click += new System.EventHandler(this.administrarPlanesToolStripMenuItem_Click);
            // 
            // comisionesToolStripMenuItem
            // 
            this.comisionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarComisionesToolStripMenuItem});
            this.comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            this.comisionesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.comisionesToolStripMenuItem.Text = "Comisiones";
            // 
            // administrarComisionesToolStripMenuItem
            // 
            this.administrarComisionesToolStripMenuItem.Name = "administrarComisionesToolStripMenuItem";
            this.administrarComisionesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.administrarComisionesToolStripMenuItem.Text = "Administrar Comisiones";
            this.administrarComisionesToolStripMenuItem.Click += new System.EventHandler(this.administrarComisionesToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarEspecialidadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPlanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarComisionesToolStripMenuItem;
    }
}