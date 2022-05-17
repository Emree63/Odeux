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
        /// Date lieu du cour
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Durée du Cour
        /// </summary>
        public TimeSpan Durée { get; set; }
        
        /// <summary>
        /// Code de la salle du cour
        /// </summary>
        public string Salle { get; set; }

        /// <summary>
        /// Matière concernat le cour
        /// </summary>
        private string Matière { get; set; }
        public string matière { get; set; }

        /// <summary>
        /// Enseignant charger de s'occuper du cour
        /// </summary>
        private Professeur Enseignant;
        private Professeur enseignant { get => Enseignant; set => Enseignant = value; }



        public Cour(DateTime date, TimeSpan duree, string salle, string mat)
        {
            Date = date;
            Durée = duree;
            Salle = salle;
            matière = mat;
        }

    }
}
