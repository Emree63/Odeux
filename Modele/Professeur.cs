﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Professeur : Personne
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom du Professeur</param>
        /// <param name="prénom">Prenom du Professeur</param>
        /// <param name="naissance">date de Naissance </param>
        /// <param name="password">Mot de passe pour la connection à l'application</param>
        public Professeur(string nom, string prénom, DateTime naissance, string password) : base(nom, prénom, naissance, password)
        {

        }

        /// <summary>
        /// Donner une note à l'élève que l'on donne en paramètre
        /// </summary>
        /// <param name="Semestre">Semestre de l'étudiant</param>
        /// <param name="UE">UE de l'étudiant</param>
        /// <param name="ressource">Ressource concernant l'étudiant</param>
        /// <param name="mat">Matière concernant l'étudiant</param>
        /// <param name="etu">etudiant concerner</param>
        public void Noter(int Semestre, string UE, string ressource ,Matiere mat, Etudiant etu)
        {
            string nom;
            double note;
            Console.Write("Nom de la nouvel note:");
            nom=Console.ReadLine();
            Console.Write("Note obtenu :");
            string ligne = Console.In.ReadLine();
            note = double.Parse(ligne);
            if(etu.semestre1.NumSemestre == Semestre)
            {
                foreach(UE ue in etu.semestre1.LesUE)
                {
                    if(ue.num == UE)
                    {
                        foreach(Ressource res in ue.ressources)
                        {
                            if(res.num == ressource)
                            {
                                foreach(Matiere mat2 in res.matieres)
                                {
                                    if(mat2 == mat)
                                    {
                                        Note n = new Note(nom, note);
                                        mat2.AddNote(n);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if(etu.semestre2.NumSemestre == Semestre)
            {
                foreach (UE ue in etu.semestre2.LesUE)
                {
                    if (ue.num == UE)
                    {
                        foreach (Ressource res in ue.ressources)
                        {
                            if (res.num == ressource)
                            {
                                foreach (Matiere mat2 in res.matieres)
                                {
                                    if (mat2 == mat)
                                    {
                                        Note n = new Note(nom, note);
                                        mat2.AddNote(n);
                                    }
                                }
                            }
                        }
                    }
                }
            }

        }

        public override string ToString()
        {
            return $"Je suis professeur et je m 'appelle {nom} {prénom} \n";
        }
    }
}