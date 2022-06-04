using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Groupe
    {
        /// <summary>
        /// Numéro du groupe d'étudiants.
        /// </summary>
        int num;
        public int Num { get => num; set => num = value; }

        /// <summary>
        /// Liste des étudiant concernant le groupe.
        /// </summary>
        List<Etudiant> étudiants;
        public List<Etudiant> etudiants { get => étudiants; set => étudiants = value; }

        /// <summary>
        /// Constructeur de la classe Groupe.
        /// </summary>
        /// <param name="num">Numéro du groupe.</param>
        /// <param name="etu">Liste des étudiants constituant le groupe.</param>
        public Groupe(int num, List<Etudiant> etu)
        {
            this.num = num;
            étudiants = etu;
        }

        /// <summary>
        /// Renvoie la pire note du groupe.
        /// </summary>
        /// <param name="sem">Semestre concernant la note.</param>
        /// <param name="UE">UE concernant la note.</param>
        /// <param name="Ressource">Ressource concernant la note.</param>
        /// <param name="mat">Matière concerner.</param>
        /// <param name="note">Nom de la note qu'on veut obtenir.</param>
        /// <returns>Double : note la plus basse du groupe.</returns>
        public double MinNote(int sem, string UE, string Ressource, string mat, string note)
        {
            double pireNote = 20, y;


            foreach (Etudiant etu in étudiants)
            {
                y = etu.getNote(sem, UE, Ressource, mat, note);
                if (y >= 0)
                {
                    if (y < pireNote)
                    {
                        pireNote = y;
                    }
                }
            }
            return pireNote;

        }

        /// <summary>
        /// Renvoie la meilleur note du groupe.
        /// </summary>
        /// <param name="sem">Semestre concernant la note.</param>
        /// <param name="UE">UE concernant la note.</param>
        /// <param name="Res">Ressource concernant la note.</param>
        /// <param name="mat">Matière.</param>
        /// <param name="note">Nom de la note qu'on veut obtenir.</param>
        /// <returns>Double : note le plus haut du groupe.</returns>
        public double MaxNote(int sem, string UE, string Res, string mat, string note)
        {
            double BestNote = 0, y;


            foreach (Etudiant etu in étudiants)
            {
                y = etu.getNote(sem, UE, Res, mat, note);
                if (y >= 0)
                {
                    if (y > BestNote)
                    {
                        BestNote = y;
                    }
                }
            }
            return BestNote;
        }

        /// <summary>
        /// Moyenne concernant une note.
        /// </summary>
        /// <param name="sem">Semestre concernant la note.</param>
        /// <param name="UE">UE concernant la note.</param>
        /// <param name="Ressource">Ressource concernant la note.</param>
        /// <param name="mat">Matière.</param>
        /// <param name="note">Nom de la note qu'on veut obtenir.</param>
        /// <returns>Double : moyenne de tout les élèves sur la note.</returns>
        public double MoyNote(int sem, string UE, string Ressource, string mat, string note)
        {
            double total = 0, y;
            foreach (Etudiant etu in étudiants)
            {
                y = etu.getNote(sem, UE, Ressource, mat, note);
                if (y >= 0)
                {
                    total += y;
                }
            }
            return total / etudiants.Count();
        }

        public override string ToString() => $"{num}: ";

    }
}
