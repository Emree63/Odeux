﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    //Il va permettre de gérer l'authentification dans l'application et l'emploi du temps de chacun
    public partial class Manager
    {
        /// <summary>
        /// Personne (Prof ou étudiant) actuellement sur l'application.
        /// </summary>
        public Personne personneActuel { get; set; }

        /// <summary>
        /// Collection de personne
        /// </summary>
        public ReadOnlyCollection<Personne> personnes => Personnes.AsReadOnly();
        List<Personne> Personnes = new List<Personne>();


        /// <summary>
        /// Ajoute des personnes à la liste
        /// </summary>
        /// <param name="pers">Liste de Personne à ajouter</param>
        public void AjouterPersonne(List<Personne> pers)
        {
            Personnes.AddRange(pers);
        }

        /// <summary>
        /// Regarde si le mot de passe et le nom existent pour la connexion dans l'application
        /// </summary>
        /// <param name="Nom">Nom qu'on va rechercher</param>
        /// <param name="PassWord">Mot de passe qui correspond à l'utilisateur</param>
        /// <returns>Renvoie le code correspondant au solution: 
        ///  1- On trouve un professeur
        ///  2- On trouve un Etudiant
        ///  0- Rien trouvé</returns>
        public int Connection(string Nom, string PassWord)
        {
            var Per = personnes.FirstOrDefault(d => d.Nom == Nom && d.Password == PassWord);
            if (Per != null)
            {
                personneActuel = Per;
                if (personneActuel is Professeur)
                {
                    profActuel = (Professeur)Per;
                    return 1;
                }
                if (personneActuel is Etudiant)
                {
                    EtuActuel = (Etudiant)Per;
                    return 2;
                }
            }
            return 0;
        }

        /// <summary>
        /// Modifie une personne de la Liste
        /// </summary>
        /// <param name="OldPer">Ancienne Personne</param>
        /// <param name="NewPer">Nouvelle Personne</param>
        /// <returns>Booléen</returns>
        public bool ModifierPersonne(Personne OldPer, Personne NewPer)
        {
            if (!OldPer.Equals(NewPer))
            {
                return false;
            }
            Personnes.Remove(OldPer);
            Personnes.Add(NewPer);
            return true;
        }

        public void Sauvegarde()
        {
            List<Personne> p = new List<Personne>();
            foreach(Personne pers in Personnes)
            {
                if(pers is Professeur)
                {
                    p.Add(pers);
                }
            }
            foreach(Groupe g in LaPromo.Groupes)
            {
                foreach(Etudiant e in g.etudiants)
                {
                    p.Add(e);
                }
            }
            Personnes = p;
        }
    }
}
