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
    public partial class FormRsGestionCommande : Form
    {
        private IService service = Fabrique.getInstanceService();
        
        public FormRsGestionCommande()
        {

            InitializeComponent();
            
            cboEtat.Items.Add("Valide");
            cboEtat.Items.Add("En cours");
            cboEtat.Items.Add("Attente de confirmation");


            btnValide.Visible = false;
            btnAttente.Visible = false;

        }

        

        private void cboEtat_SelectedIndexChanged(object sender, EventArgs e)
        {
            string etat = cboEtat.SelectedItem.ToString();
            if (service.getCommandeDtoByEtat(etat) == null)
            {
                MessageBox.Show("Aucune commande avec cet état");
            }
            else {
                laodTgdvCommande(service.getCommandeDtoByEtat(etat));
            }
            
        }

        public void laodTgdvCommande(List<CommandeDto> list)
        {
            dgvCmd.AutoGenerateColumns = false;
            dgvCmd.ReadOnly = false;
            dgvCmd.AllowUserToAddRows = false;
            dgvCmd.AllowUserToDeleteRows = false;
            dgvCmd.ReadOnly = true;
            dgvCmd.DataSource = list.ToArray();
                //service.getCommandeDto().ToArray();
        }

        private void txtAllCmd_Click(object sender, EventArgs e)
        {
            laodTgdvCommande(service.getCommandeDtoToRs());
        }

        CommandeDto cmd;
        private void dgvCmd_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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
            foreach (var dto in list)
            {
                if (dto.Qte > dto.Details.Produit.QteSeuil)
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
            FormRsLivraison frm = new FormRsLivraison(cmd);
            frm.Show();
            
        }
    }
}
