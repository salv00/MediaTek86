namespace MediaTek.vue
{
    /// <summary>
    /// Classe Designer : création des composants graphiques
    /// </summary>
    partial class frmGestionPersonnel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionPersonnel));
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboServices = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblGauche = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.lblDroit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvPersonnels = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnVider = new System.Windows.Forms.Button();
            this.cboMotifs = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.DPickDebut = new System.Windows.Forms.DateTimePicker();
            this.DPickFin = new System.Windows.Forms.DateTimePicker();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblNom.Location = new System.Drawing.Point(27, 61);
            this.lblNom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(34, 15);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Noto Sans Cond", 9F);
            this.txtNom.Location = new System.Drawing.Point(30, 83);
            this.txtNom.Margin = new System.Windows.Forms.Padding(2);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(102, 24);
            this.txtNom.TabIndex = 1;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Noto Sans Cond", 9F);
            this.txtPrenom.Location = new System.Drawing.Point(144, 83);
            this.txtPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(141, 24);
            this.txtPrenom.TabIndex = 3;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblPrenom.Location = new System.Drawing.Point(140, 61);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 15);
            this.lblPrenom.TabIndex = 2;
            this.lblPrenom.Text = "Prénom";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Noto Sans Cond", 9F);
            this.txtEmail.Location = new System.Drawing.Point(30, 132);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 24);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(27, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse mail";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblService.Location = new System.Drawing.Point(140, 159);
            this.lblService.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(45, 15);
            this.lblService.TabIndex = 13;
            this.lblService.Text = "Service";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Noto Sans Cond", 9F);
            this.txtTel.Location = new System.Drawing.Point(30, 180);
            this.txtTel.Margin = new System.Windows.Forms.Padding(2);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(102, 24);
            this.txtTel.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label7.Location = new System.Drawing.Point(27, 159);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Téléphone";
            // 
            // cboServices
            // 
            this.cboServices.Font = new System.Drawing.Font("Noto Sans Cond", 8.249999F);
            this.cboServices.FormattingEnabled = true;
            this.cboServices.Location = new System.Drawing.Point(143, 181);
            this.cboServices.Margin = new System.Windows.Forms.Padding(2);
            this.cboServices.Name = "cboServices";
            this.cboServices.Size = new System.Drawing.Size(141, 23);
            this.cboServices.TabIndex = 15;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.Red;
            this.btnSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimer.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.btnSupprimer.ForeColor = System.Drawing.Color.Black;
            this.btnSupprimer.Location = new System.Drawing.Point(22, 350);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(134, 35);
            this.btnSupprimer.TabIndex = 17;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.BackColor = System.Drawing.Color.OrangeRed;
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifier.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.btnModifier.ForeColor = System.Drawing.Color.Black;
            this.btnModifier.Location = new System.Drawing.Point(160, 306);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(134, 35);
            this.btnModifier.TabIndex = 19;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = false;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.BackColor = System.Drawing.Color.Transparent;
            this.lblGauche.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGauche.ForeColor = System.Drawing.Color.Black;
            this.lblGauche.Location = new System.Drawing.Point(84, 13);
            this.lblGauche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(153, 19);
            this.lblGauche.TabIndex = 20;
            this.lblGauche.Text = "FICHE DU PERSONNEL";
            this.lblGauche.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.White;
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitch.Font = new System.Drawing.Font("Noto Sans", 9F, System.Drawing.FontStyle.Bold);
            this.btnSwitch.ForeColor = System.Drawing.Color.Black;
            this.btnSwitch.Location = new System.Drawing.Point(160, 350);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(134, 35);
            this.btnSwitch.TabIndex = 21;
            this.btnSwitch.Text = "Gestion Absences";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // lblDroit
            // 
            this.lblDroit.AutoSize = true;
            this.lblDroit.BackColor = System.Drawing.Color.Transparent;
            this.lblDroit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDroit.ForeColor = System.Drawing.Color.Black;
            this.lblDroit.Location = new System.Drawing.Point(218, 13);
            this.lblDroit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDroit.Name = "lblDroit";
            this.lblDroit.Size = new System.Drawing.Size(163, 19);
            this.lblDroit.TabIndex = 22;
            this.lblDroit.Text = "LISTE DES PERSONNELS";
            this.lblDroit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.lblGauche);
            this.panel1.Location = new System.Drawing.Point(14, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 45);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel3.Controls.Add(this.lblDroit);
            this.panel3.Location = new System.Drawing.Point(315, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(614, 45);
            this.panel3.TabIndex = 25;
            // 
            // dgvPersonnels
            // 
            this.dgvPersonnels.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPersonnels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnels.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvPersonnels.GridColor = System.Drawing.Color.White;
            this.dgvPersonnels.Location = new System.Drawing.Point(315, 61);
            this.dgvPersonnels.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPersonnels.MultiSelect = false;
            this.dgvPersonnels.Name = "dgvPersonnels";
            this.dgvPersonnels.RowHeadersWidth = 82;
            this.dgvPersonnels.RowTemplate.Height = 33;
            this.dgvPersonnels.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnels.Size = new System.Drawing.Size(589, 394);
            this.dgvPersonnels.TabIndex = 26;
            this.dgvPersonnels.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonnels_CellEnter);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouter.Font = new System.Drawing.Font("Noto Sans", 11.25F);
            this.btnAjouter.ForeColor = System.Drawing.Color.Black;
            this.btnAjouter.Location = new System.Drawing.Point(22, 306);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(134, 35);
            this.btnAjouter.TabIndex = 28;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnVider
            // 
            this.btnVider.BackColor = System.Drawing.SystemColors.Menu;
            this.btnVider.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVider.ForeColor = System.Drawing.Color.Gray;
            this.btnVider.Location = new System.Drawing.Point(236, 214);
            this.btnVider.Margin = new System.Windows.Forms.Padding(2);
            this.btnVider.Name = "btnVider";
            this.btnVider.Size = new System.Drawing.Size(46, 23);
            this.btnVider.TabIndex = 27;
            this.btnVider.Text = "VIDER";
            this.btnVider.UseVisualStyleBackColor = false;
            this.btnVider.Click += new System.EventHandler(this.btnVider_Click);
            // 
            // cboMotifs
            // 
            this.cboMotifs.Font = new System.Drawing.Font("Noto Sans Cond", 9F);
            this.cboMotifs.FormattingEnabled = true;
            this.cboMotifs.Location = new System.Drawing.Point(30, 229);
            this.cboMotifs.Margin = new System.Windows.Forms.Padding(2);
            this.cboMotifs.Name = "cboMotifs";
            this.cboMotifs.Size = new System.Drawing.Size(254, 25);
            this.cboMotifs.TabIndex = 54;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblMotif.Location = new System.Drawing.Point(27, 207);
            this.lblMotif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(36, 15);
            this.lblMotif.TabIndex = 53;
            this.lblMotif.Text = "Motif";
            // 
            // DPickDebut
            // 
            this.DPickDebut.CalendarFont = new System.Drawing.Font("Noto Sans Cond", 9.749999F);
            this.DPickDebut.Font = new System.Drawing.Font("Noto Sans Cond", 9F);
            this.DPickDebut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPickDebut.Location = new System.Drawing.Point(30, 132);
            this.DPickDebut.Margin = new System.Windows.Forms.Padding(2);
            this.DPickDebut.MaxDate = new System.DateTime(2120, 1, 1, 0, 0, 0, 0);
            this.DPickDebut.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DPickDebut.Name = "DPickDebut";
            this.DPickDebut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DPickDebut.Size = new System.Drawing.Size(254, 24);
            this.DPickDebut.TabIndex = 52;
            // 
            // DPickFin
            // 
            this.DPickFin.CalendarFont = new System.Drawing.Font("Noto Sans Cond", 9.749999F);
            this.DPickFin.Font = new System.Drawing.Font("Noto Sans Cond", 9F);
            this.DPickFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DPickFin.Location = new System.Drawing.Point(30, 180);
            this.DPickFin.Margin = new System.Windows.Forms.Padding(2);
            this.DPickFin.MaxDate = new System.DateTime(2120, 1, 1, 0, 0, 0, 0);
            this.DPickFin.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.DPickFin.Name = "DPickFin";
            this.DPickFin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DPickFin.Size = new System.Drawing.Size(254, 24);
            this.DPickFin.TabIndex = 51;
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateFin.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDateFin.Location = new System.Drawing.Point(27, 159);
            this.lblDateFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(66, 15);
            this.lblDateFin.TabIndex = 50;
            this.lblDateFin.Text = "Date de fin";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDebut.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lblDateDebut.Location = new System.Drawing.Point(27, 110);
            this.lblDateDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(82, 15);
            this.lblDateDebut.TabIndex = 49;
            this.lblDateDebut.Text = "Date de début";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvAbsences.Location = new System.Drawing.Point(315, 61);
            this.dgvAbsences.Margin = new System.Windows.Forms.Padding(2);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.RowHeadersWidth = 82;
            this.dgvAbsences.RowTemplate.Height = 33;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(589, 394);
            this.dgvAbsences.TabIndex = 55;
            this.dgvAbsences.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbsences_CellEnter);
            // 
            // picRefresh
            // 
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Image = ((System.Drawing.Image)(resources.GetObject("picRefresh.Image")));
            this.picRefresh.Location = new System.Drawing.Point(204, 214);
            this.picRefresh.Margin = new System.Windows.Forms.Padding(2);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(30, 23);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picRefresh.TabIndex = 29;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // frmGestionPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.dgvAbsences);
            this.Controls.Add(this.cboMotifs);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.DPickDebut);
            this.Controls.Add(this.DPickFin);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblDateDebut);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnVider);
            this.Controls.Add(this.dgvPersonnels);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.cboServices);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGestionPersonnel";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 12, 16);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaTek86";
            this.Load += new System.EventHandler(this.frmGestionPersonnel_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboServices;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Label lblDroit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvPersonnels;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnVider;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.ComboBox cboMotifs;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.DateTimePicker DPickDebut;
        private System.Windows.Forms.DateTimePicker DPickFin;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.DataGridView dgvAbsences;
    }
}