using mediatek86.dal;
using mediatek86.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.controlleur
{
    class FrmPersonnelController
    {
        private readonly PersonnelAccess personnelAccess;

        private readonly AbsenceAccess absenceAccess;

        private readonly ServiceAccess serviceAccess;

        private readonly MotifAccess motifAccess;

        public FrmPersonnelController()
        {
            personnelAccess = new PersonnelAccess();
            absenceAccess = new AbsenceAccess();
            serviceAccess = new ServiceAccess();
            motifAccess = new MotifAccess();
        }

        public List<Personnel> GetPersonnel()
        {
            return personnelAccess.GetPersonnel();
        }

        public List<Service> GetLesServices()
        {
            return serviceAccess.GetLesServices();
        }

        public void AddPersonnel(Personnel personnel)
        {
            personnelAccess.AddPersonnel(personnel);
        }

        public void DelPersonnel(Personnel personnel)
        {
            personnelAccess.DelPersonnel(personnel);
        }

        public void UpdatePersonnel(Personnel personnel)
        {
            personnelAccess.UpdatePersonnel(personnel);
        }

        public List<Motif> GetLesMotifs()
        {
            return motifAccess.GetLesMotifs();
        }

        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            return absenceAccess.GetLesAbsences(personnel);
        }

        public void AddAbsence(Absence absence)
        {
            absenceAccess.AddAbsence(absence);
        }

        public void DelAbsence(Absence absence)
        {
            absenceAccess.DelAbsence(absence);
        }

        public void UpdateAbsence(Absence absence, Absence absenceOriginal)
        {
            absenceAccess.UpdateAbsence(absence, absenceOriginal);
        }
    }
}
