using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Package des classes métiers des tables de la bdd
/// </summary>
namespace mediatek86.modele
{
    class Absence
    {
        public Personnel Personnel { get; }
        public DateTime Datedebut { get; }
        public DateTime Datefin { get; }
        public Motif Motif { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="personnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(Personnel personnel, DateTime datedebut, DateTime datefin, Motif motif)
        {
            this.Personnel = personnel;
            this.Datedebut = datedebut;
            this.Datefin = datefin;
            this.Motif = motif;
        }
    }
}
