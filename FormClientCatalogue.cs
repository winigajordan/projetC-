using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesCom.service;
using GesCom.fabrique;
using GesCom.dto;
using GesCom.utils;

namespace GesCom
{
    public partial class FormClientCatalogue : Form
    {
        private IService service = Fabrique.getInstanceService();
       // private IService service2 = Fabrique.getInstanceService();

        private List<Panier> paniers = new List<Panier>(100);
        Produit produitSelectionne;

        User userConnect;

        


        public FormClientCatalogue(User user)
        {
            userConnect = user;
            InitializeComponent();
            laodTgdvProduit();
            textDetailLibelle.Enabled = false;
            textDetailPrix.Enabled = false;
            textDetailDescription.Enabled = false;
            prixProduitForPanier.Text = "0";
            prixProduitForPanier.Enabled = false;
            


        }

        public void laodTgdvProduit()
        {
            dgvCatalogue.AutoGenerateColumns = false;
            dgvCatalogue.ReadOnly = false;
            dgvCatalogue.DataSource = service.getAllProduct().ToArray();
            dgvCatalogue.AllowUserToAddRows = false;
            dgvCatalogue.AllowUserToDeleteRows = false;
            dgvCatalogue.ReadOnly = true;
        }

        private void dgvCatalogue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        public void loadFiel()
        {
            if (dgvCatalogue.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {

                textDetailLibelle.Text = dgvCatalogue.SelectedRows[0].Cells[1].Value.ToString();
                textDetailPrix.Text = dgvCatalogue.SelectedRows[0].Cells[2].Value.ToString();
                textDetailDescription.Text = dgvCatalogue.SelectedRows[0].Cells[5].Value.ToString();

            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            loadFiel();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            

            try {

                double prixProduit;
                if (qteProduit.Text == null)
                {
                    prixProduit = 0;
                }
                else
                {
                    prixProduit = Convert.ToDouble(textDetailPrix.Text) * Convert.ToDouble(qteProduit.Text);
                }

                prixProduitForPanier.Text = Convert.ToString(prixProduit);

                prixProduit = Convert.ToDouble(textDetailPrix.Text) * Convert.ToDouble(qteProduit.Text);
                prixProduitForPanier.Text = Convert.ToString(prixProduit);
            }
            catch { }

        }

        private void addToCart_Click(object sender, EventArgs e)
        {

            produitSelectionne = new Produit();
            produitSelectionne.Id = Convert.ToInt32(dgvCatalogue.SelectedRows[0].Cells[0].Value.ToString());
            produitSelectionne.Libelle = dgvCatalogue.SelectedRows[0].Cells[1].Value.ToString();
            produitSelectionne.Prix = Convert.ToDouble(dgvCatalogue.SelectedRows[0].Cells[2].Value.ToString());
            produitSelectionne.QteStock = Convert.ToInt32(dgvCatalogue.SelectedRows[0].Cells[3].Value.ToString());
            produitSelectionne.QteSeuil = Convert.ToInt32(dgvCatalogue.SelectedRows[0].Cells[4].Value.ToString());
            produitSelectionne.Description = dgvCatalogue.SelectedRows[0].Cells[5].Value.ToString();

            produitSelectionne.Image = null;

            

            Panier p = new Panier();

            p.Prix = Convert.ToDouble(prixProduitForPanier.Text);
            p.Libelle = produitSelectionne.Libelle;
            p.QteCommande = Convert.ToInt32(qteProduit.Text);
            p.ProduitCommande = produitSelectionne;
            paniers.Add(p);
           
            laodPanier();
            
        }


        private void laodPanier()
        {
            //dgvPanier.AutoGenerateColumns = false;
            dgvPanier.ReadOnly = false;
            dgvPanier.DataSource = paniers;
            dgvPanier.AllowUserToAddRows = false;
            dgvPanier.AllowUserToDeleteRows = false;
            //dgvPanier.ReadOnly = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveCommande_Click(object sender, EventArgs e)
        {
            double montant = 0;
            foreach(Panier pan in paniers)
            {
                montant += pan.Prix;
            }

            Commande cmd = new Commande();

                cmd.Montant = montant;
                cmd.Etat = "Demande";
                cmd.Date = DateTime.Now;

        
            service.addCommande(userConnect.Id, produitSelectionne.Id, cmd, paniers);



        }
    }
}
