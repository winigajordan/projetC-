
namespace GesCom
{
    partial class FormRsGestionProduit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRsGestionProduit));
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.bntImage = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtQteSeuil = new System.Windows.Forms.TextBox();
            this.txtQteStock = new System.Windows.Forms.TextBox();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgdvProduit = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcLibelle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcQteStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcQteSeuil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdvProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(149)))), ((int)(((byte)(223)))));
            this.panel1.Controls.Add(this.imageBox);
            this.panel1.Controls.Add(this.bntImage);
            this.panel1.Controls.Add(this.bntDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.bntAdd);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.txtQteSeuil);
            this.panel1.Controls.Add(this.txtQteStock);
            this.panel1.Controls.Add(this.txtPrix);
            this.panel1.Controls.Add(this.txtLibelle);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 505);
            this.panel1.TabIndex = 0;
            // 
            // imageBox
            // 
            this.imageBox.Image = ((System.Drawing.Image)(resources.GetObject("imageBox.Image")));
            this.imageBox.Location = new System.Drawing.Point(207, 365);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(111, 84);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 17;
            this.imageBox.TabStop = false;
            // 
            // bntImage
            // 
            this.bntImage.Location = new System.Drawing.Point(57, 395);
            this.bntImage.Name = "bntImage";
            this.bntImage.Size = new System.Drawing.Size(110, 23);
            this.bntImage.TabIndex = 16;
            this.bntImage.Text = "Choisir une image";
            this.bntImage.UseVisualStyleBackColor = true;
            this.bntImage.Click += new System.EventHandler(this.bntImage_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(261, 466);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 23);
            this.bntDelete.TabIndex = 15;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(155, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(43, 466);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 13;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(189, 295);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(147, 53);
            this.txtDescription.TabIndex = 11;
            // 
            // txtQteSeuil
            // 
            this.txtQteSeuil.Location = new System.Drawing.Point(189, 238);
            this.txtQteSeuil.Name = "txtQteSeuil";
            this.txtQteSeuil.Size = new System.Drawing.Size(147, 20);
            this.txtQteSeuil.TabIndex = 10;
            // 
            // txtQteStock
            // 
            this.txtQteStock.Location = new System.Drawing.Point(189, 184);
            this.txtQteStock.Name = "txtQteStock";
            this.txtQteStock.Size = new System.Drawing.Size(147, 20);
            this.txtQteStock.TabIndex = 9;
            // 
            // txtPrix
            // 
            this.txtPrix.Location = new System.Drawing.Point(189, 125);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.Size = new System.Drawing.Size(147, 20);
            this.txtPrix.TabIndex = 8;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(189, 77);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(147, 20);
            this.txtLibelle.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Josefin Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Josefin Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quantite seuil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Josefin Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Quantite en stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Libelle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Slab", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion des produits";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnDetails);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dgdvProduit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(396, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 505);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 466);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Effacer les valeurs du formulaire";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(222, 466);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(122, 23);
            this.btnDetails.TabIndex = 18;
            this.btnDetails.Text = "Details du produit";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Josefin Slab", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(154, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(232, 34);
            this.label7.TabIndex = 18;
            this.label7.Text = "Liste des produits";
            // 
            // dgdvProduit
            // 
            this.dgdvProduit.AllowUserToDeleteRows = false;
            this.dgdvProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgdvProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdvProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.tblcLibelle,
            this.tblcPrix,
            this.tblcQteStock,
            this.tblcQteSeuil,
            this.tblcDescription,
            this.tblcImage});
            this.dgdvProduit.Location = new System.Drawing.Point(16, 74);
            this.dgdvProduit.Name = "dgdvProduit";
            this.dgdvProduit.ReadOnly = true;
            this.dgdvProduit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdvProduit.Size = new System.Drawing.Size(488, 375);
            this.dgdvProduit.TabIndex = 0;
            this.dgdvProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdvProduit_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // tblcLibelle
            // 
            this.tblcLibelle.DataPropertyName = "Libelle";
            this.tblcLibelle.HeaderText = "Libelle";
            this.tblcLibelle.Name = "tblcLibelle";
            this.tblcLibelle.ReadOnly = true;
            // 
            // tblcPrix
            // 
            this.tblcPrix.DataPropertyName = "Prix";
            this.tblcPrix.HeaderText = "Prix";
            this.tblcPrix.Name = "tblcPrix";
            this.tblcPrix.ReadOnly = true;
            // 
            // tblcQteStock
            // 
            this.tblcQteStock.DataPropertyName = "QteStock";
            this.tblcQteStock.HeaderText = "Quantite Stock";
            this.tblcQteStock.Name = "tblcQteStock";
            this.tblcQteStock.ReadOnly = true;
            // 
            // tblcQteSeuil
            // 
            this.tblcQteSeuil.DataPropertyName = "QteSeuil";
            this.tblcQteSeuil.HeaderText = "Quantite seuil";
            this.tblcQteSeuil.Name = "tblcQteSeuil";
            this.tblcQteSeuil.ReadOnly = true;
            // 
            // tblcDescription
            // 
            this.tblcDescription.DataPropertyName = "Description";
            this.tblcDescription.HeaderText = "Description";
            this.tblcDescription.Name = "tblcDescription";
            this.tblcDescription.ReadOnly = true;
            this.tblcDescription.Visible = false;
            // 
            // tblcImage
            // 
            this.tblcImage.HeaderText = "Image";
            this.tblcImage.Name = "tblcImage";
            this.tblcImage.ReadOnly = true;
            this.tblcImage.Visible = false;
            // 
            // FormRsGestionProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRsGestionProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormRsGestionProduit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdvProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtQteSeuil;
        private System.Windows.Forms.TextBox txtQteStock;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.PictureBox imageBox;
        private System.Windows.Forms.Button bntImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgdvProduit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcLibelle;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcQteStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcQteSeuil;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcImage;
    }
}