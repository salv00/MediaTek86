using MediaTek.controleur;
using System.Windows.Forms;

namespace MediaTek.vue
{
    /// <summary>
    /// Fenêtre d'authentification
    /// </summary>
    public partial class frmLogin : Form
    {
        /// <summary>
        /// Instance du controleur
        /// </summary>
        private Controle controle;

        /// <summary>
        /// Initialisation des composants graphiques
        /// Récupération du contrôleur
        /// </summary>
        /// <param name="controle"></param>
        public frmLogin(Controle controle)
        {
            InitializeComponent();
            this.controle = controle;
            // cache le mot de passe par défaut
            txtPwd.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Affiche/Cache le mot de passe
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkboxPwd_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chkboxPwd.Checked)
            {
                txtPwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtPwd.UseSystemPasswordChar = true;
            }
        }

        /// <summary>
        /// Contrôle l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSeConnecter_Click(object sender, System.EventArgs e)
        {
            if (!txtLogin.Text.Equals("") && !txtPwd.Text.Equals(""))
            {
                if (!controle.Authentification(txtLogin.Text, txtPwd.Text))
                {
                    MessageBox.Show("Authentification incorrecte", "Alerte");
                    txtLogin.Text = "";
                    txtPwd.Text = "";
                    txtLogin.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void MinimizeApp_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FermeApp_Click(object sender, System.EventArgs e)
        {
            Application.Exit();

        }
    }
}
