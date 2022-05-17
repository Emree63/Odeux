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
        /// Numéro du groupe
        /// </summary>
        private int Num;
        public int num { get => Num; set => Num = value; }

        /// <summary>
        /// Liste des étudiant concernant le groupe
        /// </summary>
        private List<Etudiant> étudiants;
        public List<Etudiant> etudiants { get => étudiants; set => étudiants = value; }
        
        public Groupe(int num, List<Etudiant> etu)
        {
            Num = num;
            étudiants = etu;
        }

        /// <summary>
        /// Renvoie la pire note du groupe
        /// </summary>
        /// <param name="sem">Semestre concernant la note</param>
        /// <param name="UE">UE concernant la note</param>
        /// <param name="Ressource">Ressource concernant la note</param>
        /// <param name="mat">matière</param>
        /// <param name="note">nom de la note qu'on veut obtenir</param>
        /// <returns>double : note la plus basse du groupe</returns>
        public double MinNote(int sem, string UE, string Ressource, string mat, string note)
        {
            double pireNote = 20, y;


            foreach(Etudiant etu in étudiants)
            {
                y = etu.getNote(sem, UE, Ressource, mat, note);
                if (y < pireNote)
                {
                    pireNote = y;
                }
            }
            return pireNote;
        }

        /// <summary>
        /// Renvoie la meilleur note du groupe
        /// </summary>
        /// <param name="sem">Semestre concernant la note</param>
        /// <param name="UE">UE concernant la note</param>
        /// <param name="Ressource">Ressource concernant la note</param>
        /// <param name="mat">matière</param>
        /// <param name="note">nom de la note qu'on veut obtenir</param>
        /// <returns>double : note le plus haut du groupe</returns>
        public double MaxNote(int sem, string UE, string Ressource, string mat, string note)
        {
            double BestNote = 20, y;


            foreach (Etudiant etu in étudiants)
            {
                y = etu.getNote(sem, UE, Ressource, mat, note);
                if (y > BestNote)
                {
                    BestNote = y;
                }
            }
            return BestNote;
        }

        /// <summary>
        /// Moyenne concernant une note
        /// </summary>
        /// <param name="sem">Semestre concernant la note</param>
        /// <param name="UE">UE concernant la note</param>
        /// <param name="Ressource">Ressource concernant la note</param>
        /// <param name="mat">matière</param>
        /// <param name="note">nom de la note qu'on veut obtenir</param>
        /// <returns>double : moyenne de tout les élèves sur la note</returns>
        public double MoyNote(int sem, string UE, string Ressource, string mat, string note)
        {
            double total = 0;
            foreach (Etudiant etu in étudiants)
            {
                total += etu.getNote(sem, UE, Ressource, mat, note);
            }
            return total / etudiants.Count();
        }
    }
}
