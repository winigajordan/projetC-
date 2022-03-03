using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesCom.fabrique;
using GesCom.service;
using GesCom.utils;

namespace GesCom
{
    public partial class FormRsGestionProduit : Form
    {
        private IService service = Fabrique.getInstanceService();
        private readonly string IMG_DEFAULT = @"C:\Users\user\Desktop\projetC#\GesCom\ressources\produitImage.jpg";

        public FormRsGestionProduit()
        {
            
            InitializeComponent();
            laodTgdvProduit();
            txtQteSeuil.Enabled = false;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtLibelle.Text)
                || string.IsNullOrEmpty(txtPrix.Text)
                || string.IsNullOrEmpty(txtQteStock.Text)
                || string.IsNullOrEmpty(txtDescription.Text)
             //|| string.IsNullOrEmpty(fileName)

             )
            {
                MessageBox.Show("Champs Obligatoires", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try {
                    string libelle = txtLibelle.Text;
                    Double prix = Convert.ToDouble(txtPrix.Text);
                    int qteStock = Convert.ToInt32(txtQteStock.Text);
                    int qteSeuil = qteStock - 5;
                    string description = txtDescription.Text;
                    //string image = "xxx";
                    Produit produit = new Produit();
                    produit.Libelle = libelle;
                    produit.Prix = prix;
                    produit.QteStock = qteStock;
                    produit.QteSeuil = qteSeuil;
                    produit.Image = null; 
                    produit.Description = description;


                    if (string.IsNullOrEmpty(fileName)) fileName = IMG_DEFAULT;
                    produit.Image = ImageConvert.convertImageToByte(fileName);

                   
                    
                    int x =  service.addProduct(produit);
                    laodTgdvProduit();

                }
                catch  {
                   
                    
                }
            }
        }

        private string fileName;
        private void bntImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "*.jpeg Files (*.jpeg)|*.jpeg|.jpg Files (*.jpg)|*.jpg|.png Files (*.png)|*.png";

            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imageBox.Image = Image.FromFile(dialog.FileName);
                fileName = dialog.FileName;

            }
        }

        public void laodTgdvProduit()
        {
            dgdvProduit.AutoGenerateColumns = false;
            dgdvProduit.ReadOnly = false;
            dgdvProduit.DataSource = service.getAllProduct().ToArray();

            dgdvProduit.AllowUserToAddRows = false;
            dgdvProduit.AllowUserToDeleteRows = false;
            dgdvProduit.ReadOnly = true;
        }

        private void dgdvProduit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            if (e.RowIndex >= 0 && e.RowIndex <= dgdvProduit.Rows.Count - 1)
            {
                DataGridViewRow row = dgdvProduit.Rows[e.RowIndex];
                row.Selected = true;
                txtLibelle.Text = row.Cells[1].Value.ToString();
                txtPrix.Text = Convert.ToString(row.Cells[2].Value.ToString());
                txtQteStock.Text = Convert.ToString(row.Cells[3].Value.ToString());
                txtQteSeuil.Text = Convert.ToString(row.Cells[4].Value.ToString());
                txtDescription.Text = Convert.ToString(row.Cells[5].Value.ToString());
                Image img = ImageConvert.convertByteToImage((byte[])row.Cells[6].Value);
                imageBox.Image = img;

            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgdvProduit.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                
                txtLibelle.Text = dgdvProduit.SelectedRows[0].Cells[1].Value.ToString();
                txtPrix.Text = dgdvProduit.SelectedRows[0].Cells[2].Value.ToString();
                txtQteStock.Text = dgdvProduit.SelectedRows[0].Cells[3].Value.ToString();
                txtQteSeuil.Text = dgdvProduit.SelectedRows[0].Cells[4].Value.ToString();
                txtDescription.Text = dgdvProduit.SelectedRows[0].Cells[5].Value.ToString();
                

            }
        }

        
    }
}
