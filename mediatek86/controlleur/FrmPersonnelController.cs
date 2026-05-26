using mediatek86.dal;
using mediatek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.controlleur
{
    /// <summary>
    /// Contrôleur de FrmPersonnel
    /// </summary>
    class FrmPersonnelController
    {
        /// <summary>
        /// objet d'accès aux opérations possible sur Personnel
        /// </summary>
        private readonly PersonnelAccess personnelAccess;

        /// <summary>
        /// objet d'accès aux opérations possible sur Absence
        /// </summary>
        private readonly AbsenceAccess absenceAccess;

        /// <summary>
        /// objet d'accès aux opérations possible sur Service
        /// </summary>
        private readonly ServiceAccess serviceAccess;

        /// <summary>
        /// objet d'accès aux opérations possible sur Motif
        /// </summary>
        private readonly MotifAccess motifAccess;

        /// <summary>
        /// Récupère les accès aux données
        /// </summary>
        public FrmPersonnelController()
        {
            personnelAccess = new PersonnelAccess();
            absenceAccess = new AbsenceAccess();
            serviceAccess = new ServiceAccess();
            motifAccess = new MotifAccess();
        }

        /// <summary>
        /// Récupère et retourne la liste du personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetPersonnel()
        {
            return personnelAccess.GetPersonnel();
        }

        /// <summary>
        /// Récupère et retourne la liste des services
        /// </summary>
        /// <returns>liste des services</returns>
        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        /// <summary>
        /// Demande d'ajout de personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        /// <summary>
        /// Demande de suppression de personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification de personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        /// <summary>
        /// Récupère et retourne la liste des motif
        /// </summary>
        /// <returns>liste des motifs</returns>
        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        /// <summary>
        /// Récupère et retourne la liste des absences
        /// </summary>
        /// <param name="personnel"></param>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            return absenceAccess.GetLesAbsences(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        /// <summary>
        /// Demande de suppression d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        /// <param name="absenceOriginal">objet absence avant modification</param>
        public void UpdateAbsence(Absence absence, Absence absenceOriginal)
        {
            absenceAccess.UpdateAbsence(absence, absenceOriginal);
        }
    }
}
