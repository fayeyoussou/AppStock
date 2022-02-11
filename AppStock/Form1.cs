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

namespace AppStock
{
    public partial class Form1 : Form
    { 
        bdStockEntities bd = new bdStockEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            produit p = new produit();
            p.libelle = txtLibelle.Text;
            p.description = txtDescription.Text;
            //p.prixUProduit = double.Parse(txtPU.Text);
            //p.qteProduit = double.Parse(txtQte.Text);
            //bd.produits.Add(p);
            //bd.SaveChanges();
            effacer();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgProduit.DataSource = bd.produit.ToList();
        }
        private void effacer()
        {
            txtPU.Text= txtDescription.Text = txtQte.Text= txtLibelle.Text = "";
            dgProduit.DataSource = bd.produit.ToList();
            txtLibelle.Focus(); 
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            
            produit p = bd.produit.Find(id);
            p.libelle = txtLibelle.Text;
            p.description = txtDescription.Text;
            //p.prixUProduit = double.Parse(txtPU.Text);
            //p.qteProduit = double.Parse(txtQte.Text);
            bd.SaveChanges();
            effacer();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int? id = int.Parse(dgProduit.CurrentRow.Cells[0].Value.ToString());
            produit p = bd.produit.Find(id);
            bd.produit.Remove(p);
            bd.SaveChanges();
            effacer();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            txtPU.Text = dgProduit.CurrentRow.Cells[4].Value.ToString(); 
            txtDescription.Text = dgProduit.CurrentRow.Cells[2].Value.ToString(); 
            txtQte.Text = dgProduit.CurrentRow.Cells[3].Value.ToString(); 
            txtLibelle.Text = dgProduit.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            var liste = bd.produit.ToList();
            if (!String.IsNullOrEmpty(txtRLibele.Text))
            {
                liste = liste.Where(a =>a.libelle.ToUpper().Contains(txtRLibele.Text.ToUpper())).ToList();
            }
            if (!String.IsNullOrEmpty(txtRDesc.Text))
            {
                liste = liste.Where(a => a.libelle.ToUpper().Contains(txtRDesc.Text.ToUpper())).ToList();
            }
            if (!String.IsNullOrEmpty(txtRSInf.Text))
            {
                double Qte = double.Parse(txtRSInf.Text);
                //liste = liste.Where(a => a.qteProduit < Qte).ToList();
            }
            if (!String.IsNullOrEmpty(txtRSSup.Text))
            {
                double Qte = double.Parse(txtRSSup.Text);
                //liste = liste.Where(a => a.qteProduit > Qte).ToList();
            }
            dgProduit.DataSource = liste;
        }
    }
}
