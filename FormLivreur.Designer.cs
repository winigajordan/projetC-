
namespace GesCom
{
    partial class FormLivreur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvLivraisons = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tblcRef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivraisons)).BeginInit();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Josefin Slab", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(677, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Logout ->";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Josefin Slab", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(12, 52);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(134, 32);
            this.txtUserName.TabIndex = 36;
            this.txtUserName.Text = "userName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Josefin Slab", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 32);
            this.label4.TabIndex = 35;
            this.label4.Text = "Bienvenue";
            // 
            // dgvLivraisons
            // 
            this.dgvLivraisons.AllowUserToDeleteRows = false;
            this.dgvLivraisons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLivraisons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivraisons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tblcRef,
            this.tblcDate,
            this.tblcPrix});
            this.dgvLivraisons.Location = new System.Drawing.Point(27, 170);
            this.dgvLivraisons.Name = "dgvLivraisons";
            this.dgvLivraisons.ReadOnly = true;
            this.dgvLivraisons.RowHeadersVisible = false;
            this.dgvLivraisons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivraisons.Size = new System.Drawing.Size(341, 328);
            this.dgvLivraisons.TabIndex = 1;
            this.dgvLivraisons.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivraisons_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Josefin Slab", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 32);
            this.label2.TabIndex = 38;
            this.label2.Text = "Mes livraison";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Josefin Slab", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(443, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Infos Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Josefin Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 19);
            this.label6.TabIndex = 40;
            this.label6.Text = "Telephone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Josefin Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 41;
            this.label8.Text = "Nom Complet";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(606, 215);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(148, 20);
            this.txtPhoneNumber.TabIndex = 42;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(177, 73);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(148, 20);
            this.txtNom.TabIndex = 43;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.textBox1);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.txtNom);
            this.panel11.Location = new System.Drawing.Point(428, 183);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(350, 242);
            this.panel11.TabIndex = 44;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 125);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 82);
            this.textBox1.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Josefin Slab", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Adeesse de livraison";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(532, 465);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 33);
            this.button1.TabIndex = 45;
            this.button1.Text = "Effectuer la commande";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tblcRef
            // 
            this.tblcRef.DataPropertyName = "Reference";
            this.tblcRef.HeaderText = "Reference";
            this.tblcRef.Name = "tblcRef";
            this.tblcRef.ReadOnly = true;
            // 
            // tblcDate
            // 
            this.tblcDate.DataPropertyName = "DateX";
            this.tblcDate.HeaderText = "Date";
            this.tblcDate.Name = "tblcDate";
            this.tblcDate.ReadOnly = true;
            // 
            // tblcPrix
            // 
            this.tblcPrix.DataPropertyName = "Prix";
            this.tblcPrix.HeaderText = "Prix Commande";
            this.tblcPrix.Name = "tblcPrix";
            this.tblcPrix.ReadOnly = true;
            // 
            // FormLivreur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLivraisons);
            this.Controls.Add(this.panel1);
            this.Name = "FormLivreur";
            this.Text = "FormLivreur";
            this.Load += new System.EventHandler(this.FormLivreur_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivraisons)).EndInit();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvLivraisons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcRef;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tblcPrix;
    }
}