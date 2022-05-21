using System;
using static System.Console;
using Modele;
using System.Collections.Generic;

namespace Test_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test de la classe Promo :");

            // Creation des Liste de note
            List<Note> notes = new List<Note>();
            Note n1 = new Note("Tp noté", 10);
            notes.Add(n1);
            Note n2 = new Note("DS", 15);
            notes.Add(n2);


            List<Note> notes2 = new List<Note>();
            Note n3 = new Note("Tp noté", 13);
            notes2.Add(n3);
            Note n4 = new Note("DS", 11);
            notes2.Add(n4);

            List<Note> notes3 = new List<Note>();
            Note n10 = new Note("Tp noté", 4);
            notes3.Add(n10);
            Note n11 = new Note("DS", 19);
            notes3.Add(n11);

            List<Note> notes4 = new List<Note>();
            Note n12 = new Note("Tp noté", 1);
            notes4.Add(n12);
            Note n13 = new Note("DS", 15);
            notes4.Add(n13);

            Note n5 = new Note("Situation 1 (sur 20.0)", 16);

            Note n6 = new Note("Situation 1 (sur 20.0)", 11);

            Note n7 = new Note("Situation 1 (sur 20.0)", 2);

            Note n8 = new Note("Situation 1 (sur 20.0)", 7);

            //Creation des Matières

            List<Matiere> matieres = new List<Matiere>();
            List<Matiere> matieres2 = new List<Matiere>();
            List<Matiere> matieres3 = new List<Matiere>();
            List<Matiere> matieres4 = new List<Matiere>();

            Matiere mat1 = new Matiere("Structure de données", notes);
            Matiere mat2 = new Matiere("Algorithme", notes2);
            Matiere mat3 = new Matiere("Structure de données", notes3);
            Matiere mat4 = new Matiere("Algorithme", notes4);

            matieres.Add(mat1);
            matieres2.Add(mat2);
            matieres3.Add(mat3);
            matieres4.Add(mat4);

            //Creation des Ressource

            Ressource res = new Ressource("R1.01", "Initiation au développement", 42, matieres);
            Ressource res2 = new Ressource("R1.02", 12, matieres2);

            Ressource res3 = new Ressource("R1.01", "Initiation au développement", 42, matieres3);
            Ressource res4 = new Ressource("R1.02", 12, matieres4);

            //Creation d'une UE

            List<UE> lesUE = new List<UE>();
            List<UE> lesUE2 = new List<UE>();
            List<UE> lesUE3 = new List<UE>();
            List<UE> lesUE4 = new List<UE>();

            UE ue = new UE("UE 1", "Développer des applications informatiques simples");
            UE ue2 = new UE("UE 2", "Appréhender et construire des algorithmes");
            UE ue3 = new UE("UE 1", "Développer des applications informatiques simples");
            UE ue4 = new UE("UE 2", "Appréhender et construire des algorithmes");

            ue.AddRessource(res);
            ue2.AddRessource(res2);
            ue3.AddRessource(res3);
            ue4.AddRessource(res4);

            lesUE.Add(ue);
            lesUE2.Add(ue2);

            lesUE3.Add(ue3);
            lesUE4.Add(ue4);

            //Creation SAE

            SAE sae = new SAE("S1.01 : Implémentation d’un besoin client", n5, 40);
            ue.AddSAE(sae);

            SAE sae2 = new SAE("S1.02 : Comparaison d’approches algorithmiques", n6, 40);
            ue2.AddSAE(sae2);

            SAE sae3 = new SAE("S1.01 : Implémentation d’un besoin client", n7, 40);
            ue3.AddSAE(sae3);

            SAE sae4 = new SAE("S1.02 : Comparaison d’approches algorithmiques", n8, 40);
            ue4.AddSAE(sae4);

            //Creation de deux Semestre

            Semestre s1 = new Semestre(1, lesUE);
            Semestre s2 = new Semestre(2, lesUE2);

            Semestre s3 = new Semestre(1, lesUE3);
            Semestre s4 = new Semestre(2, lesUE4);

            //Creation d'un Etudiant

            Etudiant etu1 = new Etudiant("Khedair ", "Rami", new DateTime(2002, 10, 22), "Cinq combattants distinguent des esquives et les rêves.", s1, s2);

            Etudiant etu2 = new Etudiant("Jean", "Pierre", new DateTime(1978, 10, 12), "0000", s3, s4);

            //Creation d'un groupe de classe
            List<Etudiant> etu = new List<Etudiant>();
            etu.Add(etu1);
            etu.Add(etu2);
            List<Groupe> grps = new List<Groupe>();

            Groupe grp = new Groupe(3, etu);
            WriteLine("Pire note "+grp+ grp.MinNote(1, "UE 1", "R1.01", "Structure de données", "Tp noté"));
            WriteLine("Meilleur note du " + grp + grp.MaxNote(1, "UE 1", "R1.01", "Structure de données", "Tp noté"));
            WriteLine("Moyenne note " + grp + grp.MoyNote(1, "UE 1", "R1.01", "Structure de données", "Tp noté"));
            grps.Add(grp);

            //Creation d'un prof et un cour

            Professeur prof = new Professeur("Chevaldonne", "Marc", new DateTime(1989, 10, 2), "`@&;UCCy8ab{*d9V");

            Cour c = new Cour(new DateTime(2022, 06, 12, 14, 30, 0), new TimeSpan(2, 0, 0), "A18", "Structure de données",prof,grps);
            WriteLine(c);

            //Creation Classe

            Promo IUT = new Promo(grps);
            WriteLine("Moyenne général de la promo :"+IUT.MoyGeneral());
            WriteLine("Moyenne d'une UE de la promo :" + IUT.MoyUE(1,"UE 1"));
            WriteLine("Moyenne d'une Ressource de la promo :" + IUT.MoyRessource(1, "UE 1", "R1.01"));
            WriteLine("Moyenne d'une matière de la promo :" + IUT.MoyMatière(1, "UE 1", "R1.01", "Structure de données"));
        }
    }
}
