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
    public partial class FormSecretaire : Form
    {
        private IService service = Fabrique.getInstanceService();
        private User userConnected;

        public FormSecretaire()
        {
            InitializeComponent();
        }


        public FormSecretaire(User user)
        {
            InitializeComponent();
            this.userConnected = user;
            txtUserConnectName.Text = user.Nom + user.Prenom;
            laodTgdvCommande();
            txtNom.Enabled = false;
            txtPhoneNumber.Enabled = false;

            btnValide.Visible = false;
            btnAttente.Visible = false;

        }

        

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        
        public void laodTgdvCommande()
        {
            dgvCmd.AutoGenerateColumns = false;
            dgvCmd.ReadOnly = false;
            dgvCmd.AllowUserToAddRows = false;
            dgvCmd.AllowUserToDeleteRows = false;
            dgvCmd.ReadOnly = true;
            dgvCmd.DataSource = service.getCommandeDto().ToArray();
        }


        CommandeDto cmd;
        private void dgvCmd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             cmd = (CommandeDto)dgvCmd.Rows[e.RowIndex].DataBoundItem;
            laodUserInfo(cmd.CmdUser);
            laodDetailGrdv(cmd.Id);
        }


        public void laodUserInfo(Client cl)
        {
            txtPhoneNumber.Text = cl.Telephone;
            txtNom.Text = cl.Nom;
        }

        public void laodDetailGrdv(int idCmd)
        {
            List<DetailCommandeDto> list = service.getDetailCommande(idCmd);
            dgvDetails.AutoGenerateColumns = false;
            dgvDetails.ReadOnly = false;
            dgvDetails.AllowUserToAddRows = false;
            dgvDetails.AllowUserToDeleteRows = false;
            dgvDetails.ReadOnly = true;
            dgvDetails.DataSource = list;

            //Activation ou desactivation des buttun
            bool valide = true;
            foreach(var dto in list)
            {
                if(dto.Qte > dto.Details.Produit.QteSeuil)
                {
                    valide = false;
                }
            }

            if (valide)
            {
                btnValide.Visible = true;
                btnAttente.Visible = false;
            }
            else
            {
                btnAttente.Visible = true;
                btnValide.Visible = false;
            }

        }

        private void btnValide_Click(object sender, EventArgs e)
        {
            service.updateToValideCommande(cmd.Id);
            btnValide.Visible = false;
            laodTgdvCommande();

        }

        private void btnAttente_Click(object sender, EventArgs e)
        {
            service.updateToWaitCommande(cmd.Id);
            btnAttente.Visible = false;
            laodTgdvCommande();
        }
    }
}
