namespace MediaTek.vue
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSeConnecter = new System.Windows.Forms.Button();
            this.chkboxPwd = new System.Windows.Forms.CheckBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelIdentificationBas = new System.Windows.Forms.Panel();
            this.lblCoursPersonnel = new System.Windows.Forms.Label();
            this.lblVersionPersonnel = new System.Windows.Forms.Label();
            this.lblMonNomPrenomPersonnel = new System.Windows.Forms.Label();
            this.panelIdentificationHaut = new System.Windows.Forms.Panel();
            this.lblMediaTek = new System.Windows.Forms.Label();
            this.lblIdentification = new System.Windows.Forms.Label();
            this.MinimizeApp = new System.Windows.Forms.PictureBox();
            this.FermeApp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelIdentificationBas.SuspendLayout();
            this.panelIdentificationHaut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FermeApp)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(192, 61);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSeConnecter
            // 
            this.btnSeConnecter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSeConnecter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeConnecter.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.btnSeConnecter.ForeColor = System.Drawing.Color.Black;
            this.btnSeConnecter.Location = new System.Drawing.Point(228, 337);
            this.btnSeConnecter.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeConnecter.Name = "btnSeConnecter";
            this.btnSeConnecter.Size = new System.Drawing.Size(100, 33);
            this.btnSeConnecter.TabIndex = 5;
            this.btnSeConnecter.Text = "Connexion";
            this.btnSeConnecter.UseVisualStyleBackColor = false;
            this.btnSeConnecter.Click += new System.EventHandler(this.btnSeConnecter_Click);
            // 
            // chkboxPwd
            // 
            this.chkboxPwd.AutoSize = true;
            this.chkboxPwd.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkboxPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkboxPwd.Font = new System.Drawing.Font("Noto Sans Cond", 8.249999F);
            this.chkboxPwd.Location = new System.Drawing.Point(212, 305);
            this.chkboxPwd.Margin = new System.Windows.Forms.Padding(2);
            this.chkboxPwd.Name = "chkboxPwd";
            this.chkboxPwd.Size = new System.Drawing.Size(122, 19);
            this.chkboxPwd.TabIndex = 4;
            this.chkboxPwd.Text = "Afficher le mot de passe";
            this.chkboxPwd.UseVisualStyleBackColor = true;
            this.chkboxPwd.CheckedChanged += new System.EventHandler(this.chkboxPwd_CheckedChanged);
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("Noto Sans Cond", 8.249999F);
            this.txtPwd.Location = new System.Drawing.Point(192, 278);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(177, 22);
            this.txtPwd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.label3.Location = new System.Drawing.Point(83, 278);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mot de passe :";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Noto Sans Cond", 8.249999F);
            this.txtLogin.Location = new System.Drawing.Point(192, 218);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(177, 22);
            this.txtLogin.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.label2.Location = new System.Drawing.Point(98, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Identifiant :";
            // 
            // panelIdentificationBas
            // 
            this.panelIdentificationBas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelIdentificationBas.Controls.Add(this.lblCoursPersonnel);
            this.panelIdentificationBas.Controls.Add(this.lblVersionPersonnel);
            this.panelIdentificationBas.Controls.Add(this.lblMonNomPrenomPersonnel);
            this.panelIdentificationBas.Location = new System.Drawing.Point(0, 406);
            this.panelIdentificationBas.Name = "panelIdentificationBas";
            this.panelIdentificationBas.Size = new System.Drawing.Size(497, 19);
            this.panelIdentificationBas.TabIndex = 23;
            // 
            // lblCoursPersonnel
            // 
            this.lblCoursPersonnel.AutoSize = true;
            this.lblCoursPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.lblCoursPersonnel.Font = new System.Drawing.Font("Noto Sans Cond", 8.249999F);
            this.lblCoursPersonnel.Location = new System.Drawing.Point(112, 2);
            this.lblCoursPersonnel.Name = "lblCoursPersonnel";
            this.lblCoursPersonnel.Size = new System.Drawing.Size(222, 15);
            this.lblCoursPersonnel.TabIndex = 24;
            this.lblCoursPersonnel.Text = "SLAM - Ateliers de professionnalisation – 1re année";
            // 
            // lblVersionPersonnel
            // 
            this.lblVersionPersonnel.AutoSize = true;
            this.lblVersionPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.lblVersionPersonnel.Font = new System.Drawing.Font("Noto Sans Cond", 8.249999F);
            this.lblVersionPersonnel.Location = new System.Drawing.Point(3, 2);
            this.lblVersionPersonnel.Name = "lblVersionPersonnel";
            this.lblVersionPersonnel.Size = new System.Drawing.Size(53, 15);
            this.lblVersionPersonnel.TabIndex = 23;
            this.lblVersionPersonnel.Text = "Version 1.0";
            // 
            // lblMonNomPrenomPersonnel
            // 
            this.lblMonNomPrenomPersonnel.AutoSize = true;
            this.lblMonNomPrenomPersonnel.BackColor = System.Drawing.Color.Transparent;
            this.lblMonNomPrenomPersonnel.Font = new System.Drawing.Font("Noto Sans Cond", 8.249999F);
            this.lblMonNomPrenomPersonnel.Location = new System.Drawing.Point(406, 2);
            this.lblMonNomPrenomPersonnel.Name = "lblMonNomPrenomPersonnel";
            this.lblMonNomPrenomPersonnel.Size = new System.Drawing.Size(88, 15);
            this.lblMonNomPrenomPersonnel.TabIndex = 22;
            this.lblMonNomPrenomPersonnel.Text = "COVALEA Salvatore";
            // 
            // panelIdentificationHaut
            // 
            this.panelIdentificationHaut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panelIdentificationHaut.Controls.Add(this.lblMediaTek);
            this.panelIdentificationHaut.Controls.Add(this.lblIdentification);
            this.panelIdentificationHaut.Controls.Add(this.MinimizeApp);
            this.panelIdentificationHaut.Controls.Add(this.FermeApp);
            this.panelIdentificationHaut.Location = new System.Drawing.Point(0, 0);
            this.panelIdentificationHaut.Name = "panelIdentificationHaut";
            this.panelIdentificationHaut.Size = new System.Drawing.Size(497, 33);
            this.panelIdentificationHaut.TabIndex = 24;
            // 
            // lblMediaTek
            // 
            this.lblMediaTek.AutoSize = true;
            this.lblMediaTek.Font = new System.Drawing.Font("Noto Sans Cond", 8.249999F);
            this.lblMediaTek.Location = new System.Drawing.Point(9, 9);
            this.lblMediaTek.Name = "lblMediaTek";
            this.lblMediaTek.Size = new System.Drawing.Size(58, 15);
            this.lblMediaTek.TabIndex = 20;
            this.lblMediaTek.Text = "MediaTek86";
            // 
            // lblIdentification
            // 
            this.lblIdentification.AutoSize = true;
            this.lblIdentification.BackColor = System.Drawing.Color.Transparent;
            this.lblIdentification.Font = new System.Drawing.Font("Noto Sans Cond", 12F);
            this.lblIdentification.Location = new System.Drawing.Point(210, 4);
            this.lblIdentification.Name = "lblIdentification";
            this.lblIdentification.Size = new System.Drawing.Size(93, 22);
            this.lblIdentification.TabIndex = 19;
            this.lblIdentification.Text = "Identification";
            // 
            // MinimizeApp
            // 
            this.MinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeApp.Image")));
            this.MinimizeApp.Location = new System.Drawing.Point(425, 12);
            this.MinimizeApp.Name = "MinimizeApp";
            this.MinimizeApp.Size = new System.Drawing.Size(36, 18);
            this.MinimizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MinimizeApp.TabIndex = 18;
            this.MinimizeApp.TabStop = false;
            this.MinimizeApp.Click += new System.EventHandler(this.MinimizeApp_Click);
            // 
            // FermeApp
            // 
            this.FermeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FermeApp.Image = ((System.Drawing.Image)(resources.GetObject("FermeApp.Image")));
            this.FermeApp.Location = new System.Drawing.Point(467, 3);
            this.FermeApp.Name = "FermeApp";
            this.FermeApp.Size = new System.Drawing.Size(29, 27);
            this.FermeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FermeApp.TabIndex = 17;
            this.FermeApp.TabStop = false;
            this.FermeApp.Click += new System.EventHandler(this.FermeApp_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.btnSeConnecter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(498, 425);
            this.Controls.Add(this.panelIdentificationHaut);
            this.Controls.Add(this.panelIdentificationBas);
            this.Controls.Add(this.btnSeConnecter);
            this.Controls.Add(this.chkboxPwd);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaTek86";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelIdentificationBas.ResumeLayout(false);
            this.panelIdentificationBas.PerformLayout();
            this.panelIdentificationHaut.ResumeLayout(false);
            this.panelIdentificationHaut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FermeApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSeConnecter;
        private System.Windows.Forms.CheckBox chkboxPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelIdentificationBas;
        private System.Windows.Forms.Label lblCoursPersonnel;
        private System.Windows.Forms.Label lblVersionPersonnel;
        private System.Windows.Forms.Label lblMonNomPrenomPersonnel;
        private System.Windows.Forms.Panel panelIdentificationHaut;
        private System.Windows.Forms.Label lblMediaTek;
        private System.Windows.Forms.Label lblIdentification;
        private System.Windows.Forms.PictureBox MinimizeApp;
        private System.Windows.Forms.PictureBox FermeApp;
    }
}