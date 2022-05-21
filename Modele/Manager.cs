﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Modele
{
    class Manager
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
        public Manager(List<Cour> cours, Promo promo, params Personne[] desPersonnes)
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
        public IEnumerable<Cour> RechCourEtu(DateTime date) => LesCours.Where(d => d.Date == date)
                                                                       .OrderBy(d => d.Date);

        
        /// <summary>
        /// Recherche la liste des cours du professeur de la date concerner.
        /// </summary>
        /// <param name="date">date concerner</param>
        /// <returns>IEnumerable : Liste des cours</returns>
        public IEnumerable<Cour> RechCourProf(DateTime date) => from d in LesCours
                                                                where d.Date == date
                                                                orderby d.Date
                                                                select d;


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
