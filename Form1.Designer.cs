namespace Enfermeria
{
    partial class Inicio
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
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Agregar = new System.Windows.Forms.ToolStripMenuItem();
            this.dosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sssssToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ssssssToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionAutomaticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem,
            this.unoToolStripMenuItem,
            this.dosToolStripMenuItem,
            this.tresToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // unoToolStripMenuItem
            // 
            this.unoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Agregar});
            this.unoToolStripMenuItem.Name = "unoToolStripMenuItem";
            this.unoToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.unoToolStripMenuItem.Text = "Alumnos";
            // 
            // Agregar
            // 
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(116, 22);
            this.Agregar.Text = "Agregar";
            this.Agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // dosToolStripMenuItem
            // 
            this.dosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sssssToolStripMenuItem});
            this.dosToolStripMenuItem.Name = "dosToolStripMenuItem";
            this.dosToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.dosToolStripMenuItem.Text = "Busquedas";
            // 
            // sssssToolStripMenuItem
            // 
            this.sssssToolStripMenuItem.Name = "sssssToolStripMenuItem";
            this.sssssToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sssssToolStripMenuItem.Text = "Consultas";
            // 
            // tresToolStripMenuItem
            // 
            this.tresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssssssToolStripMenuItem1,
            this.asignacionAutomaticaToolStripMenuItem});
            this.tresToolStripMenuItem.Name = "tresToolStripMenuItem";
            this.tresToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.tresToolStripMenuItem.Text = "Asignar Rol";
            // 
            // ssssssToolStripMenuItem1
            // 
            this.ssssssToolStripMenuItem1.Name = "ssssssToolStripMenuItem1";
            this.ssssssToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.ssssssToolStripMenuItem1.Text = "Asignacion Manual";
            // 
            // asignacionAutomaticaToolStripMenuItem
            // 
            this.asignacionAutomaticaToolStripMenuItem.Name = "asignacionAutomaticaToolStripMenuItem";
            this.asignacionAutomaticaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.asignacionAutomaticaToolStripMenuItem.Text = "Asignacion Automatica";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 477);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Menu De Inicio";
          
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem unoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Agregar;
        private System.Windows.Forms.ToolStripMenuItem sssssToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ssssssToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionAutomaticaToolStripMenuItem;
    }
}

