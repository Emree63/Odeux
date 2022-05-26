using System;
using static System.Console;
using Modele;
using System.Collections.Generic;

namespace Test_Professeur
{
    class Program
    {
        static void Main(string[] args)
        {
            // On reprend les ancienes classes pour ce test

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

            Note n5 = new Note("Situation 1 (sur 20.0)", 16);

            Note n6 = new Note("Situation 2 (sur 20.0)", 11);

            //Creation des Matières

            List<Matiere> matieres = new List<Matiere>();
            List<Matiere> matieres2 = new List<Matiere>();

            Matiere mat1 = new Matiere("Structure de données", notes);
            Matiere mat2 = new Matiere("Algorithme", notes2);

            matieres.Add(mat1);
            matieres.Add(mat2);
            matieres2.Add(mat1);

            //Creation des Ressource

            Ressource res = new Ressource("R1.01", "Initiation au développement", 42, matieres);
            Ressource res2 = new Ressource("R1.02", 12, matieres2);

            //Creation d'une UE

            List<UE> lesUE = new List<UE>();
            List<UE> lesUE2 = new List<UE>();

            UE ue = new UE("UE 1", "Développer des applications informatiques simples");
            UE ue2 = new UE("UE 2", "Appréhender et construire des algorithmes");

            ue.AddRessource(res);
            ue.AddRessource(res2);
            ue2.AddRessource(res);

            lesUE.Add(ue);
            lesUE2.Add(ue2);

            //Creation SAE

            SAE sae = new SAE("S1.01 : Implémentation d’un besoin client", n5, 40);
            ue.AddSAE(sae);

            SAE sae2 = new SAE("S1.02 : Comparaison d’approches algorithmiques", n6, 40);
            ue2.AddSAE(sae2);


            //Creation de deux Semestre

            Semestre s1 = new Semestre(1, lesUE);
            Semestre s2 = new Semestre(2, lesUE2);

            //Creation d'un Etudiant

            DateTime nais = new DateTime(2002, 10, 22);
            Etudiant etu1 = new Etudiant("Etudiant ", "1", nais, "Cinq combattants distinguent des esquives et les rêves.", s1, s2);


            Console.WriteLine("Test de la Classe Professeur");

            Console.ForegroundColor = ConsoleColor.Red;

            //Creation d'un Professeur

            WriteLine(etu1.semestre1);
            WriteLine(etu1.MoyGeneral());
            DateTime nais2 = new DateTime(1989, 10, 2);
            Professeur prof = new Professeur("Professeur ", "Marc", nais2, "`@&;UCCy8ab{*d9V");
            Write(prof);
            prof.Noter(1, "UE 1", "R1.01", mat1, etu1);
            WriteLine("---------------Apres l'ajout de la note !-------------------");
            Write(etu1.semestre1);
            WriteLine(etu1.MoyGeneral());
        }
    }
}
