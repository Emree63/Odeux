using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Etudiant : Personne
    {
        /// <summary>
        /// Premier semestre de l'étudiant
        /// </summary>
        private Semestre Semestre1;
        public Semestre semestre1 { get => Semestre1; set => Semestre1 = value; }

        /// <summary>
        /// Deuxième semestre de l'étudiant
        /// </summary>
        private Semestre Semestre2;
        public Semestre semestre2 { get => Semestre2; set => Semestre2 = value; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom de l'étudiant</param>
        /// <param name="prénom">prénom de l'étudiant</param>
        /// <param name="naissance">date de naissance de l'étudiant</param>
        /// <param name="password">Mot de passe(privé) pour se connecter</param>
        /// <param name="s1">Premier Semestre de l'etudiant</param>
        /// <param name="s2">Deuxième Semestre de l'etudiant</param>
        public Etudiant(string nom, string prénom, DateTime naissance, string password, Semestre s1, Semestre s2) : base(nom,prénom,naissance,password)
        {
            Semestre1 = s1;
            Semestre2 = s2;
        }

        public override string ToString() => $"Je suis un étudiant et je m'appelle : {nom} {prénom}";


        /// <summary>
        /// Moyenne General de l'eleve sur toute son année
        /// </summary>
        /// <returns>double : Moyenne</returns>
        public double MoyGeneral()
        {
            double total = 0;
            int Coef = 0;

            if (Semestre1.MoySemestre() != -1)
            {
                total += Semestre1.MoySemestre();
                Coef++;
            }
            if (Semestre2.MoySemestre() != -1)
            {
                total += Semestre2.MoySemestre();
                Coef++;
            }

            if (Coef != 0)
                return total / 2;
            else
                return -1;

        }

        /// <summary>
        /// return une note
        /// </summary>
        /// <param name="sem">Semestre concernant la note</param>
        /// <param name="UE">UE concernant la note</param>
        /// <param name="Ressource">Ressource concernant la note</param>
        /// <param name="mat">matière</param>
        /// <param name="note">nom de la note qu'on veut obtenir</param>
        /// <returns>double : note</returns>
        public double getNote(int sem, string UE, string Ressource ,string mat,string note)
        {

            if(semestre1.NumSemestre== sem)
            {
                foreach(UE ue in semestre1.LesUE)
                {
                    if(ue.num == UE)
                    {
                        foreach (Ressource res in ue.ressources)
                        {
                            if(res.num == Ressource)
                            {
                                foreach(Matiere mat1 in res.matieres)
                                {
                                   if(mat1.Nom == mat)
                                    {
                                        foreach(Note n in mat1.notes)  if(n.Nom==note)  return n.note;   
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (semestre2.NumSemestre == sem)
            {
                foreach (UE ue in semestre2.LesUE)
                {
                    if (ue.num == UE)
                    {
                        foreach (Ressource res in ue.ressources)
                        {
                            if (res.num == Ressource)
                            {
                                foreach (Matiere mat1 in res.matieres)
                                {
                                    if (mat1.Nom == mat)
                                    {
                                        foreach (Note n in mat1.notes)
                                        {
                                            if (n.Nom == note) return n.note;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return -1;
        }
    }
    
}
