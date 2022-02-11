namespace AppStock
{
    partial class frmMDI
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
            this.actionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDeconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAdministration = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmcodification = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutCategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmventes = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleVenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voirMesFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeProduitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmlivraison = new System.Windows.Forms.ToolStripMenuItem();
            this.voirLesFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validerLivraisonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listerUtilisateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.tsmAdministration,
            this.tsmcodification,
            this.tsmventes,
            this.tsmlivraison});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilToolStripMenuItem,
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seDeconnecterToolStripMenuItem.Text = "Se Deconnecter";
            this.seDeconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDeconnecterToolStripMenuItem_Click);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // tsmAdministration
            // 
            this.tsmAdministration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem,
            this.listerUtilisateursToolStripMenuItem});
            this.tsmAdministration.Name = "tsmAdministration";
            this.tsmAdministration.Size = new System.Drawing.Size(98, 20);
            this.tsmAdministration.Text = "Administration";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utilisateurToolStripMenuItem.Text = "Ajout utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // tsmcodification
            // 
            this.tsmcodification.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutCategorieToolStripMenuItem,
            this.listeCategoriesToolStripMenuItem,
            this.ajoutProduitToolStripMenuItem,
            this.listeProduitToolStripMenuItem});
            this.tsmcodification.Name = "tsmcodification";
            this.tsmcodification.Size = new System.Drawing.Size(82, 20);
            this.tsmcodification.Text = "codification";
            // 
            // ajoutCategorieToolStripMenuItem
            // 
            this.ajoutCategorieToolStripMenuItem.Name = "ajoutCategorieToolStripMenuItem";
            this.ajoutCategorieToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajoutCategorieToolStripMenuItem.Text = "Ajout Categorie";
            // 
            // listeCategoriesToolStripMenuItem
            // 
            this.listeCategoriesToolStripMenuItem.Name = "listeCategoriesToolStripMenuItem";
            this.listeCategoriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeCategoriesToolStripMenuItem.Text = "Liste Categories";
            // 
            // ajoutProduitToolStripMenuItem
            // 
            this.ajoutProduitToolStripMenuItem.Name = "ajoutProduitToolStripMenuItem";
            this.ajoutProduitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ajoutProduitToolStripMenuItem.Text = "Ajout Produit";
            // 
            // listeProduitToolStripMenuItem
            // 
            this.listeProduitToolStripMenuItem.Name = "listeProduitToolStripMenuItem";
            this.listeProduitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listeProduitToolStripMenuItem.Text = "liste produit";
            // 
            // tsmventes
            // 
            this.tsmventes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvelleVenteToolStripMenuItem,
            this.voirMesFactureToolStripMenuItem,
            this.listeProduitToolStripMenuItem1});
            this.tsmventes.Name = "tsmventes";
            this.tsmventes.Size = new System.Drawing.Size(53, 20);
            this.tsmventes.Text = "ventes";
            // 
            // nouvelleVenteToolStripMenuItem
            // 
            this.nouvelleVenteToolStripMenuItem.Name = "nouvelleVenteToolStripMenuItem";
            this.nouvelleVenteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nouvelleVenteToolStripMenuItem.Text = "nouvelle vente";
            // 
            // voirMesFactureToolStripMenuItem
            // 
            this.voirMesFactureToolStripMenuItem.Name = "voirMesFactureToolStripMenuItem";
            this.voirMesFactureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voirMesFactureToolStripMenuItem.Text = "voir mes facture";
            // 
            // listeProduitToolStripMenuItem1
            // 
            this.listeProduitToolStripMenuItem1.Name = "listeProduitToolStripMenuItem1";
            this.listeProduitToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listeProduitToolStripMenuItem1.Text = "liste produit";
            // 
            // tsmlivraison
            // 
            this.tsmlivraison.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voirLesFacturesToolStripMenuItem,
            this.validerLivraisonsToolStripMenuItem});
            this.tsmlivraison.Name = "tsmlivraison";
            this.tsmlivraison.Size = new System.Drawing.Size(63, 20);
            this.tsmlivraison.Text = "livraison";
            // 
            // voirLesFacturesToolStripMenuItem
            // 
            this.voirLesFacturesToolStripMenuItem.Name = "voirLesFacturesToolStripMenuItem";
            this.voirLesFacturesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voirLesFacturesToolStripMenuItem.Text = "voir les factures";
            // 
            // validerLivraisonsToolStripMenuItem
            // 
            this.validerLivraisonsToolStripMenuItem.Name = "validerLivraisonsToolStripMenuItem";
            this.validerLivraisonsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.validerLivraisonsToolStripMenuItem.Text = "valider livraisons";
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.profilToolStripMenuItem.Text = "profil";
            this.profilToolStripMenuItem.Click += new System.EventHandler(this.profilToolStripMenuItem_Click);
            // 
            // listerUtilisateursToolStripMenuItem
            // 
            this.listerUtilisateursToolStripMenuItem.Name = "listerUtilisateursToolStripMenuItem";
            this.listerUtilisateursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listerUtilisateursToolStripMenuItem.Text = "Lister utilisateurs";
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "Gestion Stock";
            this.Load += new System.EventHandler(this.frmMDI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem actionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDeconnecterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmAdministration;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmcodification;
        private System.Windows.Forms.ToolStripMenuItem ajoutCategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmventes;
        private System.Windows.Forms.ToolStripMenuItem nouvelleVenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voirMesFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeProduitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmlivraison;
        private System.Windows.Forms.ToolStripMenuItem voirLesFacturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validerLivraisonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listerUtilisateursToolStripMenuItem;
    }
}