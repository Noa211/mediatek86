using mediatek86.modele;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.dal
{
    /// <summary>
    /// Classe permettant de gérer les demandes concernant les absences
    /// </summary>
    class AbsenceAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public AbsenceAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Récupère et retourne les absences d'un certain membre du personnel
        /// </summary>
        /// <param name="personnel">objet personnel lié aux absences</param>
        /// <returns>liste des absences</returns>
        public List<Absence> GetLesAbsences(Personnel personnel)
        {
            List<Absence> lesAbsences = new List<Absence>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, a.datedebut as datedebut, a.datefin as datefin, m.idmotif as idmotif, m.libelle as libelle ";
                req += "from absence a join personnel p on (a.idpersonnel = p.idpersonnel) join motif m on (a.idmotif = m.idmotif) ";
                req += "where p.idpersonnel = @idpersonnel ";
                req += "order by datedebut desc;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", personnel.Idpersonnel }
                };
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        Log.Debug("AbsenceAccess.GetLesAbsences nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("AbsenceAccess.GetLesAbsences Personnel : id={0} nom={1} prenom={2}", record[0], record[1], record[2]);
                            Log.Debug("AbsenceAccess.GetLesAbsences Absence : datedebut={0}, datefin={1}", record[3], record[4]);
                            Log.Debug("AbsenceAccess.GetLesAbsences Motif : id={0} libelle={1}", record[5], record[6]);
                            Motif motif = new Motif((int)record[5], (string)record[6]);
                            Absence absence = new Absence(personnel, (DateTime)record[3], (DateTime)record[4], motif);
                            lesAbsences.Add(absence);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.GetLesAbsences catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lesAbsences;
        }

        /// <summary>
        /// Demande d'ajout d'une absence
        /// </summary>
        /// <param name="absence">objet absence à ajouter</param>
        public void AddAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "insert into absence(idpersonnel, datedebut, datefin, idmotif) ";
                req += "values (@idpersonnel, @datedebut, @datefin, @idmotif);";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.Personnel.Idpersonnel },
                    { "@datedebut", absence.Datedebut },
                    { "@datefin", absence.Datefin },
                    { "@idmotif", absence.Motif.Idmotif }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.AddAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de suppresion d'une absence
        /// </summary>
        /// <param name="absence">objet absence à supprimer</param>
        public void DelAbsence(Absence absence)
        {
            if (access.Manager != null)
            {
                string req = "delete from absence where idpersonnel = @idpersonnel and datedebut = @datedebut;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", absence.Personnel.Idpersonnel },
                    { "@datedebut", absence.Datedebut }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.DelAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification d'une absence
        /// </summary>
        /// <param name="absence">objet absence à modifier</param>
        /// <param name="absenceOriginal">objet absence avant modification</param>
        public void UpdateAbsence(Absence absence, Absence absenceOriginal)
        {
            if (access.Manager != null)
            {
                string req = "update absence set datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif ";
                req += "where idpersonnel = @idpersonnel and datedebut = @datedebutoriginal;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@datedebut", absence.Datedebut },
                    { "@datefin", absence.Datefin },
                    { "@idmotif", absence.Motif.Idmotif },
                    { "@idpersonnel", absence.Personnel.Idpersonnel },
                    { "@datedebutoriginal", absenceOriginal.Datedebut }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("AbsenceAccess.UpdateAbsence catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
