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

namespace GesCom
{
    public partial class Form1 : Form
    {
        private IService service = Fabrique.getInstanceService();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;
            

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                //service.getCommandeDto();


                                MessageBox.Show(Convert.ToString("Login et mot de passe oblibatoire"),
                                        "Erreur",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                
            }
            else
            {
                User user = service.searchUserLoginAndPassword(login, password);
                if (user == null)
                {
                    MessageBox.Show("Login ou mot de passe incorrecte",
                    "Erreur",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
                else
                {
                    if (user.Role.ToString().Equals("ROLE_RS")) { 
                    FormRsAcceuil frm = new FormRsAcceuil(user);
                    frm.Show();
                    this.Hide();
                    }
                    else if (user.Role.ToString().Equals("ROLE_CLIENT")) {
                        FormClientAcceuil frm = new FormClientAcceuil(user);
                        frm.Show();
                        this.Hide();
                    }
                    else if (user.Role.ToString().Equals("ROLE_SECRETAIRE"))
                    {
                        FormSecretaire frm = new FormSecretaire(user);
                        frm.Show();
                        this.Hide();
                    }
                    else if (user.Role.ToString().Equals("ROLE_LIVREUR"))
                    {
                        FormLivreur frm = new FormLivreur(user);
                        frm.Show();
                        this.Hide();
                    }
                    //Redirection vers la page Accueil

                }
            }

        }
    }
}
