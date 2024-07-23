namespace StockYearly
{
    partial class MainMenu
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
            this.StatStrip_NomServeur = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus_NomServeur = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_NomDataBase = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatStrip_NomServeur.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatStrip_NomServeur
            // 
            this.StatStrip_NomServeur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus_NomServeur,
            this.toolStripStatus_NomDataBase});
            this.StatStrip_NomServeur.Location = new System.Drawing.Point(0, 469);
            this.StatStrip_NomServeur.Name = "StatStrip_NomServeur";
            this.StatStrip_NomServeur.Size = new System.Drawing.Size(1173, 24);
            this.StatStrip_NomServeur.TabIndex = 8;
            this.StatStrip_NomServeur.Text = "Nom Serveur :";
            // 
            // toolStripStatus_NomServeur
            // 
            this.toolStripStatus_NomServeur.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatus_NomServeur.Name = "toolStripStatus_NomServeur";
            this.toolStripStatus_NomServeur.Size = new System.Drawing.Size(107, 19);
            this.toolStripStatus_NomServeur.Text = "Nom Serveur :";
            // 
            // toolStripStatus_NomDataBase
            // 
            this.toolStripStatus_NomDataBase.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.toolStripStatus_NomDataBase.Name = "toolStripStatus_NomDataBase";
            this.toolStripStatus_NomDataBase.Size = new System.Drawing.Size(137, 19);
            this.toolStripStatus_NomDataBase.Text = "Nom Base Données :";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 493);
            this.Controls.Add(this.StatStrip_NomServeur);
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.StatStrip_NomServeur.ResumeLayout(false);
            this.StatStrip_NomServeur.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.StatusStrip StatStrip_NomServeur;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatus_NomServeur;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatus_NomDataBase;
    }
}

