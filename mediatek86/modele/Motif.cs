using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediatek86.modele
{
    /// <summary>
    /// Classe métier pour les motifs
    /// </summary>
    class Motif
    {
        public int Idmotif { get; }
        public string Libelle { get; }

        /// <summary>
        /// Valorise les propriétés
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.Idmotif = idmotif;
            this.Libelle = libelle;
        }

        /// <summary>
        /// Définit l'information à afficher (le libelle)
        /// </summary>
        /// <returns>libelle du motif</returns>
        public override string ToString()
        {
            return this.Libelle;
        }
    }
}
