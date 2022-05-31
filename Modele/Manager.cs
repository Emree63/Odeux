using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Modele
{
    public partial class Manager : INotifyPropertyChanged
    {
        /// <summary>
        /// Dépendance vers le gestionnaire de la persistance
        /// </summary>
        public IPersistanceManager Persistance { get; private set; }

        /// <summary>
        /// Constructeur de la classe Manager.
        /// </summary>
        public Manager()///IPersistanceManager persistance
        {
            ///Persistance = persistance;
            Personnes = new List<Personne>();
            LesCours = new List<Cour>();
            LaPromo = new Promo(new List<Groupe>());
        }

        /// <summary>
        /// Récuperer une nouvelPromo
        /// </summary>
        /// <param name="promo"></param>
        public void NouvelPromo(Promo promo)
        {
            LaPromo = promo;
        }

        public void CreerCour(DateTime date, TimeSpan Duree, string salle, string mat, Professeur ens, List<Groupe> groupes) => LesCours.Add(new Cour(date, Duree, salle, mat, ens, groupes));

        public void ChargeDonnées()
        {
            List<Ressource> ressources1 = new List<Ressource>()
            {
                new Ressource("R1.01", "Initiation au développement", 42, new List<Matiere>()),
                new Ressource("R1.02", "Développement d’interfaces web", 42, new List<Matiere>()),
                new Ressource("R1.10", "Anglais S1", 42, new List<Matiere>()),
            };
            List<Ressource> ressources2 = new List<Ressource>()
            {
                new Ressource("R1.01", "Initiation au développement", 24, new List<Matiere>()),
                new Ressource("R1.03", "Introduction à l'architecture des ordinateurs", 3, new List<Matiere>()),
                new Ressource("R1.04", "Introduction aux systèmes d'exploitation et à leur fonctionnement", 10, new List<Matiere>()),
                new Ressource("R1.06", "Mathématiques discrètes", 15, new List<Matiere>()),
                new Ressource("R1.07", "Outils mathématiques fondamentaux", 15, new List<Matiere>()),
            };
            List<Ressource> ressources3 = new List<Ressource>()
            {
                new Ressource("R1.03", "Introduction à l'architecture des ordinateurs", 21, new List<Matiere>()),
                new Ressource("R1.10", "Anglais S1", 12, new List<Matiere>()),
                new Ressource("R1.11", "Expression-Communication", 6, new List<Matiere>()),
            };
            List<Ressource> ressources4 = new List<Ressource>()
            {
                new Ressource("R1.05", " Introduction aux bases de données et SQL", 36, new List<Matiere>()),
                new Ressource("R1.06", "Mathématiques discrètes", 12, new List<Matiere>()),
                new Ressource("R1.09", "Économie durable et numérique", 6, new List<Matiere>()),
            };
            List<Ressource> ressources5 = new List<Ressource>()
            {
                new Ressource("R1.02", "Développement d’interfaces web", 18, new List<Matiere>()),
                new Ressource("R1.08", "Gestion de projet et des organisations", 27, new List<Matiere>()),
                new Ressource("R1.11", "Expression-Communication", 15, new List<Matiere>()),
            };
            List<Ressource> ressources6 = new List<Ressource>()
            {

                new Ressource("R1.02", "Développement d’interfaces web", 5, new List<Matiere>()),
                new Ressource("R1.08", "Gestion de projet et des organisations", 11, new List<Matiere>()),
                new Ressource("R1.09", "Économie durable et numérique", 11, new List<Matiere>()),
                new Ressource("R1.10", "Anglais S1", 11, new List<Matiere>()),
                new Ressource("R1.11", "Expression-Communication", 11, new List<Matiere>()),
                new Ressource("R1.12", "Projet professionnel et personne", 11, new List<Matiere>()),
            };

            List<UE> LesUE = new List<UE>()
            {
                    new UE("UE 1","Développer des applications informatiques simples"),
                    new UE("UE 2","Appréhender et construire des algorithmes"),
                    new UE("UE 3","Installer et configurer un poste de travail"),
                    new UE("UE 4","Concevoir et mettre en place une base de données "),
                    new UE("UE 5","Identifier les besoins métiers des clients et des utilisateurs"),
                    new UE("UE 6","Identifier ses aptitudes pour travailler dans une équipe"),
            };
            LesUE[0].AddListesRessources(ressources1);
            LesUE[1].AddListesRessources(ressources2);
            LesUE[2].AddListesRessources(ressources3);
            LesUE[3].AddListesRessources(ressources4);
            LesUE[4].AddListesRessources(ressources5);
            LesUE[5].AddListesRessources(ressources6);


            List<Etudiant> etu = new List<Etudiant>()
            {
                new Etudiant("Kartal", "Emre", new DateTime(2003, 1, 1), "0000", new Semestre(1, LesUE), new Semestre(2, LesUE)),
                new Etudiant("Thibon", "Hugo", new DateTime(2003, 1, 1), "0000", new Semestre(1, LesUE), new Semestre(2, LesUE)),
            };

            List<Etudiant> etu2 = new List<Etudiant>()
            {
                 new Etudiant("Etudiant", "1", new DateTime(2003, 1, 1), "0000", new Semestre(1, LesUE), new Semestre(2, LesUE)),
                 new Etudiant("Etudiant", "2", new DateTime(2003, 1, 1), "0000", new Semestre(1, LesUE), new Semestre(2, LesUE)),
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
                new Cour(new DateTime(2022, 06, 8, 9, 30, 0), new TimeSpan(1, 30, 0), "A18", "Structure de données", prof, grps),
                new Cour(new DateTime(2022, 06, 12, 14, 30, 0), new TimeSpan(2, 0, 0), "A18", "Structure de données", prof, grps),
                new Cour(new DateTime(2022, 06, 13, 13, 30, 0), new TimeSpan(1, 0, 0), "A18", "Structure de données", prof, new List<Groupe>(){ grp2}),
                new Cour(new DateTime(2022, 06, 13, 16, 30, 0), new TimeSpan(2, 0, 0), "A18", "Structure de données", prof, grps),
                new Cour(new DateTime(2022, 06, 15, 8, 30, 0), new TimeSpan(2, 0, 0), "A18", "Structure de données", prof, new List<Groupe>(){ grp1}),
                new Cour(new DateTime(2022, 05, 16, 10, 0, 0), new TimeSpan(2, 0, 0), "A18", "Structure de données", prof, grps),

                new Cour(new DateTime(2022, 05, 12, 16, 30, 0), new TimeSpan(1, 0, 0), "B20", "Bases de données", prof2, grps),
                new Cour(new DateTime(2022, 05, 29, 16, 30, 0), new TimeSpan(1, 0, 0), "B20", "Bases de données", prof2, grps),
                new Cour(new DateTime(2022, 06, 01, 8, 0, 0), new TimeSpan(2, 0, 0), "B20", "Bases de données", prof2, new List<Groupe>(){grp1}),
                new Cour(new DateTime(2022, 06, 01, 10, 0, 0), new TimeSpan(2, 0, 0), "B20", "Bases de données", prof2, new List<Groupe>(){grp1}),
                new Cour(new DateTime(2022, 06, 01, 13, 15, 0), new TimeSpan(2, 0, 0), "A18", "Structure de données", prof, grps),
                new Cour(new DateTime(2022, 05, 31, 10, 30, 0), new TimeSpan(1, 30, 0), "B20", "Bases de données", prof2, grps),
                new Cour(new DateTime(2022, 05, 31, 13, 30, 0), new TimeSpan(1, 0, 0), "B20", "Bases de données", prof2, grps),
                new Cour(new DateTime(2022, 05, 31, 15, 30, 0), new TimeSpan(1, 30, 0), "B20", "Bases de données", prof2, grps),
                new Cour(new DateTime(2022, 06, 10, 8, 0, 0), new TimeSpan(2, 0, 0), "B20", "Bases de données", prof2, new List<Groupe>(){grp1}),
                new Cour(new DateTime(2022, 06, 11, 10, 30, 0), new TimeSpan(1, 30, 0), "B20", "Bases de données", prof2, grps),

                new Cour(new DateTime(2022, 05, 13, 14, 30, 0), new TimeSpan(2, 0, 0), "C21", "Architecture : IHM", prof3, grps),
                new Cour(new DateTime(2022, 06, 01, 16, 30, 0), new TimeSpan(1, 0, 0), "Dis", "Architecture : IHM", prof3, grps),
                new Cour(new DateTime(2022, 05, 31, 18, 30, 0), new TimeSpan(1, 0, 0), "B10", "Architecture : IHM", prof3, new List<Groupe>(){grp1}),
                new Cour(new DateTime(2022, 06, 12, 8, 30, 0), new TimeSpan(1, 0, 0), "C21", "Architecture : IHM", prof3, grps),
                new Cour(new DateTime(2022, 06, 16, 14, 30, 0), new TimeSpan(2, 0, 0), "C21", "Architecture : IHM", prof3, grps),
            };

            AjouterDesCours(cour);

            Personnes.AddRange(etu);
            Personnes.AddRange(etu2);
            Personnes.AddRange(profs);

            GroupeSélectionné = LaPromo.groupes[0];
            MoyGeneral = LaPromo.MoyGeneral();
        }


    }
}
