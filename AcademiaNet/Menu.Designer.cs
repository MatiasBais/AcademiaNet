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
            especialidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            planesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            comisionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { personasToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            menuStrip1.Size = new System.Drawing.Size(433, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // personasToolStripMenuItem
            // 
            personasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { administrarPersonasToolStripMenuItem, especialidadesToolStripMenuItem1, planesToolStripMenuItem, comisionesToolStripMenuItem1 });
            personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            personasToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            personasToolStripMenuItem.Text = "Administrar";
            // 
            // administrarPersonasToolStripMenuItem
            // 
            administrarPersonasToolStripMenuItem.Name = "administrarPersonasToolStripMenuItem";
            administrarPersonasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            administrarPersonasToolStripMenuItem.Text = "Personas";
            administrarPersonasToolStripMenuItem.Click += administrarPersonasToolStripMenuItem_Click;
            // 
            // especialidadesToolStripMenuItem1
            // 
            especialidadesToolStripMenuItem1.Name = "especialidadesToolStripMenuItem1";
            especialidadesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            especialidadesToolStripMenuItem1.Text = "Especialidades";
            especialidadesToolStripMenuItem1.Click += especialidadesToolStripMenuItem1_Click;
            // 
            // planesToolStripMenuItem
            // 
            planesToolStripMenuItem.Name = "planesToolStripMenuItem";
            planesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            planesToolStripMenuItem.Text = "Planes";
            planesToolStripMenuItem.Click += planesToolStripMenuItem_Click;
            // 
            // comisionesToolStripMenuItem1
            // 
            comisionesToolStripMenuItem1.Name = "comisionesToolStripMenuItem1";
            comisionesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            comisionesToolStripMenuItem1.Text = "Comisiones";
            comisionesToolStripMenuItem1.Click += comisionesToolStripMenuItem1_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(433, 341);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem planesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comisionesToolStripMenuItem1;
    }
}