
namespace GesCom
{
    partial class FormRsGestionCommande
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAllCmd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboEtat = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCmd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel15 = new System.Windows.Forms.Panel();
            this.btnValide = new System.Windows.Forms.Button();
            this.btnAttente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.tblcDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcQteCommande = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmd)).BeginInit();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAllCmd
            // 
            this.txtAllCmd.AutoSize = true;
            this.txtAllCmd.Font = new System.Drawing.Font("Josefin Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAllCmd.Location = new System.Drawing.Point(91, 460);
            this.txtAllCmd.Name = "txtAllCmd";
            this.txtAllCmd.Size = new System.Drawing.Size(261, 23);
            this.txtAllCmd.TabIndex = 36;
            this.txtAllCmd.Text = "Afficher toutes les commandes";
            this.txtAllCmd.Click += new System.EventHandler(this.txtAllCmd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Josefin Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 23);
            this.label5.TabIndex = 35;
            this.label5.Text = "Filtrer par etat";
            // 
            // cboEtat
            // 
            this.cboEtat.FormattingEnabled = true;
            this.cboEtat.Location = new System.Drawing.Point(233, 78);
            this.cboEtat.Name = "cboEtat";
            this.cboEtat.Size = new System.Drawing.Size(121, 21);
            this.cboEtat.TabIndex = 34;
            this.cboEtat.SelectedIndexChanged += new System.EventHandler(this.cboEtat_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Josefin Slab", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Liste des Commandes";
            // 
            // dgvCmd
            // 
            this.dgvCmd.AllowUserToDeleteRows = false;
            this.dgvCmd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCmd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.User,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2});
            this.dgvCmd.Location = new System.Drawing.Point(21, 135);
            this.dgvCmd.Name = "dgvCmd";
            this.dgvCmd.ReadOnly = true;
            this.dgvCmd.RowHeadersVisible = false;
            this.dgvCmd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCmd.Size = new System.Drawing.Size(423, 302);
            this.dgvCmd.TabIndex = 32;
            this.dgvCmd.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCmd_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Reference";
            this.dataGridViewTextBoxColumn1.HeaderText = "Reference";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // User
            // 
            this.User.DataPropertyName = "CmdUser";
            this.User.HeaderText = "User";
            this.User.Name = "User";
            this.User.ReadOnly = true;
            this.User.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Etat";
            this.dataGridViewTextBoxColumn3.HeaderText = "Etat";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // panel15
            // 
            this.panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel15.Controls.Add(this.btnValide);
            this.panel15.Controls.Add(this.btnAttente);
            this.panel15.Location = new System.Drawing.Point(495, 209);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(387, 268);
            this.panel15.TabIndex = 31;
            // 
            // btnValide
            // 
            this.btnValide.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnValide.Location = new System.Drawing.Point(44, 201);
            this.btnValide.Name = "btnValide";
            this.btnValide.Size = new System.Drawing.Size(133, 32);
            this.btnValide.TabIndex = 10;
            this.btnValide.Text = "Valider";
            this.btnValide.UseVisualStyleBackColor = false;
            this.btnValide.Click += new System.EventHandler(this.btnValide_Click);
            // 
            // btnAttente
            // 
            this.btnAttente.BackColor = System.Drawing.Color.Crimson;
            this.btnAttente.Location = new System.Drawing.Point(231, 201);
            this.btnAttente.Name = "btnAttente";
            this.btnAttente.Size = new System.Drawing.Size(133, 32);
            this.btnAttente.TabIndex = 11;
            this.btnAttente.Text = "Mise en Attente";
            this.btnAttente.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Josefin Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(511, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 23);
            this.label9.TabIndex = 29;
            this.label9.Text = "Details Panier";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Location = new System.Drawing.Point(37, 44);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(350, 86);
            this.panel11.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Infos Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Josefin Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Telephone : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Josefin Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 19);
            this.label8.TabIndex = 25;
            this.label8.Text = "Nom Complet : ";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(215, 67);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(148, 20);
            this.txtPhoneNumber.TabIndex = 26;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(215, 93);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(148, 20);
            this.txtNom.TabIndex = 27;
            // 
            // tblcDetails
            // 
            this.tblcDetails.DataPropertyName = "Details";
            this.tblcDetails.HeaderText = "Details Commande";
            this.tblcDetails.Name = "tblcDetails";
            this.tblcDetails.ReadOnly = true;
            this.tblcDetails.Visible = false;
            // 
            // tblcId
            // 
            this.tblcId.DataPropertyName = "Id";
            this.tblcId.HeaderText = "Id";
            this.tblcId.Name = "tblcId";
            this.tblcId.ReadOnly = true;
            this.tblcId.Visible = false;
            // 
            // tblcPrix
            // 
            this.tblcPrix.DataPropertyName = "Prix";
            this.tblcPrix.HeaderText = "Prix";
            this.tblcPrix.Name = "tblcPrix";
            this.tblcPrix.ReadOnly = true;
            // 
            // tblcQteCommande
            // 
            this.tblcQteCommande.DataPropertyName = "Qte";
            this.tblcQteCommande.HeaderText = "Quantité";
            this.tblcQteCommande.Name = "tblcQteCommande";
            this.tblcQteCommande.ReadOnly = true;
            // 
            // tblcLibelle
            // 
            this.tblcLibelle.DataPropertyName = "Libelle";
            this.tblcLibelle.HeaderText = "Libelle";
            this.tblcLibelle.Name = "tblcLibelle";
            this.tblcLibelle.ReadOnly = true;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblcLibelle,
            this.tblcQteCommande,
            this.tblcPrix,
            this.tblcId,
            this.tblcDetails});
            this.dgvDetails.Location = new System.Drawing.Point(516, 233);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowHeadersVisible = false;
            this.dgvDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetails.Size = new System.Drawing.Size(350, 168);
            this.dgvDetails.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Slab", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(526, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Liste des Commandes";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtNom);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Location = new System.Drawing.Point(474, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 456);
            this.panel1.TabIndex = 12;
            // 
            // FormRsGestionCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(912, 505);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAllCmd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboEtat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCmd);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRsGestionCommande";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRsGestionCommande";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCmd)).EndInit();
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txtAllCmd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboEtat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCmd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn User;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Button btnValide;
        private System.Windows.Forms.Button btnAttente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcQteCommande;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcLibelle;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}