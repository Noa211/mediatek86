using mediatek86.controlleur;
using mediatek86.modele;
using mediatek86.vue;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mediatek86
{
    /// <summary>
    /// Fenêtre d'authentification (seul le responsable peut se connecter)
    /// </summary>
    public partial class frmAuthentification : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmAuthentificationController controller;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public frmAuthentification()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmAuthentificationController();
        }

        /// <summary>
        /// Demande au controleur de controler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String mdp = txtMdp.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(mdp))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Information");
            } 
            else
            {
                Responsable responsable = new Responsable(login, mdp);
                if (controller.ControleAuthentification(responsable))
                {
                    frmPersonnel frm = new frmPersonnel();
                    frm.ShowDialog();
                } 
                else
                {
                    MessageBox.Show("L'identifiant ou le mot de passe ne correspond pas.", "Alerte");
                }
            }
        }
    }
}
