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
            this.administrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutCategorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajoutProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seConnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionToolStripMenuItem,
            this.administrationToolStripMenuItem,
            this.codificationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // actionToolStripMenuItem
            // 
            this.actionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seDeconnecterToolStripMenuItem,
            this.quitterToolStripMenuItem,
            this.seConnecterToolStripMenuItem});
            this.actionToolStripMenuItem.Name = "actionToolStripMenuItem";
            this.actionToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.actionToolStripMenuItem.Text = "Action";
            // 
            // seDeconnecterToolStripMenuItem
            // 
            this.seDeconnecterToolStripMenuItem.Name = "seDeconnecterToolStripMenuItem";
            this.seDeconnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seDeconnecterToolStripMenuItem.Text = "Se Deconnecter";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // administrationToolStripMenuItem
            // 
            this.administrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilisateurToolStripMenuItem});
            this.administrationToolStripMenuItem.Name = "administrationToolStripMenuItem";
            this.administrationToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.administrationToolStripMenuItem.Text = "Administration";
            // 
            // utilisateurToolStripMenuItem
            // 
            this.utilisateurToolStripMenuItem.Name = "utilisateurToolStripMenuItem";
            this.utilisateurToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utilisateurToolStripMenuItem.Text = "Ajout utilisateur";
            this.utilisateurToolStripMenuItem.Click += new System.EventHandler(this.utilisateurToolStripMenuItem_Click);
            // 
            // codificationToolStripMenuItem
            // 
            this.codificationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajoutCategorieToolStripMenuItem,
            this.listeCategoriesToolStripMenuItem,
            this.ajoutProduitToolStripMenuItem,
            this.listeProduitToolStripMenuItem});
            this.codificationToolStripMenuItem.Name = "codificationToolStripMenuItem";
            this.codificationToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.codificationToolStripMenuItem.Text = "codification";
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
            // seConnecterToolStripMenuItem
            // 
            this.seConnecterToolStripMenuItem.Name = "seConnecterToolStripMenuItem";
            this.seConnecterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.seConnecterToolStripMenuItem.Text = "Se Connecter";
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
        private System.Windows.Forms.ToolStripMenuItem administrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutCategorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajoutProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seConnecterToolStripMenuItem;
    }
}