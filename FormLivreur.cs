using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GesCom.dto;
using GesCom.fabrique;
using GesCom.service;

namespace GesCom
{
    public partial class FormLivreur : Form
    {
        private IService service = Fabrique.getInstanceService();
        User user;
        public FormLivreur()
        {
            InitializeComponent();
        }

        public FormLivreur(User u)
        {
            
            InitializeComponent();
            this.user = u;
            txtUserName.Text = u.Nom + " " + u.Prenom;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void dgvLivraisons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void laodGdvLivraisons()
        {

            dgvLivraisons.AutoGenerateColumns = false;
            dgvLivraisons.ReadOnly = false;
            dgvLivraisons.AllowUserToAddRows = false;
            dgvLivraisons.AllowUserToDeleteRows = false;
            dgvLivraisons.ReadOnly = true;
            dgvLivraisons.DataSource = service.getLivraisonById(user.Id);
        }

        private void FormLivreur_Load(object sender, EventArgs e)
        {
            
            laodGdvLivraisons();
                MessageBox.Show(user.Nom);
            
        }
    }
}
