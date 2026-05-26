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
    /// Classe permettant de gérer les demandes concernant le personnel
    /// </summary>
    class PersonnelAccess
    {
        /// <summary>
        /// Instance unique de l'accès aux données
        /// </summary>
        private readonly Access access = null;

        /// <summary>
        /// Constructeur pour créer l'accès aux données
        /// </summary>
        public PersonnelAccess()
        {
            access = Access.GetInstance();
        }

        /// <summary>
        /// Controle si l'utillisateur a le bon login et mot de passe
        /// </summary>
        /// <param name="responsable"></param>
        /// <returns>vrai si l'utilisateur a entré les bons identifiants</returns>
        public Boolean ControleAuthentification(Responsable responsable)
        {
            if (access.Manager != null)
            {
                string req = "select * from responsable ";
                req += "where login=@login and pwd=SHA2(@pwd, 256);";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@login", responsable.Login },
                    { "@pwd", responsable.Pwd }
                };
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req, parameters);
                    if (records != null)
                    {
                        return (records.Count > 0);
                    }
                } 
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.ControleAuthentification catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return false;
        }

        /// <summary>
        /// Récupère et retourne les membres du personnel
        /// </summary>
        /// <returns>liste du personnel</returns>
        public List<Personnel> GetPersonnel()
        {
            List<Personnel> lePersonnel = new List<Personnel>();
            if (access.Manager != null)
            {
                string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice, s.nom as nomservice ";
                req += "from personnel p left join service s on (p.idservice = s.idservice) ";
                req += "order by nom, prenom;";
                try
                {
                    List<Object[]> records = access.Manager.ReqSelect(req);
                    if (records != null)
                    {
                        Log.Debug("PersonnelAccess.GetPersonnel nb records = {0}", records.Count);
                        foreach (Object[] record in records)
                        {
                            Log.Debug("PersonnelAccess.GetPersonnel Service : id={0} nom={1}", record[5], record[6]);
                            Log.Debug("PersonnelAccess.GetPersonnel Personnel : id={0} nom={1} prenom={2} tel={3} mail={4} ", record[0], record[1], record[2], record[3], record[4]);
                            Service leService = new Service((int)record[5], (string)record[6]);
                            Personnel personnel = new Personnel((int)record[0], (string)record[1], (string)record[2], (string)record[3], (string)record[4], leService);
                            lePersonnel.Add(personnel);
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.GetPersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
            return lePersonnel;
        }

        /// <summary>
        /// Demande d'ajout de personnel
        /// </summary>
        /// <param name="personnel">objet personnel à ajouter</param>
        public void AddPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "insert into personnel(nom, prenom, tel, mail, idservice) ";
                req += "values (@nom, @prenom, @tel, @mail, @idservice);";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nom", personnel.Nom },
                    { "@prenom", personnel.Prenom },
                    { "@tel", personnel.Tel },
                    { "@mail", personnel.Mail },
                    { "@idservice", personnel.Service.Idservice }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.AddPersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de suppression de personnel
        /// </summary>
        /// <param name="personnel">objet personnel à supprimer</param>
        public void DelPersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "delete from personnel where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", personnel.Idpersonnel }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.DelPersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }

        /// <summary>
        /// Demande de modification de personnel
        /// </summary>
        /// <param name="personnel">objet personnel à modifier</param>
        public void UpdatePersonnel(Personnel personnel)
        {
            if (access.Manager != null)
            {
                string req = "update personnel set nom = @nom, prenom=@prenom, tel=@tel, mail=@mail, idservice=@idservice ";
                req += "where idpersonnel = @idpersonnel;";
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idpersonnel", personnel.Idpersonnel },
                    { "@nom", personnel.Nom },
                    { "@prenom", personnel.Prenom },
                    { "@tel", personnel.Tel },
                    { "@mail", personnel.Mail},
                    { "@idservice", personnel.Service.Idservice }
                };
                try
                {
                    access.Manager.ReqUpdate(req, parameters);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Log.Error("PersonnelAccess.UpdatePersonnel catch req={0} erreur={1}", req, e.Message);
                    Environment.Exit(0);
                }
            }
        }
    }
}
