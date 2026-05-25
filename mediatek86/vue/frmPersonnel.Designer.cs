
namespace mediatek86.vue
{
    partial class frmPersonnel
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
            this.grbPersonnel = new System.Windows.Forms.GroupBox();
            this.btnGererAbs = new System.Windows.Forms.Button();
            this.btnSupprimerPer = new System.Windows.Forms.Button();
            this.btnModifierPer = new System.Windows.Forms.Button();
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.grbAddPer = new System.Windows.Forms.GroupBox();
            this.btnAnnulPer = new System.Windows.Forms.Button();
            this.btnSavePer = new System.Windows.Forms.Button();
            this.cmbService = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbAbsences = new System.Windows.Forms.GroupBox();
            this.grbAddAbs = new System.Windows.Forms.GroupBox();
            this.btnAnnulAbs = new System.Windows.Forms.Button();
            this.btnSaveAbs = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbMotif = new System.Windows.Forms.ComboBox();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRetour = new System.Windows.Forms.Button();
            this.btnSupprimerAbs = new System.Windows.Forms.Button();
            this.btnModifAbs = new System.Windows.Forms.Button();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.grbPersonnel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.grbAddPer.SuspendLayout();
            this.grbAbsences.SuspendLayout();
            this.grbAddAbs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.SuspendLayout();
            // 
            // grbPersonnel
            // 
            this.grbPersonnel.Controls.Add(this.btnGererAbs);
            this.grbPersonnel.Controls.Add(this.btnSupprimerPer);
            this.grbPersonnel.Controls.Add(this.btnModifierPer);
            this.grbPersonnel.Controls.Add(this.dgvPersonnel);
            this.grbPersonnel.Location = new System.Drawing.Point(13, 13);
            this.grbPersonnel.Name = "grbPersonnel";
            this.grbPersonnel.Size = new System.Drawing.Size(775, 309);
            this.grbPersonnel.TabIndex = 0;
            this.grbPersonnel.TabStop = false;
            this.grbPersonnel.Text = "le personnel";
            // 
            // btnGererAbs
            // 
            this.btnGererAbs.Location = new System.Drawing.Point(589, 273);
            this.btnGererAbs.Name = "btnGererAbs";
            this.btnGererAbs.Size = new System.Drawing.Size(162, 27);
            this.btnGererAbs.TabIndex = 3;
            this.btnGererAbs.Text = "gérer les absences";
            this.btnGererAbs.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPer
            // 
            this.btnSupprimerPer.Location = new System.Drawing.Point(111, 273);
            this.btnSupprimerPer.Name = "btnSupprimerPer";
            this.btnSupprimerPer.Size = new System.Drawing.Size(90, 27);
            this.btnSupprimerPer.TabIndex = 2;
            this.btnSupprimerPer.Text = "supprimer";
            this.btnSupprimerPer.UseVisualStyleBackColor = true;
            this.btnSupprimerPer.Click += new System.EventHandler(this.btnSupprimerPer_Click);
            // 
            // btnModifierPer
            // 
            this.btnModifierPer.Location = new System.Drawing.Point(7, 273);
            this.btnModifierPer.Name = "btnModifierPer";
            this.btnModifierPer.Size = new System.Drawing.Size(97, 27);
            this.btnModifierPer.TabIndex = 1;
            this.btnModifierPer.Text = "modifier";
            this.btnModifierPer.UseVisualStyleBackColor = true;
            this.btnModifierPer.Click += new System.EventHandler(this.btnModifierPer_Click);
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(7, 22);
            this.dgvPersonnel.MultiSelect = false;
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.ReadOnly = true;
            this.dgvPersonnel.RowHeadersWidth = 51;
            this.dgvPersonnel.RowTemplate.Height = 24;
            this.dgvPersonnel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonnel.Size = new System.Drawing.Size(744, 244);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // grbAddPer
            // 
            this.grbAddPer.Controls.Add(this.btnAnnulPer);
            this.grbAddPer.Controls.Add(this.btnSavePer);
            this.grbAddPer.Controls.Add(this.cmbService);
            this.grbAddPer.Controls.Add(this.label4);
            this.grbAddPer.Controls.Add(this.txtMail);
            this.grbAddPer.Controls.Add(this.txtTel);
            this.grbAddPer.Controls.Add(this.label3);
            this.grbAddPer.Controls.Add(this.lblTel);
            this.grbAddPer.Controls.Add(this.txtPrenom);
            this.grbAddPer.Controls.Add(this.txtNom);
            this.grbAddPer.Controls.Add(this.label2);
            this.grbAddPer.Controls.Add(this.label1);
            this.grbAddPer.Location = new System.Drawing.Point(13, 329);
            this.grbAddPer.Name = "grbAddPer";
            this.grbAddPer.Size = new System.Drawing.Size(775, 164);
            this.grbAddPer.TabIndex = 1;
            this.grbAddPer.TabStop = false;
            this.grbAddPer.Text = "ajouter du personnel";
            // 
            // btnAnnulPer
            // 
            this.btnAnnulPer.Location = new System.Drawing.Point(117, 131);
            this.btnAnnulPer.Name = "btnAnnulPer";
            this.btnAnnulPer.Size = new System.Drawing.Size(84, 24);
            this.btnAnnulPer.TabIndex = 11;
            this.btnAnnulPer.Text = "annuler";
            this.btnAnnulPer.UseVisualStyleBackColor = true;
            this.btnAnnulPer.Click += new System.EventHandler(this.btnAnnulPer_Click);
            // 
            // btnSavePer
            // 
            this.btnSavePer.Location = new System.Drawing.Point(7, 130);
            this.btnSavePer.Name = "btnSavePer";
            this.btnSavePer.Size = new System.Drawing.Size(103, 25);
            this.btnSavePer.TabIndex = 10;
            this.btnSavePer.Text = "enregistrer";
            this.btnSavePer.UseVisualStyleBackColor = true;
            this.btnSavePer.Click += new System.EventHandler(this.btnSavePer_Click);
            // 
            // cmbService
            // 
            this.cmbService.FormattingEnabled = true;
            this.cmbService.Location = new System.Drawing.Point(409, 95);
            this.cmbService.Name = "cmbService";
            this.cmbService.Size = new System.Drawing.Size(206, 24);
            this.cmbService.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(349, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "service";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(409, 63);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(342, 22);
            this.txtMail.TabIndex = 7;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(409, 34);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(342, 22);
            this.txtTel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "mail";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(379, 34);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(23, 17);
            this.lblTel.TabIndex = 4;
            this.lblTel.Text = "tel";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(72, 60);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(264, 22);
            this.txtPrenom.TabIndex = 3;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(72, 31);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(264, 22);
            this.txtNom.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "nom";
            // 
            // grbAbsences
            // 
            this.grbAbsences.Controls.Add(this.grbAddAbs);
            this.grbAbsences.Controls.Add(this.btnRetour);
            this.grbAbsences.Controls.Add(this.btnSupprimerAbs);
            this.grbAbsences.Controls.Add(this.btnModifAbs);
            this.grbAbsences.Controls.Add(this.dgvAbsences);
            this.grbAbsences.Enabled = false;
            this.grbAbsences.Location = new System.Drawing.Point(13, 500);
            this.grbAbsences.Name = "grbAbsences";
            this.grbAbsences.Size = new System.Drawing.Size(775, 336);
            this.grbAbsences.TabIndex = 2;
            this.grbAbsences.TabStop = false;
            this.grbAbsences.Text = "absences";
            // 
            // grbAddAbs
            // 
            this.grbAddAbs.Controls.Add(this.btnAnnulAbs);
            this.grbAddAbs.Controls.Add(this.btnSaveAbs);
            this.grbAddAbs.Controls.Add(this.label7);
            this.grbAddAbs.Controls.Add(this.cmbMotif);
            this.grbAddAbs.Controls.Add(this.dtpFin);
            this.grbAddAbs.Controls.Add(this.dtpDebut);
            this.grbAddAbs.Controls.Add(this.label6);
            this.grbAddAbs.Controls.Add(this.label5);
            this.grbAddAbs.Location = new System.Drawing.Point(7, 211);
            this.grbAddAbs.Name = "grbAddAbs";
            this.grbAddAbs.Size = new System.Drawing.Size(762, 119);
            this.grbAddAbs.TabIndex = 4;
            this.grbAddAbs.TabStop = false;
            this.grbAddAbs.Text = "ajouter une absence";
            // 
            // btnAnnulAbs
            // 
            this.btnAnnulAbs.Location = new System.Drawing.Point(526, 76);
            this.btnAnnulAbs.Name = "btnAnnulAbs";
            this.btnAnnulAbs.Size = new System.Drawing.Size(82, 28);
            this.btnAnnulAbs.TabIndex = 7;
            this.btnAnnulAbs.Text = "annuler";
            this.btnAnnulAbs.UseVisualStyleBackColor = true;
            // 
            // btnSaveAbs
            // 
            this.btnSaveAbs.Location = new System.Drawing.Point(402, 76);
            this.btnSaveAbs.Name = "btnSaveAbs";
            this.btnSaveAbs.Size = new System.Drawing.Size(105, 28);
            this.btnSaveAbs.TabIndex = 6;
            this.btnSaveAbs.Text = "enregistrer";
            this.btnSaveAbs.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(357, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "motif";
            // 
            // cmbMotif
            // 
            this.cmbMotif.FormattingEnabled = true;
            this.cmbMotif.Location = new System.Drawing.Point(402, 31);
            this.cmbMotif.Name = "cmbMotif";
            this.cmbMotif.Size = new System.Drawing.Size(206, 24);
            this.cmbMotif.TabIndex = 4;
            // 
            // dtpFin
            // 
            this.dtpFin.CustomFormat = "";
            this.dtpFin.Location = new System.Drawing.Point(108, 77);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 22);
            this.dtpFin.TabIndex = 3;
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(108, 29);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 22);
            this.dtpDebut.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "date de fin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "date de début";
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(676, 178);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 27);
            this.btnRetour.TabIndex = 3;
            this.btnRetour.Text = "retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbs
            // 
            this.btnSupprimerAbs.Location = new System.Drawing.Point(110, 178);
            this.btnSupprimerAbs.Name = "btnSupprimerAbs";
            this.btnSupprimerAbs.Size = new System.Drawing.Size(97, 27);
            this.btnSupprimerAbs.TabIndex = 2;
            this.btnSupprimerAbs.Text = "supprimer";
            this.btnSupprimerAbs.UseVisualStyleBackColor = true;
            // 
            // btnModifAbs
            // 
            this.btnModifAbs.Location = new System.Drawing.Point(6, 178);
            this.btnModifAbs.Name = "btnModifAbs";
            this.btnModifAbs.Size = new System.Drawing.Size(98, 27);
            this.btnModifAbs.TabIndex = 1;
            this.btnModifAbs.Text = "modifier";
            this.btnModifAbs.UseVisualStyleBackColor = true;
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(7, 22);
            this.dgvAbsences.MultiSelect = false;
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.ReadOnly = true;
            this.dgvAbsences.RowHeadersWidth = 51;
            this.dgvAbsences.RowTemplate.Height = 24;
            this.dgvAbsences.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAbsences.Size = new System.Drawing.Size(744, 150);
            this.dgvAbsences.TabIndex = 0;
            // 
            // frmPersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 848);
            this.Controls.Add(this.grbAbsences);
            this.Controls.Add(this.grbAddPer);
            this.Controls.Add(this.grbPersonnel);
            this.Name = "frmPersonnel";
            this.Text = "Gestion du personnel";
            this.grbPersonnel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.grbAddPer.ResumeLayout(false);
            this.grbAddPer.PerformLayout();
            this.grbAbsences.ResumeLayout(false);
            this.grbAddAbs.ResumeLayout(false);
            this.grbAddAbs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbPersonnel;
        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.Button btnSupprimerPer;
        private System.Windows.Forms.Button btnModifierPer;
        private System.Windows.Forms.GroupBox grbAddPer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbService;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnAnnulPer;
        private System.Windows.Forms.Button btnSavePer;
        private System.Windows.Forms.Button btnGererAbs;
        private System.Windows.Forms.GroupBox grbAbsences;
        private System.Windows.Forms.Button btnRetour;
        private System.Windows.Forms.Button btnSupprimerAbs;
        private System.Windows.Forms.Button btnModifAbs;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.GroupBox grbAddAbs;
        private System.Windows.Forms.Button btnAnnulAbs;
        private System.Windows.Forms.Button btnSaveAbs;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbMotif;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}