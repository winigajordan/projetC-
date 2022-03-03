
namespace GesCom
{
    partial class FormClientCatalogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientCatalogue));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDetail = new System.Windows.Forms.Button();
            this.addToCart = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prixProduitForPanier = new System.Windows.Forms.TextBox();
            this.qteProduit = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textDetailDescription = new System.Windows.Forms.TextBox();
            this.textDetailPrix = new System.Windows.Forms.TextBox();
            this.textDetailLibelle = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCatalogue = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtQteSeuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvPanier = new System.Windows.Forms.DataGridView();
            this.panLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panQte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panProduit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveCommande = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(149)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 535);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSaveCommande);
            this.panel3.Controls.Add(this.dgvPanier);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(531, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(324, 526);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Josefin Slab", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 38);
            this.label8.TabIndex = 16;
            this.label8.Text = "Mon Panier";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnDetail);
            this.panel2.Controls.Add(this.addToCart);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.prixProduitForPanier);
            this.panel2.Controls.Add(this.qteProduit);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.textDetailDescription);
            this.panel2.Controls.Add(this.textDetailPrix);
            this.panel2.Controls.Add(this.textDetailLibelle);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dgvCatalogue);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 532);
            this.panel2.TabIndex = 0;
            // 
            // btnDetail
            // 
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Location = new System.Drawing.Point(411, 274);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(95, 23);
            this.btnDetail.TabIndex = 16;
            this.btnDetail.Text = "DetailProduit";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // addToCart
            // 
            this.addToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToCart.Location = new System.Drawing.Point(364, 480);
            this.addToCart.Name = "addToCart";
            this.addToCart.Size = new System.Drawing.Size(142, 23);
            this.addToCart.TabIndex = 15;
            this.addToCart.Text = "Ajouter au panier";
            this.addToCart.UseVisualStyleBackColor = false;
            this.addToCart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Josefin Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Quantité";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Josefin Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(360, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Prix Total";
            // 
            // prixProduitForPanier
            // 
            this.prixProduitForPanier.Location = new System.Drawing.Point(364, 443);
            this.prixProduitForPanier.Name = "prixProduitForPanier";
            this.prixProduitForPanier.Size = new System.Drawing.Size(142, 20);
            this.prixProduitForPanier.TabIndex = 12;
            // 
            // qteProduit
            // 
            this.qteProduit.Location = new System.Drawing.Point(364, 390);
            this.qteProduit.Name = "qteProduit";
            this.qteProduit.Size = new System.Drawing.Size(142, 20);
            this.qteProduit.TabIndex = 10;
            this.qteProduit.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox3_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(186, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // textDetailDescription
            // 
            this.textDetailDescription.Location = new System.Drawing.Point(12, 464);
            this.textDetailDescription.Multiline = true;
            this.textDetailDescription.Name = "textDetailDescription";
            this.textDetailDescription.Size = new System.Drawing.Size(142, 47);
            this.textDetailDescription.TabIndex = 8;
            // 
            // textDetailPrix
            // 
            this.textDetailPrix.Location = new System.Drawing.Point(12, 419);
            this.textDetailPrix.Name = "textDetailPrix";
            this.textDetailPrix.Size = new System.Drawing.Size(142, 20);
            this.textDetailPrix.TabIndex = 7;
            // 
            // textDetailLibelle
            // 
            this.textDetailLibelle.Location = new System.Drawing.Point(12, 369);
            this.textDetailLibelle.Name = "textDetailLibelle";
            this.textDetailLibelle.Size = new System.Drawing.Size(142, 20);
            this.textDetailLibelle.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Josefin Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Josefin Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Prix";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Libelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Slab", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Detail Produit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Slab", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Catalogue";
            // 
            // dgvCatalogue
            // 
            this.dgvCatalogue.AllowUserToDeleteRows = false;
            this.dgvCatalogue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalogue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCatalogue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCatalogue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalogue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.txtLibelle,
            this.txtPrix,
            this.txtQteStock,
            this.txtQteSeuil,
            this.txtDescription,
            this.txtImage});
            this.dgvCatalogue.Location = new System.Drawing.Point(7, 45);
            this.dgvCatalogue.Name = "dgvCatalogue";
            this.dgvCatalogue.ReadOnly = true;
            this.dgvCatalogue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalogue.Size = new System.Drawing.Size(503, 223);
            this.dgvCatalogue.TabIndex = 0;
            this.dgvCatalogue.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalogue_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // txtLibelle
            // 
            this.txtLibelle.DataPropertyName = "Libelle";
            this.txtLibelle.HeaderText = "Libelle";
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.ReadOnly = true;
            // 
            // txtPrix
            // 
            this.txtPrix.DataPropertyName = "Prix";
            this.txtPrix.HeaderText = "Prix unitaire";
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.ReadOnly = true;
            // 
            // txtQteStock
            // 
            this.txtQteStock.DataPropertyName = "QteStock";
            this.txtQteStock.HeaderText = "Qantite en Stock";
            this.txtQteStock.Name = "txtQteStock";
            this.txtQteStock.ReadOnly = true;
            this.txtQteStock.Visible = false;
            // 
            // txtQteSeuil
            // 
            this.txtQteSeuil.DataPropertyName = "QteSeuil";
            this.txtQteSeuil.HeaderText = "Quantite Seuil";
            this.txtQteSeuil.Name = "txtQteSeuil";
            this.txtQteSeuil.ReadOnly = true;
            this.txtQteSeuil.Visible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.DataPropertyName = "Description";
            this.txtDescription.HeaderText = "Desciption";
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            // 
            // txtImage
            // 
            this.txtImage.DataPropertyName = "Image";
            this.txtImage.HeaderText = "Image";
            this.txtImage.Name = "txtImage";
            this.txtImage.ReadOnly = true;
            this.txtImage.Visible = false;
            // 
            // dgvPanier
            // 
            this.dgvPanier.AllowUserToDeleteRows = false;
            this.dgvPanier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPanier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPanier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.panLibelle,
            this.panQte,
            this.panPrix,
            this.panProduit});
            this.dgvPanier.Location = new System.Drawing.Point(10, 45);
            this.dgvPanier.Name = "dgvPanier";
            this.dgvPanier.ReadOnly = true;
            this.dgvPanier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPanier.Size = new System.Drawing.Size(308, 150);
            this.dgvPanier.TabIndex = 17;
            // 
            // panLibelle
            // 
            this.panLibelle.DataPropertyName = "Libelle";
            this.panLibelle.HeaderText = "Libelle";
            this.panLibelle.Name = "panLibelle";
            this.panLibelle.ReadOnly = true;
            // 
            // panQte
            // 
            this.panQte.DataPropertyName = "QteCommande";
            this.panQte.HeaderText = "Quantite";
            this.panQte.Name = "panQte";
            this.panQte.ReadOnly = true;
            // 
            // panPrix
            // 
            this.panPrix.DataPropertyName = "Prix";
            this.panPrix.HeaderText = "Prix total produit";
            this.panPrix.Name = "panPrix";
            this.panPrix.ReadOnly = true;
            // 
            // panProduit
            // 
            this.panProduit.DataPropertyName = "ProduitCommande";
            this.panProduit.HeaderText = "Produit Commané";
            this.panProduit.Name = "panProduit";
            this.panProduit.ReadOnly = true;
            this.panProduit.Visible = false;
            // 
            // btnSaveCommande
            // 
            this.btnSaveCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCommande.Location = new System.Drawing.Point(174, 245);
            this.btnSaveCommande.Name = "btnSaveCommande";
            this.btnSaveCommande.Size = new System.Drawing.Size(120, 23);
            this.btnSaveCommande.TabIndex = 17;
            this.btnSaveCommande.Text = "Valider la commande";
            this.btnSaveCommande.UseVisualStyleBackColor = false;
            this.btnSaveCommande.Click += new System.EventHandler(this.btnSaveCommande_Click);
            // 
            // FormClientCatalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 535);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientCatalogue";
            this.Text = "FormClientCatalogue";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalogue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPanier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvCatalogue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox prixProduitForPanier;
        private System.Windows.Forms.TextBox qteProduit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textDetailDescription;
        private System.Windows.Forms.TextBox textDetailPrix;
        private System.Windows.Forms.TextBox textDetailLibelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button addToCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQteStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtQteSeuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDescription;
        private System.Windows.Forms.DataGridViewImageColumn txtImage;
        private System.Windows.Forms.DataGridView dgvPanier;
        private System.Windows.Forms.DataGridViewTextBoxColumn panLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn panQte;
        private System.Windows.Forms.DataGridViewTextBoxColumn panPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn panProduit;
        private System.Windows.Forms.Button btnSaveCommande;
    }
}