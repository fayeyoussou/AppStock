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
using System.Security.Cryptography;

namespace AppStock
{
    public partial class frmConnexion : Form
    {
        private bdStockEntities bd = new bdStockEntities();
        public frmConnexion()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            String pass = Helper.getMd5Hash("passer123");
            bool rep = false;
            var leUser = bd.utilisateur.Where(a=>a.identifiant==txtIdentifiant.Text.Trim()).FirstOrDefault();
            if (leUser != null)
            {
                using (MD5 md5Hash = MD5.Create())
                {
                    rep = Helper.verifyMd5Hash(txtPassword.Text.Trim(), leUser.motDePasse.Trim());
                }
            }
            if (rep)
            {
                frmMDI f = new frmMDI();
                f.Show();
                this.Hide();
            }
            else lblMessage.Text = "mot de passe ou identifiant incorrect";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
