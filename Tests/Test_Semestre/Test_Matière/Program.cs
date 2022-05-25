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
            List<Note> notes = new List<Note>();
            Note n1 = new Note("Tp noté", 10);
            notes.Add(n1);

            Note n2 = new Note("DS", 15);
            notes.Add(n2);

            Note n4 = new Note("Td noté", 11.1);

            // Liste Vide
            List<Note> notes2 = new List<Note>();

            try
            {
                Note n3 = new Note("DS2", -1);
            }
            catch (Exception msg)
            {
                WriteLine(msg);
            }

            Matiere mat = new Matiere("Structure de données", notes);
            WriteLine(mat);
            WriteLine("Moyenne :" + mat.MoyMatière());

            // Test de calcul de la moyenne d'une matière, contenant aucune notes
            Matiere mat1 = new Matiere("Bases de données", notes2);
            try
            {
                WriteLine("Moyenne :" + mat1.MoyMatière());
            }
            catch (Exception msg)
            {
                WriteLine(msg);
            }

            // Aprés avoir rajouter une nouvel note
            WriteLine("Apres un ajout d'une nouvel note :");
            mat.AddNote(n4);
            WriteLine(mat);

            //On teste la fonction Supprimer
            WriteLine("Apres une Suppresion d'une note :");
            mat.SuppNote(n4);
            WriteLine(mat);

        }
    }
}
