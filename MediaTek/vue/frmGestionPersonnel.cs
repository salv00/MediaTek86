using MediaTek.controleur;
using MediaTek.modele;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MediaTek.vue
{
    /// <summary>
    /// Fenêtre d'affichage des personnels et de leurs informations
    /// </summary>
    public partial class frmGestionPersonnel : Form
    {
        /// <summary>
        /// Instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Objet pour gérer la liste des personnels
        /// </summary>
        BindingSource bsPersonnels = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        BindingSource bsServices = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        BindingSource bsAbsences = new BindingSource();

        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        BindingSource bsMotifs = new BindingSource();

        /// <summary>
        /// Booléen pour déterminer l'affichage :
        /// - GESTION DU PERSONNEL
        /// - GESTION DES ABSENCES
        /// </summary>
        private bool show;

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du controleur
        /// </summary>
        /// <param name="controle"></param>
        public frmGestionPersonnel(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            Init();
        }

        /// <summary>
        /// Initialisation : GESTION DU PERSONNEL
        /// </summary>
        public void Init()
        {
            // Remplissage des listes
            RemplirDGVPersonnels();
            RemplirCboServices();

            // Affichage des composants graphiques
            show = false;
            ShowComponents(show);
        }

        /// <summary>
        /// Affiche/Cache les composants graphiques
        /// </summary>
        /// <param name="show"></param>
        public void ShowComponents(bool show)
        {
            // GESTION DU PERSONNEL
            txtNom.Enabled = !show;
            txtPrenom.Enabled = !show;
            lblService.Visible = !show;
            cboServices.Visible = !show;
            dgvPersonnels.Visible = !show;

            // GESTION DES ABSENCES
            dgvAbsences.Visible = show;
            lblDateDebut.Visible = show;
            lblDateFin.Visible = show;
            DPickDebut.Visible = show;
            DPickFin.Visible = show;
            lblMotif.Visible = show;
            cboMotifs.Visible = show;

            if (!show)
            {
                // GESTION DU PERSONNEL
                picRefresh.Location = new Point(205, 214);
                btnVider.Location = new Point(240, 214);
                lblNom.ForeColor = System.Drawing.Color.Indigo;
                lblPrenom.ForeColor = System.Drawing.Color.Indigo;
                btnSwitch.Text = "Gestion Absences";
                lblGauche.Text = "INFORMATION PERSONNEL";
                lblDroit.Text = "LISTE DU PERSONNEL";
            }
            else
            {
                // GESTION DES ABSENCES
                picRefresh.Location = new Point(205, 263);
                btnVider.Location = new Point(240, 263);
                lblNom.ForeColor = System.Drawing.Color.DimGray;
                lblPrenom.ForeColor = System.Drawing.Color.DimGray;
                btnSwitch.Text = "Liste Du Personnel";
                lblGauche.Text = "DÉTAIL ABSENCES";
                lblDroit.Text = "LISTE ABSENCES";
            }
        }

        /// <summary>
        /// Affiche les personnels
        /// </summary>
        public void RemplirDGVPersonnels()
        {
            List<Personnel> lesPersonnels = controle.GetLesPersonnels();
            bsPersonnels.DataSource = lesPersonnels;
            dgvPersonnels.DataSource = bsPersonnels;
            dgvPersonnels.Columns["idpersonnel"].Visible = false;
            dgvPersonnels.Columns["idservice"].Visible = false;
            dgvPersonnels.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        public void RemplirCboServices()
        {
            List<Service> lesServices = controle.GetLesServices();
            bsServices.DataSource = lesServices;
            cboServices.DataSource = bsServices;
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        public void RemplirDGVAbsences()
        {
            Personnel personnel = (Personnel)bsPersonnels.List[bsPersonnels.Position];
            List<Absence> lesAbsences = controle.GetLesAbsences(personnel.Idpersonnel);
            bsAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bsAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.Columns["idmotif"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        /// <summary>
        /// Affiche les motifs 
        /// </summary>
        public void RemplirCboMotifs()
        {
            List<Motif> lesMotifs = controle.GetLesMotifs();
            bsMotifs.DataSource = lesMotifs;
            cboMotifs.DataSource = bsMotifs;
        }

        /// <summary>
        /// Affiche les informations du personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPersonnels_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvPersonnels.CurrentRow;
            txtNom.Text = row.Cells["Nom"].Value.ToString();
            txtPrenom.Text = row.Cells["Prenom"].Value.ToString();
            txtTel.Text = row.Cells["Tel"].Value.ToString();
            txtEmail.Text = row.Cells["Mail"].Value.ToString();
            cboServices.Text = row.Cells["Service"].Value.ToString();
        }

        /// <summary>
        /// Affiche le détail de l'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvAbsences_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvAbsences.CurrentRow;
            DPickDebut.Value = (DateTime)row.Cells["Datedebut"].Value;
            DPickFin.Value = (DateTime)row.Cells["Datefin"].Value;
            cboMotifs.Text = row.Cells["Motif"].Value.ToString();
        }

        /// <summary>
        /// Demande d'ajout
        /// Condition : tous les champs doivent être remplis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, System.EventArgs e)
        {
            // AJOUT D'UN PERSONNEL
            if (!show)
            {
                if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtEmail.Text.Equals("") && cboServices.SelectedIndex != -1)
                {
                    int idpersonnel = 0;
                    Service service = (Service)bsServices.List[bsServices.Position];
                    Personnel personnel = new Personnel(idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtEmail.Text, service.Idservice, service.Nom);
                    controle.AddPersonnel(personnel);

                    // Test si une ligne a été ajouté
                    int nbRecord = dgvPersonnels.Rows.Count;
                    RemplirDGVPersonnels();
                    if (nbRecord < dgvPersonnels.Rows.Count)
                    {
                        dgvPersonnels.ClearSelection();
                        Vider();
                        MessageBox.Show("Le personnel a été ajouté avec succès.", "Information");
                    }
                    else
                    {
                        // La combinaison (nom, prénom) existe dans la BDD
                        MessageBox.Show("Ce personnel existe déjà.", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
            }
            // AJOUT D'UNE ABSENCE
            else
            {
                if (cboMotifs.SelectedIndex != -1)
                {
                    Motif motif = (Motif)bsMotifs.List[bsMotifs.Position];
                    Personnel personnel = (Personnel)bsPersonnels.List[bsPersonnels.Position];
                    Absence absence = new Absence(DPickDebut.Value, DPickFin.Value, personnel.Idpersonnel, motif.Idmotif, motif.Libelle);
                    controle.AddAbsence(absence, personnel.Idpersonnel);

                    // Test si une ligne a été ajouté
                    int nbRecord = dgvAbsences.Rows.Count;
                    RemplirDGVAbsences();
                    if (nbRecord < dgvAbsences.Rows.Count)
                    {
                        dgvAbsences.ClearSelection();
                        Vider();
                        MessageBox.Show("L'absence a été ajouté avec succès.", "Information");
                    }
                    else
                    {
                        // Se positionne sur l'élément dont la date de début existe déjà
                        dgvAbsences.ClearSelection();
                        int rowIndex = -1;
                        foreach (DataGridViewRow row in dgvAbsences.Rows)
                        {
                            if (row.Cells["datedebut"].Value.ToString().Equals(absence.Datedebut.ToString()))
                            {
                                rowIndex = row.Index;
                                break;
                            }
                        }
                        dgvAbsences.CurrentCell = this.dgvAbsences[1, rowIndex];
                        dgvAbsences.CurrentCell.Selected = true;

                        // La combinaison (datedebut, idpersonnel) existe dans la BDD
                        MessageBox.Show("La date de début correspond à une absence existante.", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Tous les champs doivent être remplis.", "Information");
                }
            }
        }

        /// <summary>
        /// Demande de suppression
        /// Condition : une ligne doit être sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, System.EventArgs e)
        {
            // SUPPRESSION D'UNE ABSENCE
            if (!show)
            {
                if (dgvPersonnels.SelectedRows.Count > 0)
                {
                    Personnel personnel = (Personnel)bsPersonnels.List[bsPersonnels.Position];

                    if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.DelPersonnel(personnel.Idpersonnel);
                        RemplirDGVPersonnels();
                    }
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                }
            }
            // SUPPRESSION D'UN PERSONNEL
            else
            {
                if (dgvAbsences.SelectedRows.Count > 0)
                {
                    Personnel personnel = (Personnel)bsPersonnels.List[bsPersonnels.Position];
                    Absence absence = (Absence)bsAbsences.List[bsAbsences.Position];

                    if (MessageBox.Show("Voulez-vous vraiment supprimer l'absence du " + absence.Datedebut.ToShortDateString() + " au " + absence.Datefin.ToShortDateString() + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.DelAbsence(absence, personnel.Idpersonnel);
                        RemplirDGVAbsences();
                    }
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                }
            }
        }

        /// <summary>
        /// Demande de modification
        /// Condition : une ligne doit être sélectionnée
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, System.EventArgs e)
        {
            // MODIFICATION D'UN PERSONNEL
            if (!show)
            {
                if (dgvPersonnels.SelectedRows.Count > 0)
                {
                    Service service = (Service)bsServices.List[bsServices.Position];
                    Personnel personnel = (Personnel)bsPersonnels.List[bsPersonnels.Position];
                    personnel = new Personnel(personnel.Idpersonnel, txtNom.Text, txtPrenom.Text, txtTel.Text, txtEmail.Text, service.Idservice, service.Nom);

                    if (MessageBox.Show("Voulez-vous modifier les informations concernant ce personnel ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        controle.UpdatePersonnel(personnel);
                        RemplirDGVPersonnels();

                        // Test si la modification ne s'est pas faite
                        if (!(txtNom.Text.Contains(personnel.Nom) && txtPrenom.Text.Contains(personnel.Prenom)))
                        {
                            // La combinaison (nom, prénom) existe dans la BDD
                            MessageBox.Show("Ce personnel existe déjà.","Information");
                        }

                        // Sélectionne l'élément modifié ou à modifier (idpersonnel)
                        dgvPersonnels.ClearSelection();
                        int rowIndex = -1;
                        foreach (DataGridViewRow row in dgvPersonnels.Rows)
                        {
                            if (row.Cells["idpersonnel"].Value.ToString().Equals(personnel.Idpersonnel.ToString()))
                            {
                                rowIndex = row.Index;
                                break;
                            }
                        }
                        dgvPersonnels.CurrentCell = this.dgvPersonnels[1, rowIndex];
                        dgvPersonnels.CurrentCell.Selected = true;
                    }
                }
                else
                {
                    MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
                }
            }
            // MODIFICATION D'UNE ABSENCE
            else
            {
                if (dgvAbsences.SelectedRows.Count > 0)
                {
                    Personnel personnel = (Personnel)bsPersonnels.List[bsPersonnels.Position];
                    Motif motif = (Motif)bsMotifs.List[bsMotifs.Position];

                    // Données récupérées de la ligne à modifier
                    Absence absenceOLD = new Absence((DateTime)dgvAbsences.CurrentRow.Cells["Datedebut"].Value,
                                                     (DateTime)dgvAbsences.CurrentRow.Cells["Datefin"].Value,
                                                     personnel.Idpersonnel,
                                                     (int)dgvAbsences.CurrentRow.Cells["Idmotif"].Value,
                                                     (string)dgvAbsences.CurrentRow.Cells["Motif"].Value);

                    // Données récupérées de la saisie
                    Absence absenceNEW = new Absence(DPickDebut.Value, DPickFin.Value, personnel.Idpersonnel, motif.Idmotif, motif.Libelle);

                    if (MessageBox.Show("Voulez-vous modifier les informations concernant cette absence ?", "Confirmation de modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        // Supprime l'absence à modifier
                        // La modification de la date de début (PK) crée un conflit en BDD
                        controle.DelAbsence(absenceOLD, personnel.Idpersonnel);
                        
                        // Ajoute si possible l'absence avec les nouvelles valeurs en remplacement
                        controle.AddAbsence(absenceNEW, personnel.Idpersonnel);

                        // Rajoute l'absence initiale (non modifié) si la nouvelle absence n'est pas ajouté en BDD
                        int nbRecord = dgvAbsences.Rows.Count;
                        RemplirDGVAbsences();
                        if (nbRecord != dgvAbsences.Rows.Count)
                        {
                            controle.AddAbsence(absenceOLD, personnel.Idpersonnel);
                            RemplirDGVAbsences();

                            // Se positionne sur l'élément dont la date de début existe déjà
                            dgvAbsences.ClearSelection();
                            int rowIndex = -1;
                            foreach (DataGridViewRow row in dgvAbsences.Rows)
                            {
                                if (row.Cells["datedebut"].Value.ToString().Equals(absenceNEW.Datedebut.ToString()))
                                {
                                    rowIndex = row.Index;
                                    break;
                                }
                            }
                            dgvAbsences.CurrentCell = this.dgvAbsences[0, rowIndex];
                            dgvAbsences.CurrentCell.Selected = true;

                            // La combinaison (datedebut, idpersonnel) existe dans la BDD
                            MessageBox.Show("La date de début correspond à une absence existante.", "Information");
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Mise à jour des données provenant de la BDD
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picRefresh_Click(object sender, System.EventArgs e)
        {
            RemplirDGVPersonnels();
            RemplirCboServices();
            RemplirDGVAbsences();
            RemplirCboMotifs();
        }
        /// <summary>
        /// Vide les champs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVider_Click(object sender, System.EventArgs e)
        {
            Vider();
        }

        /// <summary>
        /// Vide les champs
        /// </summary>
        private void Vider()
        {
            // GESTION DU PERSONNEL
            if (!show)
            {
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtEmail.Text = "";
                cboServices.SelectedIndex = -1;
                dgvPersonnels.ClearSelection();
                txtNom.Focus();
            }
            // GESTION DES ABSENCES
            else
            {
                DPickDebut.Value = DateTime.Now;
                DPickFin.Value = DateTime.Now;
                cboMotifs.SelectedIndex = -1;
                dgvAbsences.ClearSelection();
                DPickDebut.Focus();
            }
        }

        /// <summary>
        /// Affiche les bons composants graphiques
        /// Condition : une ligne doit être sélectionnée pour basculer sur la gestion des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSwitch_Click(object sender, System.EventArgs e)
        {
            if (dgvPersonnels.CurrentCell.Selected)
            {
                // Affiche : GESTION DES ABSENCES
                if (!show)
                {
                    show = true;
                    ShowComponents(show);
                    RemplirCboMotifs();
                    RemplirDGVAbsences();
                }
                // Affiche : GESTION DU PERSONNEL
                else
                {
                    show = false;
                    ShowComponents(show);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void frmGestionPersonnel_Load(object sender, EventArgs e)
        {

        }
    }
}
