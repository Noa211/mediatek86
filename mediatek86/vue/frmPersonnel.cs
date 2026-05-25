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

        private FrmPersonnelController controller;

        private readonly BindingSource bdgPersonnel = new BindingSource();

        private readonly BindingSource bdgService = new BindingSource();

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

        private void btnSavePer_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTel.Text.Equals("") && !txtMail.Text.Equals("") && cmbService.SelectedIndex != -1)
            {
                Service service = (Service)bdgService.List[bdgService.Position];
                if (enCoursDeModifPersonnel)
                {
                    return;
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
    }
}
