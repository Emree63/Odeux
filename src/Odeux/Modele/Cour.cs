using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    public class Cour
    {
        /// <summary>
        /// Date où a lieu le cour
        /// </summary>
        [DataMember]
        public DateTime Date { get; set; }

        /// <summary>
        /// Date où a fini le cour.
        /// </summary>
        [DataMember]
        public DateTime DateFin { get; set; }

        /// <summary>
        /// Durée du Cour
        /// </summary>
        [DataMember]
        public TimeSpan Durée { get; set; }

        /// <summary>
        /// Code de la salle du cour
        /// </summary>
        [DataMember]
        public string Salle { get; set; }

        /// <summary>
        /// Matière concernant le cour
        /// </summary>
        private string matière { get; set; }
        [DataMember]
        public string Matière { get => matière; set => matière = value; }

        /// <summary>
        /// Enseignant charger de s'occuper du cour
        /// </summary>
        [DataMember]
        public Professeur Enseignant { get; set; }

        /// <summary>
        /// Groupes à qui sont dédier le cour
        /// </summary>
        private List<Groupe> groupes;
        [DataMember]
        public List<Groupe> Groupes { get => groupes; set => groupes = value; }

        /// <summary>
        /// Constructeur de la Classe Cour
        /// </summary>
        /// <param name="date">Date où a lieu le cour</param>
        /// <param name="duree">Durée du Cour</param>
        /// <param name="salle">Code de la salle du cour</param>
        /// <param name="mat">Matière concernant le cour</param>
        /// <param name="ens">Enseignant charger du bon déroulement du cour</param>
        /// <param name="grps">Liste des groupes qui vont suivre le cour</param>
        public Cour(DateTime date, TimeSpan duree, string salle, string mat, Professeur ens, List<Groupe> grps)
        {
            Date = date;
            Durée = duree;
            Salle = salle;
            Matière = mat;
            Enseignant = ens;
            Groupes = new List<Groupe>();
            Groupes.AddRange(grps);
            DateFin = Date + Durée;
        }

        public override string ToString() => $"Cour du {Date.Day}/{Date.Month}/{Date.Year} à {Date.Hour}h{Date.Minute} jusqu'à {Date.Hour + Durée.Hours}h{Date.Minute + Durée.Minutes}  avec : {Enseignant.Nom}";

    }
}
