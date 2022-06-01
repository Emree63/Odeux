using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public partial class Manager
    {

        /// <summary>
        /// Liste des cours dans l'administration
        /// </summary>
        private List<Cour> LesCours;
        public List<Cour> lescours { get => LesCours; set => LesCours = value; }

        /// <summary>
        /// Ajouter des cours
        /// </summary>
        /// <param name="cours">Liste de cours</param>
        public void AjouterDesCours(List<Cour> cours)
        {
            LesCours.AddRange(cours);
        }

        /// <summary>
        /// Recherche la liste des cours du professeur de la date concerner.
        /// </summary>
        /// <param name="date">date concerner</param>
        /// <returns>IEnumerable : Liste des cours</returns>
        public IEnumerable<Cour> RechCourProf(DateTime date) => from d in LesCours
                                                                where d.Enseignant.nom == personneActuel.nom && d.Enseignant.prénom == personneActuel.prénom
                                                                && d.Date.Day == date.Day && d.Date.Month == date.Month && d.Date.Year == date.Year
                                                                orderby d.Date
                                                                select d;


        /// <summary>
        /// Rechercher la liste des cours de l'étudiant sur la date concerner.
        /// </summary>
        /// <param name="date">date concerner</param>
        /// <returns>IEnumerable : Liste des cours</returns>
        public IEnumerable<Cour> RechCourEtu(DateTime date)
        {
            var e = LesCours.Where(d => d.Date.Day == date.Day && d.Date.Month == date.Month && d.Date.Year == date.Year)
                                                                         .OrderBy(d => d.Date);
            List<Cour> cour = new List<Cour>();
            foreach (Cour c in e)
            {
                foreach (Groupe g in c.Groupes)
                {
                    foreach (Etudiant etu in g.etudiants)
                    {
                        if (etu.nom == personneActuel.nom && etu.prénom == personneActuel.prénom)
                        {
                            cour.Add(c);
                        }
                    }
                }
            }
            return cour;
        }

        /// <summary>
        /// Liste des cours d'un étudiant qui sont déjà passer, elle va permetre à l'étudiant de savoir les cours où il n'a pas déclarer sa présence
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Cour> CoursDejaPasser()
        {
            var e = LesCours.Where(d => d.Date < DateTime.Now)
                            .OrderBy(d => d.Date); ;
            List<Cour> cour = new List<Cour>();
            foreach (Cour c in e)
            {
                foreach (Groupe g in c.Groupes)
                {
                    foreach (Etudiant etu in g.etudiants)
                    {
                        if (etu.nom == personneActuel.nom && etu.prénom == personneActuel.prénom)
                        {
                            cour.Add(c);
                        }
                    }
                }
            }
            return cour;
        }

        /// <summary>
        /// Supprimer l'étudiant d'un cour, elle va permetre d'enlever les cours où l'élève va déclarer sa présence.
        /// </summary>
        public void SupprimerEtuCour()
        {

        }

    }
}
