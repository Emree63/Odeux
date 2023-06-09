﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public partial class Manager : INotifyPropertyChanged
    {
        /// <summary>
        /// Dépendance vers le gestionnaire de la persistance
        /// </summary>
        public IPersistanceManager Persistance { get; /*private*/ set; }

        /// <summary>
        /// Constructeur de la classe Manager
        /// </summary>
        public Manager(IPersistanceManager persistance)
        {
            Persistance = persistance;
            Personnes = new ();
            LesCours = new ();
            LaPromo = new (new List<Groupe>());
        }

        /// <summary>
        /// Récupère une nouvelle Promo
        /// </summary>
        /// <param name="promo"></param>
        public void NouvelPromo(Promo promo)
        {
            LaPromo = promo;
        }

        /// <summary>
        /// Crée un nouveau cours et l'ajoute à la liste des cours
        /// </summary>
        /// <param name="date">Date du cour</param>
        /// <param name="Duree">Durée du cour</param>
        /// <param name="Salle">Salle où a lieu </param>
        /// <param name="mat">Matière qui a lieu</param>
        /// <param name="ens">Enseignant charger de s'occuper du cour</param>
        /// <param name="groupes">Les groupes d'élèves à qui sont assigner les cours</param>
        public void CreerCour(DateTime date, TimeSpan Duree, string Salle, string mat, Professeur ens, List<Groupe> groupes) => LesCours.Add(new Cour(date, Duree, Salle, mat, ens, groupes));

        /// <summary>
        /// Charge les données dans le manager à partir de la persistance
        /// </summary>
        public void ChargeDonnées()
        {
            List<Personne> per = new List<Personne>();
            var données = Persistance.ChargeDonnées();
            foreach (var j in données.cours)
            {
                LesCours.Add(j);
            }
            foreach (var p in données.personnes)
            {
                per.Add(p);
            }
            AjouterPersonne(per);
            LaPromo = données.Iut;
            GroupeSélectionné = LaPromo.Groupes[0];
            MoyGeneral = LaPromo.MoyGeneral();
        }

        /// <summary>
        /// Sauvegarde les données du manager
        /// </summary>
        public void SauvegardeDonnées()
        {
            Persistance.SauvegardeDonnées(LesCours, Personnes, LaPromo);
        }

    }
}
