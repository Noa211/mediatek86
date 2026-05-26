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

        private Boolean enCoursDeModifPersonnel = false;

        private Boolean enCoursDeModifAbsence = false;

        private FrmPersonnelController controller;

        private Personnel personnelModifAbs;

        private readonly BindingSource bdgPersonnel = new BindingSource();

        private readonly BindingSource bdgService = new BindingSource();

        private readonly BindingSource bdgMotif = new BindingSource();

        private readonly BindingSource bdgAbsence = new BindingSource();

        private readonly String titreFenetreInformation = "Information";

        public frmPersonnel()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            controller = new FrmPersonnelController();
            RemplirListePersonnel();
            RemplirListeService();
            RemplirListeMotif();
            EnCoursModifPersonnel(false);
        }

        private void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controller.GetPersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void RemplirListeService()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgService.DataSource = lesServices;
            cmbService.DataSource = bdgService;
        }

        private void RemplirListeMotif()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotif.DataSource = lesMotifs;
            cmbMotif.DataSource = bdgMotif;
        }

        private void RemplirListeAbsence(Personnel personnel)
        {
            List<Absence> lesAbsences = controller.GetLesAbsences(personnel);
            bdgAbsence.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsence;
        }

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
        }

        private void EnCoursModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            grbPersonnel.Enabled = !modif;
            if (modif)
            {
                grbPersonnel.Text = "modifier le personnel";
            }
            else
            {
                grbPersonnel.Text = "ajouter du personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTel.Text = "";
                txtMail.Text = "";
            }
        }

        private void btnAnnulPer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursModifPersonnel(false);
            }
        }

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

        private void GererAbsences(Boolean modif)
        {
            grbAbsences.Enabled = modif;
            grbPersonnel.Enabled = !modif;
            grbAddPer.Enabled = !modif;
            dtpDebut.Value = System.DateTime.Today;
            dtpFin.Value = System.DateTime.Today;
            cmbMotif.SelectedIndex = -1;
        }

        private void btnSaveAbs_Click(object sender, EventArgs e)
        {
            if (dtpDebut.Value > dtpDebut.MinDate && dtpDebut.Value < dtpDebut.MaxDate && dtpFin.Value > dtpFin.MinDate && dtpFin.Value < dtpFin.MaxDate && cmbMotif.SelectedIndex != -1 && dtpFin.Value >= dtpDebut.Value)
            {
                Motif motif = (Motif)bdgMotif.List[bdgMotif.Position];
                if (enCoursDeModifAbsence)
                {
                    return;
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
    }
}
