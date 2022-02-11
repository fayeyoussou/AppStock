using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using AppStock.Utilisateur;
using AppStock.Modeles;

namespace AppStock
{
    public partial class frmMDI : Form
    {
        private utilisateur u;
        public frmMDI(utilisateur u)
        {
            InitializeComponent();
            this.u = u;
            if (u.idRole == 1)
            {
                tsmcodification.Visible = false;
            }

        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer computer = new Computer();
            this.Width= computer.Screen.Bounds.Width;
            this.Height = computer.Screen.Bounds.Height;
            this.Location = new Point(0,0);
            //tsmcodification.Visible = false;
        }

        private void utilisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmUtilisateur f = new frmUtilisateur();
            f.MdiParent = this;
            f.Show();
            f.WindowState =FormWindowState.Maximized;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProfil f = new frmProfil(this.u);
            f.MdiParent=this;
            f.Show();
            f.WindowState=FormWindowState.Maximized;
        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConnexion f = new frmConnexion();
            f.Show();

        }
    }
}
