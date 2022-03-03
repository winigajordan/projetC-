using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GesCom
{
    public partial class FormRsAcceuil : Form
    {
        private User userConnect;

        public FormRsAcceuil()
        {
            InitializeComponent();
        }

        private void FormRsAcceuil_Load(object sender, EventArgs e)
        {
            loadFrmGestionProduit();
        }


        public FormRsAcceuil(User user)
        {
            InitializeComponent();
            this.userConnect = user;
            txtUserName.Text = user.Nom + " " + user.Prenom;
        }

        private void txtLogout_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }

        private void loadFrmGestionProduit()
        {
            clearChildren();
            FormRsGestionProduit frm = new FormRsGestionProduit();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loadFrmGestionCommande()
        {
            clearChildren();
            FormRsGestionCommande frm = new FormRsGestionCommande();
            frm.MdiParent = this;
            frm.Show();
        }

        private void loadFrmDashboard()
        {
            clearChildren();
            FormRsDashboard frm = new FormRsDashboard();
            frm.MdiParent = this;
            frm.Show();
        }



        private void clearChildren()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void txtStock_Click(object sender, EventArgs e)
        {
            loadFrmGestionProduit();
        }

        private void txtProduit_Click(object sender, EventArgs e)
        {
            loadFrmGestionCommande();
        }

        private void txtDashboard_Click(object sender, EventArgs e)
        {
            loadFrmDashboard();
        }
    }
}
