﻿using System;
using static System.Console;
using Modele;
using System.Collections.Generic;

namespace Test_UE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test de la classe UE :");

            // Création des Liste de note
            List<Note> notes = new ();
            Note n1 = new Note("Tp noté", 10);
            notes.Add(n1);

            Note n2 = new Note("DS", 15);
            notes.Add(n2);


            List<Note> notes2 = new ();
            Note n3 = new Note("Tp noté", 13);
            notes2.Add(n3);

            Note n4 = new Note("DS", 11);
            notes2.Add(n4);

            Note n5 = new Note("Situation 1 (sur 20.0)", 16);

            //Création des Matières

            List<Matiere> matieres = new ();
            List<Matiere> matieres2 = new ();

            Matiere mat1 = new Matiere("Structure de données", notes);
            Matiere mat2 = new Matiere("Algorithme", notes2);

            matieres.Add(mat1);
            matieres.Add(mat2);
            matieres2.Add(mat1);

            //Création des Ressource

            Ressource res = new ("R1.01", "Initiation au développement", 42, matieres);
            Ressource res2 = new ("R1.02", 12, matieres2);

            //Création d'une UE

            UE ue = new ("UE 1", "Développer des applications informatiques simples");
            UE ue2 = new ("UE 1", "Développer des applications informatiques simples");

            ue.AddRessource(res);
            ue.AddRessource(res2);

            //Création SAE

            SAE sae = new ("S1.01 : Implémentation d’un besoin client", n5, 42);

            ue.AddSAE(sae);
            Write(ue);

            Write("Moyenne de l'UE :" + ue.MoyUE());

        }
    }
}
