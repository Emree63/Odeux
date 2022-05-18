using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Cour
    {
        /// <summary>
        /// Date où à lieu du cour.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Durée du Cour.
        /// </summary>
        public TimeSpan Durée { get; set; }
        
        /// <summary>
        /// Code de la salle du cour.
        /// </summary>
        public string Salle { get; set; }

        /// <summary>
        /// Matière concernat le cour.
        /// </summary>
        private string Matière { get; set; }
        public string matière { get; set; }

        /// <summary>
        /// Enseignant charger de s'occuper du cour.
        /// </summary>
        private Professeur Enseignant;
        private Professeur enseignant { get => Enseignant; set => Enseignant = value; }

        /// <summary>
        /// Groupes à qui sont dédiers le cour.
        /// </summary>
        private List<Groupe> groupes;
        public List<Groupe> groupes2 { get => groupes; set => groupes = value; }

        /// <summary>
        /// Constructeur de la Classe Cour .
        /// </summary>
        /// <param name="date">Date où à lieu du cour</param>
        /// <param name="duree">Durée du Cour</param>
        /// <param name="salle">Code de la salle du cour</param>
        /// <param name="mat">Matière concernat le cour</param>
        /// <param name="ens">Enseignant charger du bon déroulement du cour</param>
        /// <param name="grps">Liste des groupes qui vont suivre le cour</param>
        public Cour(DateTime date, TimeSpan duree, string salle, string mat, Professeur ens, List<Groupe> grps)
        {
            Date = date;
            Durée = duree;
            Salle = salle;
            matière = mat;
            Enseignant = ens;
            groupes = grps;
        }

        public override string ToString()
        {
            return $"Cour du {Date.Day}/{Date.Month}/{Date.Year} à {Date.Hour}h{Date.Minute} jusqu'a {Date.Hour+Durée.Hours}h{Date.Minute+Durée.Minutes}  avec : {enseignant.nom}";
        }
    }
}
