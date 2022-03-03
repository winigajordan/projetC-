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
    public partial class FormClientAcceuil : Form
    {
        private User userConnect;
        public FormClientAcceuil()
        {
            InitializeComponent();
        }
        public FormClientAcceuil(User user)
        {
            InitializeComponent();
            userConnect = user;
            txtUserName.Text = user.Nom + " " + user.Prenom;

        }

        private void FormClientAcceuil_Load(object sender, EventArgs e)
        {
            loadFrmCatalogue();
        }

        private void clearChildren()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        private void loadFrmCatalogue()
        {
            clearChildren();
            FormClientCatalogue frm = new FormClientCatalogue(userConnect);
            frm.MdiParent = this;
            frm.Show();
        }

        public User showUserConnect()
        {
            return userConnect;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Hide();
        }
    }
}
