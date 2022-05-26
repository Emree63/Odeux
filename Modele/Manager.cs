using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Modele
{
    public partial class Manager
    {

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
        public Manager()
        {
            Personnes = new List<Personne>();
            LesCours = new List<Cour>();
            LaPromo = new Promo(new List<Groupe>());
        }

        public void NouvelPromo(Promo promo)
        {
            LaPromo = promo;
        }

        public void CreerCour(DateTime date, TimeSpan Duree, string salle, string mat, Professeur ens, List<Groupe> groupes) => LesCours.Add(new Cour(date, Duree, salle, mat, ens, groupes));

        public void ChargeDonnées()
        {
            ChargePromo();
            ChargeCourPersonne();
        }

        private void ChargePromo()
        {
            List<Etudiant> etu = new List<Etudiant>()
            {
                new Etudiant("Kartal", "Emre", new DateTime(2003, 1, 1), "0000", new Semestre(1, new List<UE>()), new Semestre(2, new List<UE>())),
                new Etudiant("Thibon", "Hugo", new DateTime(2003, 1, 1), "0000", new Semestre(1, new List<UE>()), new Semestre(2, new List<UE>())),
            };

            List<Etudiant> etu2 = new List<Etudiant>()
            {
                 new Etudiant("Etudiant", "1", new DateTime(2003, 1, 1), "0000", new Semestre(1, new List<UE>()), new Semestre(2, new List<UE>())),
                    new Etudiant("Etudiant", "2", new DateTime(2003, 1, 1), "0000", new Semestre(1, new List<UE>()), new Semestre(2, new List<UE>())),
            };
            List<Groupe> grps = new List<Groupe>()
            {
                new Groupe(3,etu),
                new Groupe(4,etu2),
            };

        }

        private void ChargeCourPersonne()
        {
            Professeur prof = new Professeur("Delo", "Professeur", new DateTime(1989, 10, 2), "0000");
            Professeur prof2 = new Professeur("Mali", "Professeuse", new DateTime(1980, 8, 2), "0000");
            Professeur prof3 = new Professeur("Joha", "Professeuse", new DateTime(1992, 11, 12), "0000");
        }



    }
}
