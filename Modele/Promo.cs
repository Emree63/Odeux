using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    class Promo
    {
        /// <summary>
        /// Tout les groupes d'éléves constituant la promo
        /// </summary>
        private List<Groupe> groupes;
        public List<Groupe> groupes2 { get => groupes; set => groupes = value; }

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

        public override string ToString()
        {
            return "Promo";
        }
    }
}
