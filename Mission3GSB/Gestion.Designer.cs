namespace Mission3GSB
{
    partial class Gestion
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterUnRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierUnRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualiserUnRapportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnRapportToolStripMenuItem,
            this.modifierUnRapportToolStripMenuItem,
            this.visualiserUnRapportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterUnRapportToolStripMenuItem
            // 
            this.ajouterUnRapportToolStripMenuItem.Name = "ajouterUnRapportToolStripMenuItem";
            this.ajouterUnRapportToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.ajouterUnRapportToolStripMenuItem.Text = "Ajouter un rapport";
            this.ajouterUnRapportToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnRapportToolStripMenuItem_Click);
            // 
            // modifierUnRapportToolStripMenuItem
            // 
            this.modifierUnRapportToolStripMenuItem.Name = "modifierUnRapportToolStripMenuItem";
            this.modifierUnRapportToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.modifierUnRapportToolStripMenuItem.Text = "Modifier un rapport ";
            this.modifierUnRapportToolStripMenuItem.Click += new System.EventHandler(this.modifierUnRapportToolStripMenuItem_Click);
            // 
            // visualiserUnRapportToolStripMenuItem
            // 
            this.visualiserUnRapportToolStripMenuItem.Name = "visualiserUnRapportToolStripMenuItem";
            this.visualiserUnRapportToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.visualiserUnRapportToolStripMenuItem.Text = "Visualiser un rapport ";
            this.visualiserUnRapportToolStripMenuItem.Click += new System.EventHandler(this.visualiserUnRapportToolStripMenuItem_Click);
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 489);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Gestion";
            this.Text = "Gestion des rapports ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierUnRapportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualiserUnRapportToolStripMenuItem;
    }
}

