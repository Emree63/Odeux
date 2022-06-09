using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    public class Promo
    {
        /// <summary>
        /// Tout les groupes d'élèves constituant la promo
        /// </summary>
        [DataMember]
        public List<Groupe> Groupes { get; set; }

        /// <summary>
        /// Listes des nouvelles note de l'élève, le string va contenir le nom de l'élève
        /// </summary>
        [DataMember]
        public Dictionary<Note, string> NouvelNote { get; set; } = new Dictionary<Note, string>();

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="grp">Groupes concernant la promo</param>
        public Promo(List<Groupe> grp) => Groupes = grp;


        /// <summary>
        /// Moyenne General de tous les élèves
        /// </summary>
        /// <returns>double : Moyenne Géneral de tous les élèves de la Promo</returns>
        public double MoyGeneral()
        {
            double total = 0, nb = 0;
            foreach (Groupe grp in Groupes)
            {
                foreach (Etudiant etu in grp.etudiants)
                {
                    if (etu.MoyGeneral() != -1)
                    {
                        total += etu.MoyGeneral();
                        nb++;
                    }
                }
            }
            if (nb != 0)
                return Math.Round(total / nb, 2); //Return decimal
            else
                return -1;
        }

        /// <summary>
        /// Moyenne général d'une UE pour tous les élèves de la promo
        /// </summary>
        /// <param name="sem">Semestre sur laquelle L'UE est concerner</param>
        /// <param name="UE">UE en question</param>
        /// <returns>double: Moyenne de L'UE pour la promo</returns>
        public double MoyUE(int sem, string UE)
        {
            double total = 0, nb = 0;
            foreach (Groupe grp in Groupes)
            {
                foreach (Etudiant etu in grp.etudiants)
                {
                    if (etu.Semestre1.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.Semestre1.LesUE)
                        {
                            if (ue.Num == UE)
                            {
                                if (ue.MoyUE() != -1)
                                {
                                    total += ue.MoyUE();
                                    nb++;
                                }
                            }
                        }
                    }
                    if (etu.Semestre2.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.Semestre2.LesUE)
                        {
                            if (ue.Num == UE)
                            {
                                if (ue.MoyUE() != -1)
                                {
                                    total += ue.MoyUE();
                                    nb++;
                                }
                            }
                        }
                    }
                }
            }
            if (nb != 0)
                return Math.Round(total / nb, 2);
            else
                return -1;
        }

        /// <summary>
        /// Renvoie la moyenne générale d'une matière sur l'ensemble des élèves
        /// </summary>
        /// <param name="sem">Semestre concernant l'UE</param>
        /// <param name="UE">UE concernant la ressource en question</param>
        /// <param name="res">Ressource où est contenu la matière</param>
        /// <param name="mat">Matière concerner</param>
        /// <returns>double : moyenne d'une matière</returns>
        public double MoyMatière(int sem, string UE, string res, string mat)
        {
            double total = 0, nb = 0;
            foreach (Groupe grp in Groupes)
            {
                foreach (Etudiant etu in grp.etudiants)
                {
                    if (etu.Semestre1.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.Semestre1.LesUE)
                        {
                            if (ue.Num == UE)
                            {
                                foreach (Ressource Res in ue.Ressources)
                                {
                                    if (Res.Num == res)
                                    {
                                        foreach (Matiere Mat in Res.Matieres)
                                        {
                                            if (Mat.Nom == mat)
                                            {
                                                total += Mat.MoyMatière();
                                                nb++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if (etu.Semestre2.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.Semestre2.LesUE)
                        {
                            if (ue.Num == UE)
                            {
                                foreach (Ressource Res in ue.Ressources)
                                {
                                    if (Res.Num == res)
                                    {
                                        foreach (Matiere Mat in Res.Matieres)
                                        {
                                            if (Mat.Nom == mat)
                                            {
                                                total += Mat.MoyMatière();
                                                nb++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (nb != 0)
                return total / nb;
            else
                return -1;
        }

        /// <summary>
        /// Moyenne générale d'une ressource sur l'ensemble des élèves
        /// </summary>
        /// <param name="sem">Semestre concernant l'UE</param>
        /// <param name="UE">UE concernant la ressource en question</param>
        /// <param name="res">Ressource sur lequel on veut obtenir la moyenne</param>
        /// <returns>double : Moyenne d'une UE</returns>
        public double MoyRessource(int sem, string UE, string res)
        {
            double total = 0, nb = 0;
            foreach (Groupe grp in Groupes)
            {
                foreach (Etudiant etu in grp.etudiants)
                {
                    if (etu.Semestre1.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.Semestre1.LesUE)
                        {
                            if (ue.Num == UE)
                            {
                                foreach (Ressource Res in ue.Ressources)
                                {
                                    if (Res.Num == res)
                                    {
                                        total += Res.MoyRessource();
                                        nb++;
                                    }
                                }
                            }
                        }
                    }
                    if (etu.Semestre2.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.Semestre2.LesUE)
                        {
                            if (ue.Num == UE)
                            {
                                foreach (Ressource Res in ue.Ressources)
                                {
                                    if (Res.Num == res)
                                    {
                                        total += Res.MoyRessource();
                                        nb++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return total / nb;
        }

        public override string ToString() => "Promo";
    }
}
