
namespace GesCom
{
    partial class FormRsAcceuil
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLogout = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.Label();
            this.txtProduit = new System.Windows.Forms.Label();
            this.txtDashboard = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 100);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Josefin Slab", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Responsable Stock";
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Font = new System.Drawing.Font("Josefin Slab", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(163, 18);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(121, 28);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.Text = "Bienvenue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Josefin Slab", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 28);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bienvenue";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.txtLogout);
            this.panel2.Controls.Add(this.txtStock);
            this.panel2.Controls.Add(this.txtProduit);
            this.panel2.Controls.Add(this.txtDashboard);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 515);
            this.panel2.TabIndex = 1;
            // 
            // txtLogout
            // 
            this.txtLogout.AutoSize = true;
            this.txtLogout.Font = new System.Drawing.Font("Josefin Slab", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogout.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLogout.Location = new System.Drawing.Point(18, 481);
            this.txtLogout.Name = "txtLogout";
            this.txtLogout.Size = new System.Drawing.Size(150, 25);
            this.txtLogout.TabIndex = 3;
            this.txtLogout.Text = "<- Deconnexion";
            this.txtLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtLogout.Click += new System.EventHandler(this.txtLogout_Click);
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Font = new System.Drawing.Font("Josefin Slab", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(18, 238);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(158, 25);
            this.txtStock.TabIndex = 2;
            this.txtStock.Text = "Gestion des stock";
            this.txtStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtStock.Click += new System.EventHandler(this.txtStock_Click);
            // 
            // txtProduit
            // 
            this.txtProduit.AutoSize = true;
            this.txtProduit.Font = new System.Drawing.Font("Josefin Slab", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduit.Location = new System.Drawing.Point(3, 282);
            this.txtProduit.Name = "txtProduit";
            this.txtProduit.Size = new System.Drawing.Size(186, 25);
            this.txtProduit.TabIndex = 1;
            this.txtProduit.Text = "Gestion commandes";
            this.txtProduit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.txtProduit.Click += new System.EventHandler(this.txtProduit_Click);
            // 
            // txtDashboard
            // 
            this.txtDashboard.AutoSize = true;
            this.txtDashboard.Font = new System.Drawing.Font("Josefin Slab", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDashboard.Location = new System.Drawing.Point(36, 194);
            this.txtDashboard.Name = "txtDashboard";
            this.txtDashboard.Size = new System.Drawing.Size(106, 25);
            this.txtDashboard.TabIndex = 0;
            this.txtDashboard.Text = "DashBoard";
            this.txtDashboard.Click += new System.EventHandler(this.txtDashboard_Click);
            // 
            // FormRsAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "FormRsAcceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRsAcceuil";
            this.Load += new System.EventHandler(this.FormRsAcceuil_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label txtLogout;
        private System.Windows.Forms.Label txtStock;
        private System.Windows.Forms.Label txtProduit;
        private System.Windows.Forms.Label txtDashboard;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label label4;
    }
}