using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppStock.Modeles;
using AppStock.App_Code;


namespace AppStock
{
    public partial class frmProfil : Form
    {
        private utilisateur user;
        private bdStockEntities bd = new bdStockEntities();
        public frmProfil(utilisateur user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void frmProfil_Load(object sender, EventArgs e)
        {
            hideProfilForm();
            hidePassForm();
            updateUser();
            
        }
        private void updateUser()
        {
            lblNomPrenom.Text = this.user.prenom + " " + this.user.nom + " (" + bd.role.ToList().Where(r => r.id == this.user.idRole).FirstOrDefault().nom + ")";
            lblAdresse.Text = "Adresse : " + this.user.adresse;
            lblIdentifiant.Text = "Username : " + this.user.identifiant;
            lblEmail.Text = "Email : " + this.user.email;
            lblTel.Text = "Tel :" + this.user.telephone;
        }
        private void hideProfilForm()
        {
            txtAdresse.Visible = false;
            txtEmail.Visible = false;
            txtIdentifiant.Visible = false;
            txtNom.Visible = false;
            txtPrenom.Visible = false;
            txtTel.Visible = false;
            btnValiderProfil.Visible = false;
            btnModifier.Visible = true;
        }
        private void showProfilForm()
        {
            txtAdresse.Text = this.user.adresse;
            txtAdresse.Visible = true;
            txtEmail.Text = this.user.email;
            txtEmail.Visible = true;
            txtIdentifiant.Text = this.user.identifiant;
            txtIdentifiant.Visible = true;
            txtNom.Text = this.user.nom;
            txtNom.Visible = true;
            txtPrenom.Text = this.user.prenom;
            txtPrenom.Visible = true;
            txtTel.Text = this.user.telephone;
            txtTel.Visible = true;
            btnValiderProfil.Visible = true;
            btnModifier.Visible = false;
        }
        private void hidePassForm()
        {
            btnVPassword.Visible = false;
            txtOPass.Visible = false;
            txtNPass.Visible = false;
            txtRPass.Visible = false;
            lblNP.Visible = false;
            lblOP.Visible = false;
            lblRP.Visible = false;
            btnCPass.Visible = true;
        }
        private void showPassForm()
        {
            btnVPassword.Visible = true;
            txtOPass.Visible = true;
            txtNPass.Visible = true;
            txtRPass.Visible = true;
            lblNP.Visible = true;
            lblOP.Visible = true;
            lblRP.Visible = true;
            btnCPass.Visible = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            showProfilForm();
            hidePassForm();
        }

        private void btnValiderProfil_Click(object sender, EventArgs e)
        {
            utilisateur u = bd.utilisateur.Find(this.user.idUtilisateur);
            
            u.adresse = txtAdresse.Text;
            u.email = Helper.IsValidEmail(txtEmail.Text)?txtEmail.Text: this.user.email;
            u.telephone = txtTel.Text.StartsWith("7") && txtTel.Text.Length == 9 ? txtTel.Text : this.user.telephone;
            u.identifiant = Helper.existID(txtIdentifiant.Text) ? this.user.identifiant : txtIdentifiant.Text;
            u.prenom = txtPrenom.Text.Trim().Length > 3 ? txtPrenom.Text.Trim() : this.user.prenom;
            u.nom = txtNom.Text.Trim().Length > 3 ? txtNom.Text.Trim():this.user.nom;
            bd.SaveChanges();
            this.user = u;
            updateUser();
            hideProfilForm();
        }

        private void btnCPass_Click(object sender, EventArgs e)
        {
            showPassForm();
            hideProfilForm();
        }

        private void btnVPassword_Click(object sender, EventArgs e)
        {
            utilisateur u = bd.utilisateur.Find(this.user.idUtilisateur);
            if (Helper.verifyMd5Hash(txtOPass.Text.Trim(), this.user.motDePasse.Trim()) && txtNPass.Text == txtRPass.Text)
            {
                u.motDePasse = Helper.getMd5Hash(txtNPass.Text);
                bd.SaveChanges();
            }
        }
    }
}
