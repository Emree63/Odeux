using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Modele
{
    public class Manager
    {
        Personne personneActuel { get; set; }

        /// <summary>
        /// Collection de personne
        /// </summary>
        public ReadOnlyCollection<Personne> personnes => Personnes.AsReadOnly();
        List<Personne> Personnes = new List<Personne>();

        /// <summary>
        /// Liste des cours dans l'administration
        /// </summary>
        private List<Cour> LesCours; 
        public List<Cour> lescours { get => LesCours; set => LesCours = value; }


        /// <summary>
        /// La classe concernant l'application
        /// </summary>
        public Promo LaPromo { get; private set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="desPersonnes">Liste des personnes</param>
        /// <param name="cours">Listes des cours</param>
        /// <param name="promo">Promo concerner</param>
        public Manager(List<Cour> cours, Promo promo, List<Personne> desPersonnes)
        {
            Personnes.AddRange(desPersonnes);
            LesCours = cours;
            LaPromo = promo;
        }

        public void CreerCour(DateTime date, TimeSpan Duree, string salle, string mat, Professeur ens, List<Groupe> groupes) => LesCours.Add(new Cour(date, Duree, salle, mat, ens, groupes));

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
            foreach (Cour c in e )
            {
                foreach(Groupe g in c.groupes2)
                {
                    foreach(Etudiant etu in g.etudiants)
                    {
                        if(etu.nom == personneActuel.nom && etu.prénom == personneActuel.prénom)
                        {
                            cour.Add(c);
                        }
                    }
                }
            }

            return cour;

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
        /// Regarde si le mot de passe et le nom existe pour la connexion dans l'application
        /// </summary>
        /// <param name="Nom">Nom qu'on va rechercher</param>
        /// <param name="PassWord">Mot de passe qui correspond à l'utilisateur</param>
        /// <returns>Renvoie le code correspondant au solution: 
        ///  1- On trouve un professeur
        ///  2- On trouve un Etudiant
        ///  0- Rien trouver</returns>
        public int Connection(string Nom, string PassWord)
        {
            var Per = personnes.FirstOrDefault(d => d.nom == Nom && d.password == PassWord);
            if(Per != null)
            {
                personneActuel = Per;
                if (personneActuel is Professeur)
                    return 1;
                if (personneActuel is Etudiant)
                    return 2;
            }
            return 0;
        }


    }
}
