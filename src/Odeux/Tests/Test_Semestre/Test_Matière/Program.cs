using System;
using System.Collections.Generic;
using Modele;
using static System.Console;

namespace Test_Matière
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            WriteLine("Test de la classe Matiere :");

            // Création d'une liste de note
            List<Note> notes = new ();
            Note n1 = new ("Tp noté", 10);
            notes.Add(n1);

            Note n2 = new ("DS", 15);
            notes.Add(n2);

            Note n4 = new ("Td noté", 11.1);

            // Liste Vide
            List<Note> notes2 = new ();

            try
            {
                Note n3 = new ("DS2", -1);
            }
            catch (Exception msg)
            {
                WriteLine(msg);
            }

            Matiere mat = new ("Structure de données", notes);
            WriteLine(mat);
            WriteLine("Moyenne :" + mat.MoyMatière());

            // Test de calcul de la moyenne d'une matière, contenant aucune notes
            Matiere mat1 = new ("Bases de données", notes2);
            if (mat1.MoyMatière() != 1)
                WriteLine("Moyenne :" + mat1.MoyMatière());
            else
                WriteLine("Erreur Aucune note");

            // Après avoir rajouté une nouvel note
            WriteLine("Apres un ajout d'une nouvel note :");
            mat.AddNote(n4);
            WriteLine(mat);

            //On teste la fonction Supprimer
            WriteLine("Apres une Suppression d'une note :");
            mat.SuppNote(n4);
            WriteLine(mat);
        }
    }
}
