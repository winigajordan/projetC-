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
using GesCom.dto;



namespace GesCom
{
    public partial class FormRsLivraison : Form
    {
        private IService service = Fabrique.getInstanceService();
        
        CommandeDto cmd;
        public FormRsLivraison()
        {
            InitializeComponent();
        }

        public FormRsLivraison(CommandeDto commande)
        {
            InitializeComponent();
            cmd = commande;
            
            
        }

        public void loadcboLivreurs()
        {
            cboLivreur.DataSource = service.showAllLivreurs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void FormRsLivraison_Load(object sender, EventArgs e)
        {
            loadcboLivreurs();
            adresse.Text = cmd.CmdUser.Addresse;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Livraison li = new Livraison();
            li.Adresse = cmd.CmdUser.Addresse;
            li.Etat = "En cours";
            li.Livreur = (Livreur)cboLivreur.SelectedValue;
            li.Date = date.Value;

            Commande cmdd = new Commande()
            {
                Id = cmd.Id
            };

            li.Commande = cmdd;

            service.addLivraison(li);
            service.updateToOkayCommande(cmd.Id);
            this.Hide();
        }
    }
}
