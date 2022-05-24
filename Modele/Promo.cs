using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Promo
    {
        /// <summary>
        /// Tout les groupes d'éléves constituant la promo
        /// </summary>
        private IEnumerable<Groupe> groupes => groupes2;
        public List<Groupe> groupes2 = new List<Groupe>();

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="grp">Groupes concernant la promo</param>
        public Promo(List<Groupe> grp) => groupes2.AddRange(grp);
        

        /// <summary>
        /// Moyenne General de tout les élèves
        /// </summary>
        /// <returns>double : Moyenne Géneral de tout les élèves de la Promo</returns>
        public double MoyGeneral()
        {
            double total = 0, nb=0;
            foreach (Groupe grp in groupes)
            {
                 foreach(Etudiant etu in grp.etudiants)
                {
                    total += etu.MoyGeneral();
                    nb++;
                }
            }
            return total / nb;
        }

        /// <summary>
        /// Moyenne général d'une UE pour tout les élèves de la promo
        /// </summary>
        /// <param name="sem">Semestre sur laquelle L'UE est concerner</param>
        /// <param name="UE">UE en question</param>
        /// <returns>double: Moyenne de L'UE pour la promo</returns>
        public double MoyUE(int sem, string UE)
        {
            double total = 0, nb = 0;
            foreach (Groupe grp in groupes)
            {
                foreach (Etudiant etu in grp.etudiants)
                {
                    if(etu.semestre1.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.semestre1.LesUE)
                        {
                            if (ue.num == UE)
                            {
                                total += ue.MoyUE();
                                nb++;
                            }
                        }
                    }
                    if (etu.semestre2.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.semestre2.LesUE)
                        {
                            if (ue.num == UE)
                            {
                                total += ue.MoyUE();
                                nb++;
                            }
                        }
                    }
                }
            }
            return total / nb;
        }

        /// <summary>
        /// Renvoie la moyenne générale d'une matière sur l'ensemble des élèves
        /// </summary>
        /// <param name="sem">semestre concernant l'UE</param>
        /// <param name="UE">UE concernant la ressource en question</param>
        /// <param name="res">Ressource où est contenu la matière</param>
        /// <param name="mat">Matière concerner</param>
        /// <returns>double : moyenne d'une matière</returns>
        public double MoyMatière(int sem, string UE, string res ,string mat)
        {
            double total = 0, nb = 0;
            foreach (Groupe grp in groupes)
            {
                foreach (Etudiant etu in grp.etudiants)
                {
                    if (etu.semestre1.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.semestre1.LesUE)
                        {
                            if (ue.num == UE)
                            {
                                foreach(Ressource Res in ue.ressources)
                                {
                                    if(Res.num == res)
                                    {
                                        foreach(Matiere Mat in Res.matieres)
                                        {
                                            if(Mat.Nom == mat)
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
                    if (etu.semestre2.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.semestre2.LesUE)
                        {
                            if (ue.num == UE)
                            {
                                foreach (Ressource Res in ue.ressources)
                                {
                                    if (Res.num == res)
                                    {
                                        foreach (Matiere Mat in Res.matieres)
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
            return total / nb;
        }

        /// <summary>
        /// Moyenne générale d'une ressource sur l'ensemble des élèves
        /// </summary>
        /// <param name="sem">semestre concernant l'UE</param>
        /// <param name="UE">UE concernant la ressource en question</param>
        /// <param name="res">Ressource sur lequel on veut obtenir la moyenne</param>
        /// <returns>double : Moyenne d'une UE</returns>
        public double MoyRessource(int sem, string UE, string res)
        {
            double total = 0, nb = 0;
            foreach (Groupe grp in groupes)
            {
                foreach (Etudiant etu in grp.etudiants)
                {
                    if (etu.semestre1.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.semestre1.LesUE)
                        {
                            if (ue.num == UE)
                            {
                                foreach (Ressource Res in ue.ressources)
                                {
                                    if (Res.num == res)
                                    {
                                        total += Res.MoyRessource();
                                        nb++;
                                    }
                                }
                            }
                        }
                    }
                    if (etu.semestre2.NumSemestre == sem)
                    {
                        foreach (UE ue in etu.semestre2.LesUE)
                        {
                            if (ue.num == UE)
                            {
                                foreach (Ressource Res in ue.ressources)
                                {
                                    if (Res.num == res)
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
