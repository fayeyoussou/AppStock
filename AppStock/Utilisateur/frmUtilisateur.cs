using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppStock.App_Code;
using AppStock.Modeles;

namespace AppStock.Utilisateur
{
    public partial class frmUtilisateur : Form
    {
        bdStockEntities bd = new bdStockEntities();
        public frmUtilisateur()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            List<utilisateur> ulist= bd.utilisateur.ToList();
            
            utilisateur u = new utilisateur();
            //Helper helper = new Helper();
            lblEmail.Text = "";
            bool exist = ulist.Where(a => a.identifiant.ToUpper().Trim() == txtIdentifiant.Text.ToUpper().Trim()).Count() > 0;
            //lblEmail.Text = exist.ToString();
            bool isnotvalid = !Helper.IsValidEmail(txtEmail.Text);
            
            if (isnotvalid || exist) {
                if (isnotvalid) lblEmail.Text = "Email invalid ";
                if (isnotvalid && exist) lblEmail.Text += " et "; 
                if (exist) lblEmail.Text += "utilisateur existe deja";
            }            
            else
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    u.identifiant = txtIdentifiant.Text;
                    u.email = txtEmail.Text;
                    u.motDePasse = Helper.getMd5Hash("passer123");
                    u.status = "O";
                    u.role();
                    bd.utilisateur.Add(u);
                    bd.SaveChanges();
                    effacer();
                }
            }
        }
        private void effacer()
        {
            txtEmail.Text = "";
            txtIdentifiant.Text = "";
            txtIdentifiant.Focus();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            effacer();
        }
    }
}
