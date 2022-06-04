using System;
using System.Collections.Generic;
using Modele;
using static System.Console;

namespace Test_Ressource
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Test de la classe Ressource :");

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

            //Creation des Matières

            List<Matiere> matieres = new List<Matiere>();
            List<Matiere> matieres2 = new List<Matiere>();

            Matiere mat1 = new Matiere("Structure de données", notes);
            Matiere mat2 = new Matiere("Algorithme", notes2);

            matieres.Add(mat1);
            matieres.Add(mat2);

            //Creation des Ressource

            Ressource res = new Ressource("R1.01", "Initiation au développement", 42, matieres);
            Ressource res2 = new Ressource("R1.02", 12, matieres2);
            res2.AddMatiere(mat1);

            //Test des Ressources

            WriteLine(res);
            WriteLine(res2);

            WriteLine("Moyenne de la première Ressource :");
            WriteLine(res.MoyRessource());

            //Test suppresion
            WriteLine("Supprime la matière dans la deuxième Ressource :");
            res2.SuppMatiere(mat1);
            WriteLine(res2);
        }
    }
}
