using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.modele
{
    /// <summary>
    /// Classe métier pour les absences
    /// </summary>
    class Absence
    {
        public Personnel Personnel { get; }
        public DateTime Datedebut { get; set; }
        public DateTime Datefin { get; set; }
        public Motif Motif { get; set; }

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
