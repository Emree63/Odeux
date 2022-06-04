using System;
using System.Collections.Generic;
using System.Diagnostics;
using Modele;

namespace Stub
{
    public class Stub : IPersistanceManager
    {
        public (IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut) ChargeDonnées()
        {

            List<Note> notes = new List<Note>()
            {
                new Note("ds 1 (sur 20.0)",11),
                new Note("ds 2 (sur 20.0)",5),
            };

            List<Matiere> matieres = new List<Matiere>()
            {
                new Matiere("Algorithmique ",notes),
                new Matiere("Structure de données ", new List<Note>()),
            };
            List<Matiere> mat = new List<Matiere>() { new Matiere(new List<Note>()), };
            List<Ressource> ressources1 = new List<Ressource>()
            {
                new Ressource("R1.01", "Initiation au développement", 42, matieres),
                new Ressource("R1.02", "Développement d’interfaces web", 12, mat),
                new Ressource("R1.10", "Anglais S1", 6, mat),
            };
            List<Ressource> ressources2 = new List<Ressource>()
            {
                new Ressource("R1.01", "Initiation au développement", 24, matieres),
                new Ressource("R1.03", "Introduction à l'architecture des ordinateurs", 3, mat),
                new Ressource("R1.04", "Introduction aux systèmes d'exploitation et à leur fonctionnement", 10, mat),
                new Ressource("R1.06", "Mathématiques discrètes", 15, mat),
                new Ressource("R1.07", "Outils mathématiques fondamentaux", 15, mat),
            };
            List<Ressource> ressources3 = new List<Ressource>()
            {
                new Ressource("R1.03", "Introduction à l'architecture des ordinateurs", 21, mat),
                new Ressource("R1.10", "Anglais S1", 12, mat),
                new Ressource("R1.11", "Expression-Communication", 6, mat),
            };
            List<Ressource> ressources4 = new List<Ressource>()
            {
                new Ressource("R1.05", " Introduction aux bases de données et SQL", 36, mat),
                new Ressource("R1.06", "Mathématiques discrètes", 12, mat),
                new Ressource("R1.09", "Économie durable et numérique", 6, mat),
            };
            List<Ressource> ressources5 = new List<Ressource>()
            {
                new Ressource("R1.02", "Développement d’interfaces web", 18, mat),
                new Ressource("R1.08", "Gestion de projet et des organisations", 27, mat),
                new Ressource("R1.11", "Expression-Communication", 15, mat),
            };
            List<Ressource> ressources6 = new List<Ressource>()
            {

                new Ressource("R1.02", "Développement d’interfaces web", 5, mat),
                new Ressource("R1.08", "Gestion de projet et des organisations", 11, mat),
                new Ressource("R1.09", "Économie durable et numérique", 11, mat),
                new Ressource("R1.10", "Anglais S1", 11, mat),
                new Ressource("R1.11", "Expression-Communication", 11, mat),
                new Ressource("R1.12", "Projet professionnel et personne", 11, mat),
            };


            ///Premier semestre
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


            List<Matiere> matiere2 = new List<Matiere>()
            {
                new Matiere("Gestion de projet informatique",new List<Note>()),
                new Matiere("Système d'information financier",new List<Note>()),
            };
            List<Ressource> ressources2_1 = new List<Ressource>()
            {
                new Ressource("P2.01", "Portfolio", 2, mat),
                new Ressource("R2.01", "Développement orienté objets", 21, mat),
                new Ressource("R2.02", "Développement d'applications avec IHM", 21, mat),
                new Ressource("R2.03", "Qualité de développement", 12, mat),
                new Ressource("R2.13", "Expression-Communication", 6, mat),
            };
            List<Ressource> ressources2_2 = new List<Ressource>()
            {
                new Ressource("P2.01", "Portfolio", 2, mat),
                new Ressource("R2.01", "Développement orienté objets", 15, mat),
                new Ressource("R2.04", "Communication et fonctionnement bas niveau", 12, mat),
                new Ressource("R2.07", "Graphes", 21, mat),
                new Ressource("R2.09", "Méthodes numériques", 12, mat),
            };
            List<Ressource> ressources2_3 = new List<Ressource>()
            {
                new Ressource("P2.01", " Portfolio", 2, mat),
                new Ressource("R2.04", "Communication et fonctionnement bas niveau", 36, mat),
                new Ressource("R2.05", "Introduction aux services réseaux", 15, mat),
                new Ressource("R2.12", "Anglais S2", 6, mat),
                new Ressource("R2.13", "Expression-Communication", 9, mat),
            };

            List<Ressource> ressources2_4 = new List<Ressource>()
            {
                new Ressource("P2.01", "Portfolio", 2, mat),
                new Ressource("R2.06", "Exploitation d'une base de données", 30, mat),
                new Ressource("R2.08", "Outils numériques pour les statistiques descriptives", 12, mat),
                new Ressource("R2.10", "Gestion de projet et des organisations", 12, matiere2),
                new Ressource("R2.12", "Anglais S2", 6, mat),
            };
            List<Ressource> ressources2_5 = new List<Ressource>()
            {
                new Ressource("P2.01", "Portfolio", 2, mat),
                new Ressource("R2.02", "Développement d'applications avec IHM", 3, mat),
                new Ressource("R2.03", "Qualité de développement", 6, mat),
                new Ressource("R2.07", "Graphes", 6, mat),
                new Ressource("R2.10", "Gestion de projet et des organisations", 30, matiere2),
                new Ressource("R2.12", "Anglais S2", 9, mat),
                new Ressource("R2.13", "Expression-Communication", 9, mat),
            };
            List<Ressource> ressources2_6 = new List<Ressource>()
            {
                new Ressource("P2.01", " Portfolio", 2, mat),
                new Ressource("R2.02", "Développement d'applications avec IHM", 4, mat),
                new Ressource("R2.11", "Droit des contrats et du numérique", 17, mat),
                new Ressource("R2.12", "Anglais S2", 17, mat),
                new Ressource("R2.13", "Expression-Communication", 11, mat),
                new Ressource("R2.14", "Projet professionnel et personnel", 11, mat),
            };

            ///Deuxième Semestre
            List<UE> LesUE2 = new List<UE>()
            {
                    new UE("UE 1","Développer des applications informatiques simples"),
                    new UE("UE 2","Appréhender et construire des algorithmes"),
                    new UE("UE 3","Installer et configurer un poste de travail"),
                    new UE("UE 4","Concevoir et mettre en place une base de données "),
                    new UE("UE 5","Identifier les besoins métiers des clients et des utilisateurs"),
                    new UE("UE 6","Identifier ses aptitudes pour travailler dans une équipe"),
            };

            LesUE2[0].AddListesRessources(ressources2_1);
            LesUE2[1].AddListesRessources(ressources2_2);
            LesUE2[2].AddListesRessources(ressources2_3);
            LesUE2[3].AddListesRessources(ressources2_4);
            LesUE2[4].AddListesRessources(ressources2_5);
            LesUE2[5].AddListesRessources(ressources2_6);

            List<Etudiant> etu = new List<Etudiant>()
            {
                new Etudiant("Kartal", "Emre", new DateTime(2003, 1, 1), "0000", new Semestre(1, LesUE), new Semestre(2, LesUE2)),
                new Etudiant("Thibon", "Hugo", new DateTime(2003, 1, 1), "0000", new Semestre(1, LesUE), new Semestre(2, LesUE2)),
            };

            List<Etudiant> etu2 = new List<Etudiant>()
            {
                 new Etudiant("Etudiant", "1", new DateTime(2003, 1, 1), "0000", new Semestre(1, LesUE), new Semestre(2, LesUE2)),
                 new Etudiant("Etudiant", "2", new DateTime(2003, 1, 1), "0000", new Semestre(1, LesUE), new Semestre(2, LesUE2)),
            };
            List<Groupe> grps = new List<Groupe>();
            Groupe grp1 = new Groupe(3, etu);
            Groupe grp2 = new Groupe(4, etu2);
            grps.Add(grp1);
            grps.Add(grp2);

            Promo LaPromo = new Promo(grps);

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
                new Cour(new DateTime(2022, 06, 12, 8, 30, 0), new TimeSpan(1, 0, 0), "B20", "Bases de données", prof2, grps),
                new Cour(new DateTime(2022, 06, 14, 8, 30, 0), new TimeSpan(1, 30, 0), "B20", "Bases de données", prof2, grps),
                new Cour(new DateTime(2022, 06, 14, 10, 0, 0), new TimeSpan(2, 0, 0), "B20", "Bases de données", prof2, new List<Groupe>(){grp1}),
                new Cour(new DateTime(2022, 06, 15, 10, 30, 0), new TimeSpan(1, 30, 0), "B20", "Bases de données", prof2, grps),

                new Cour(new DateTime(2022, 05, 13, 14, 30, 0), new TimeSpan(2, 0, 0), "C21", "Architecture : IHM", prof3, grps),
                new Cour(new DateTime(2022, 06, 01, 16, 30, 0), new TimeSpan(1, 0, 0), "Dis", "Architecture : IHM", prof3, grps),
                new Cour(new DateTime(2022, 05, 31, 18, 30, 0), new TimeSpan(1, 0, 0), "B10", "Architecture : IHM", prof3, new List<Groupe>(){grp1}),
                new Cour(new DateTime(2022, 06, 12, 10, 00, 0), new TimeSpan(2, 0, 0), "C21", "Architecture : IHM", prof3, grps),
                new Cour(new DateTime(2022, 06, 13, 8, 30, 0), new TimeSpan(1, 0, 0), "C21", "Architecture : IHM", prof3, grps),
                new Cour(new DateTime(2022, 06, 15, 13, 30, 0), new TimeSpan(1, 0, 0), "C21", "Architecture : IHM", prof3, grps),
            };

            List<Personne> Personnes = new List<Personne>();
            Personnes.AddRange(etu);
            Personnes.AddRange(etu2);
            Personnes.AddRange(profs);


            return (cour, Personnes, LaPromo);
        }

        public void SauvegardeDonnées(IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut)
        {
            Debug.WriteLine("Sauvegarde demandée");
        }


    }
}
