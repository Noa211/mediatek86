using mediatek86.controlleur;
using mediatek86.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Package de l'interface humain-machine
/// </summary>
namespace mediatek86.vue
{
    public partial class frmPersonnel : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification du personnel est demandée
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Booléen pour savoir si une modification d'une absence est demandée
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmPersonnelController controller;
        /// <summary>
        /// Membre du personnel dont les absences sont en train d'être gérées
        /// </summary>
        private Personnel personnelModifAbs;
        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        private readonly BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des service
        /// </summary>
        private readonly BindingSource bdgService = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private readonly BindingSource bdgMotif = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private readonly BindingSource bdgAbsence = new BindingSource();
        /// <summary>
        /// Titre des fenêtres d'information
        /// </summary>
        private readonly String titreFenetreInformation = "Information";

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public frmPersonnel()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmPersonnelController();
            RemplirListePersonnel();
            RemplirListeService();
            RemplirListeMotif();
            EnCoursModifPersonnel(false);
        }

        /// <summary>
        /// Affiche le personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controller.GetPersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeService()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgService.DataSource = lesServices;
            cmbService.DataSource = bdgService;
        }

        /// <summary>
        /// Affiche les motifs
        /// </summary>
        private void RemplirListeMotif()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            cmbMotif.DataSource = bdgMotif;
        }

        /// <summary>
        /// Affiche les absences
        /// </summary>
        private void RemplirListeAbsence(Personnel personnel)
        {
            List<Absence> lesAbsences = controller.GetLesAbsences(personnel);
            bdgAbsence.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsence;
        }

        /// <summary>
        /// Demande d'enregistrement d'un ajout ou modification de personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSavePer_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cmbService.SelectedIndex != -1)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                if (enCoursDeModifPersonnel)
                {
                    if (MessageBox.Show("Voulez-vous vraiment modifier ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                        personnel.Nom = txtNom.Text;
                        personnel.Prenom = txtPrenom.Text;
                        personnel.Tel = txtTel.Text;
                        personnel.Mail = txtMail.Text;
                        personnel.Service = service;
                        controller.UpdatePersonnel(personnel);
                    }
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTel.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                EnCoursModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
            }
        }
        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout de personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grbPersonnel.Enabled = !modif;
            if (modif)
            {
                grbAddPer.Text = "modifier le personnel";
            }
            else
            {
                grbAddPer.Text = "ajouter du personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        /// <summary>
        /// Demande d'annulation d'ajout ou de modification de personnel
        /// Vide les champs de texte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulPer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifPersonnel(false);
            }
        }

        /// <summary>
        /// Demande de suppression du personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande de modification du personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierPer_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTel.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cmbService.SelectedIndex = cmbService.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande de gestion des absences du personnel sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGererAbs_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                personnelModifAbs = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                RemplirListeAbsence(personnelModifAbs);
                GererAbsences(true);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Changement d'interface pour activer ou désactiver le mode gestion d'absence
        /// </summary>
        /// <param name="modif"></param>
        private void GererAbsences(Boolean modif)
        {
            grbAbsences.Enabled = modif;
            grbAddAbs.Enabled = modif;
            grbPersonnel.Enabled = !modif;
            grbAddPer.Enabled = !modif;
            dtpDebut.Value = System.DateTime.Today;
            dtpFin.Value = System.DateTime.Today;
            cmbMotif.SelectedIndex = -1;
        }

        /// <summary>
        /// Demande d'enregistement d'un ajout ou d'une mofication d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAbs_Click(object sender, EventArgs e)
        {
            if (dtpDebut.Value > dtpDebut.MinDate && dtpDebut.Value < dtpDebut.MaxDate && dtpFin.Value > dtpFin.MinDate && dtpFin.Value < dtpFin.MaxDate && cmbMotif.SelectedIndex != -1 && dtpFin.Value >= dtpDebut.Value)
            {
                Motif motif = (Motif)bdgMotif.List[bdgMotif.Position];
                if (enCoursDeModifAbsence)
                {
                    Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                    Absence absenceOriginal = new Absence(absence.Personnel, absence.Datedebut, absence.Datefin, absence.Motif);
                    absence.Datedebut = dtpDebut.Value;
                    absence.Datefin = dtpFin.Value;
                    absence.Motif = motif;
                    controller.UpdateAbsence(absence, absenceOriginal);
                }
                else
                {
                    Absence absence = new Absence(personnelModifAbs, dtpDebut.Value, dtpFin.Value, motif);
                    controller.AddAbsence(absence);
                }
                RemplirListeAbsence(personnelModifAbs);
                EnCoursModifAbsence(false);

            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout d'une absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            grbAbsences.Enabled = !modif;
            if (modif)
            {
                grbAddAbs.Text = "modifier une absence";
            } 
            else
            {
                grbAddAbs.Text = "ajouter une absence";
                dtpDebut.Value = System.DateTime.Today;
                dtpFin.Value = System.DateTime.Today;
            }
        }

        /// <summary>
        /// Demande d'annulation de l'ajout ou d'une modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulAbs_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifAbsence(false);
            }
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette absence ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelAbsence(absence);
                    RemplirListeAbsence(personnelModifAbs);
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifAbs_Click(object sender, EventArgs e)
        {
            if (dgvAbsences.SelectedRows.Count > 0)
            {
                EnCoursModifAbsence(true);
                Absence absence = (Absence)bdgAbsence.List[bdgAbsence.Position];
                dtpDebut.Value = absence.Datedebut;
                dtpFin.Value = absence.Datefin;
                cmbMotif.SelectedIndex = cmbMotif.FindStringExact(absence.Motif.Libelle);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", titreFenetreInformation);
            }
        }

        /// <summary>
        /// Demande de sortir du mode gestion des absences
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRetour_Click(object sender, EventArgs e)
        {
            GererAbsences(false);
        }
    }
}
