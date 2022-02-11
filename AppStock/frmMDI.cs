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

namespace AppStock
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            Computer computer = new Computer();
            this.Width= computer.Screen.Bounds.Width;
            this.Height = computer.Screen.Bounds.Height;
            this.Location = new Point(0,0);
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
    }
}
