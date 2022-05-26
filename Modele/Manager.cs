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
            List<Groupe> grps = new List<Groupe>();
            Groupe grp1 = new Groupe(3, etu);
            Groupe grp2 = new Groupe(4, etu2);
            grps.Add(grp1);
            grps.Add(grp2);

            LaPromo = new Promo(grps);

            Professeur prof = new Professeur("Delo", "Professeur", new DateTime(1989, 10, 2), "0000");
            Professeur prof2 = new Professeur("Mali", "Professeuse", new DateTime(1980, 8, 2), "0000");
            Professeur prof3 = new Professeur("Joha", "Professeuse", new DateTime(1992, 11, 12), "0000");
            List<Professeur> profs = new List<Professeur>();
            profs.Add(prof);
            profs.Add(prof2);
            profs.Add(prof3);

            List<Cour> cour = new List<Cour>()
            {
                new Cour(new DateTime(2022, 06, 12, 14, 30, 0), new TimeSpan(2, 0, 0), "A18", "Structure de données", prof, grps),
                new Cour(new DateTime(2022, 06, 8, 9, 30, 0), new TimeSpan(1, 30, 0), "A18", "Structure de données", prof, grps),
                new Cour(new DateTime(2022, 06, 15, 8, 30, 0), new TimeSpan(2, 0, 0), "A18", "Structure de données", prof, new List<Groupe>(){ grp1}),
                new Cour(new DateTime(2022, 06, 13, 13, 30, 0), new TimeSpan(1, 0, 0), "A18", "Structure de données", prof, new List<Groupe>(){ grp2}),
                new Cour(new DateTime(2022, 06, 13, 16, 30, 0), new TimeSpan(2, 0, 0), "A18", "Structure de données", prof, grps),
                new Cour(new DateTime(2022, 05, 16, 10, 0, 0), new TimeSpan(2, 0, 0), "A18", "Structure de données", prof, grps),

                new Cour(new DateTime(2022, 05, 12, 16, 30, 0), new TimeSpan(1, 0, 0), "B20", "Bases de données", prof2, grps),
                new Cour(new DateTime(2022, 06, 10, 8, 0, 0), new TimeSpan(2, 0, 0), "B20", "Bases de données", prof2, new List<Groupe>(){grp1}),
                new Cour(new DateTime(2022, 06, 11, 10, 30, 0), new TimeSpan(1, 30, 0), "B20", "Bases de données", prof2, grps),

                new Cour(new DateTime(2022, 05, 13, 14, 30, 0), new TimeSpan(2, 0, 0), "C21", "Architecture : IHM", prof3, grps),
                new Cour(new DateTime(2022, 06, 12, 8, 30, 0), new TimeSpan(1, 0, 0), "C21", "Architecture : IHM", prof3, grps),
                new Cour(new DateTime(2022, 06, 16, 14, 30, 0), new TimeSpan(2, 0, 0), "C21", "Architecture : IHM", prof3, grps),
            };

            AjouterDesCours(cour);

            Personnes.AddRange(etu);
            Personnes.AddRange(etu2);
            Personnes.AddRange(profs);
        }


    }
}
