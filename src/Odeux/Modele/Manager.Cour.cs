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
        /// Recherche la liste des cours du professeur de la date concerné
        /// </summary>
        /// <param name="date">date concerné</param>
        /// <returns>IEnumerable : Liste des cours</returns>
        public IEnumerable<Cour> RechCourProf(DateTime date) => from d in LesCours
                                                                where d.Enseignant.Nom == personneActuel.Nom && d.Enseignant.Prénom == personneActuel.Prénom
                                                                && d.Date.Day == date.Day && d.Date.Month == date.Month && d.Date.Year == date.Year
                                                                orderby d.Date
                                                                select d;


        /// <summary>
        /// Rechercher la liste des cours de l'étudiant sur la date concerné
        /// </summary>
        /// <param name="date">date concerné</param>
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
                        if (etu.Nom == personneActuel.Nom && etu.Prénom == personneActuel.Prénom)
                        {
                            cour.Add(c);
                        }
                    }
                }
            }
            return cour;
        }

        /// <summary>
        /// Liste des cours d'un étudiant qui sont déjà passé, elle va permettre à l'étudiant de savoir les cours où il n'a pas déclarer sa présence
        /// </summary>
        /// <returns>IEnumerable: Liste des cours</returns>
        public IEnumerable<Cour> CoursDejaPasser()
        {
            var e = LesCours.Where(d => d.Date < DateTime.Now)
                            .OrderBy(d => d.Date);
            List<Cour> cour = new List<Cour>();
            foreach (Cour c in e)
            {
                foreach (Groupe g in c.Groupes)
                {
                    foreach (Etudiant etu in g.etudiants)
                    {
                        if (etu.Nom == personneActuel.Nom && etu.Prénom == personneActuel.Prénom)
                        {
                            cour.Add(c);
                        }
                    }
                }
            }
            return cour;
        }

        /// <summary>
        /// Supprime l'étudiant d'un cour, elle va permettre d'enlever les cours où l'élève va déclarer sa présence.
        /// </summary>
        public void SupprimerEtuCour(Cour cour)
        {

            foreach(Cour c in LesCours)
            {
                if(c==cour)
                {
                    foreach(Groupe g in c.Groupes)
                    {
                        List<Etudiant> etu = new List<Etudiant>();
                        foreach (Etudiant e in g.etudiants)
                        {
                            if(e.Nom == EtuActuel.Nom)
                            {

                            }
                            else
                            {
                                etu.Add(e);
                            }
                        }
                        g.etudiants = etu;
                    }
                }
            }
        }

        /// <summary>
        /// Supprimer une liste de cour
        /// </summary>
        /// <param name="cour">Liste des cours à supprimer</param>
        public void SupprimerListeEtuCour(IEnumerable<Cour> cours)
        {
            foreach (Cour c in cours)
            {
                LesCours.Remove(c);
            }
        }

    }
}
