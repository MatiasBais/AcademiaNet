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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            administrarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            administrarTiposDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            especialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            administrarEspecialidadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            administrarPlanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            comisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            administrarComisionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { personasToolStripMenuItem, especialidadesToolStripMenuItem, comisionesToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { administrarPersonasToolStripMenuItem, administrarTiposDeUsuarioToolStripMenuItem });
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            personasToolStripMenuItem.Text = "Personas";
            // 
            // administrarPersonasToolStripMenuItem
            // 
            administrarPersonasToolStripMenuItem.Name = "administrarPersonasToolStripMenuItem";
            administrarPersonasToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            administrarPersonasToolStripMenuItem.Text = "Administrar Personas";
            administrarPersonasToolStripMenuItem.Click += administrarPersonasToolStripMenuItem_Click;
            // 
            // administrarTiposDeUsuarioToolStripMenuItem
            // 
            administrarTiposDeUsuarioToolStripMenuItem.Name = "administrarTiposDeUsuarioToolStripMenuItem";
            administrarTiposDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            administrarTiposDeUsuarioToolStripMenuItem.Text = "Administrar Tipos de Usuario";
            administrarTiposDeUsuarioToolStripMenuItem.Click += administrarTiposDeUsuarioToolStripMenuItem_Click;
            // 
            // especialidadesToolStripMenuItem
            // 
            especialidadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { administrarEspecialidadesToolStripMenuItem, administrarPlanesToolStripMenuItem });
            especialidadesToolStripMenuItem.Name = "especialidadesToolStripMenuItem";
            especialidadesToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            especialidadesToolStripMenuItem.Text = "Especialidades";
            // 
            // administrarEspecialidadesToolStripMenuItem
            // 
            administrarEspecialidadesToolStripMenuItem.Name = "administrarEspecialidadesToolStripMenuItem";
            administrarEspecialidadesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            administrarEspecialidadesToolStripMenuItem.Text = "Administrar Especialidades";
            administrarEspecialidadesToolStripMenuItem.Click += administrarEspecialidadesToolStripMenuItem_Click;
            // 
            // administrarPlanesToolStripMenuItem
            // 
            administrarPlanesToolStripMenuItem.Name = "administrarPlanesToolStripMenuItem";
            administrarPlanesToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            administrarPlanesToolStripMenuItem.Text = "Administrar Planes";
            administrarPlanesToolStripMenuItem.Click += administrarPlanesToolStripMenuItem_Click;
            // 
            // comisionesToolStripMenuItem
            // 
            comisionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { administrarComisionesToolStripMenuItem });
            comisionesToolStripMenuItem.Name = "comisionesToolStripMenuItem";
            comisionesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            comisionesToolStripMenuItem.Text = "Comisiones";
            comisionesToolStripMenuItem.Click += comisionesToolStripMenuItem_Click;
            // 
            // administrarComisionesToolStripMenuItem
            // 
            administrarComisionesToolStripMenuItem.Name = "administrarComisionesToolStripMenuItem";
            administrarComisionesToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            administrarComisionesToolStripMenuItem.Text = "Administrar Comisiones";
            administrarComisionesToolStripMenuItem.Click += administrarComisionesToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem administrarTiposDeUsuarioToolStripMenuItem;
    }
}