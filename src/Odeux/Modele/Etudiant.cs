using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    public class Etudiant : Personne
    {
        /// <summary>
        /// Premier semestre de l'étudiant
        /// </summary>
        [DataMember]
        public Semestre Semestre1 { get => semestre1; set => semestre1 = value; }
        private Semestre semestre1;

        /// <summary>
        /// Deuxième semestre de l'étudiant
        /// </summary>
        [DataMember]
        public Semestre Semestre2 { get => semestre2; set => semestre2 = value; }
        private Semestre semestre2;

        /// <summary>
        /// Constructeur de la classe Etudiant
        /// </summary>
        /// <param name="nom">Nom de l'étudiant</param>
        /// <param name="prénom">Prénom de l'étudiant</param>
        /// <param name="naissance">Date de naissance de l'étudiant</param>
        /// <param name="password">Mot de passe (privé) pour se connecter</param>
        /// <param name="s1">Premier Semestre de l'étudiant</param>
        /// <param name="s2">Deuxième Semestre de l'étudiant</param>
        public Etudiant(string nom, string prénom, DateTime naissance, string password, Semestre s1, Semestre s2) : base(nom, prénom, naissance, password)
        {
            semestre1 = s1;
            semestre2 = s2;
        }

        public override string ToString() => $"Je suis un étudiant et je m'appelle : {Nom} {Prénom}";


        /// <summary>
        /// Moyenne General de l'étudiant sur toute son année.
        /// </summary>
        /// <returns>double : Moyenne.</returns>
        public double MoyGeneral()
        {
            double total = 0;
            int Coef = 0;

            if (semestre1.MoySemestre() != -1)
            {
                total += semestre1.MoySemestre();
                Coef++;
            }
            if (semestre2.MoySemestre() != -1)
            {
                total += semestre2.MoySemestre();
                Coef++;
            }

            if (Coef != 0)
                return Math.Round(total / Coef, 2);
            else
                return -1;

        }

        /// <summary>
        /// Return une note
        /// </summary>
        /// <param name="sem">Semestre concernant la note</param>
        /// <param name="UE">UE concernant la note</param>
        /// <param name="Ressource">Ressource concernant la note</param>
        /// <param name="mat">Matière concernant la note</param>
        /// <param name="note">Nom de la note qu'on veut obtenir</param>
        /// <returns>Double : note</returns>
        public double getNote(int sem, string UE, string Ressource, string mat, string note)
        {

            if (Semestre1.NumSemestre == sem)
            {
                foreach (UE ue in Semestre1.LesUE)
                {
                    if (ue.Num == UE)
                    {
                        foreach (Ressource res in ue.Ressources)
                        {
                            if (res.Num == Ressource)
                            {
                                foreach (Matiere mat1 in res.Matieres)
                                {
                                    if (mat1.Nom == mat)
                                    {
                                        foreach (Note n in mat1.notes) if (n.Nom == note) return n.note;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (Semestre2.NumSemestre == sem)
            {
                foreach (UE ue in Semestre2.LesUE)
                {
                    if (ue.Num == UE)
                    {
                        foreach (Ressource res in ue.Ressources)
                        {
                            if (res.Num == Ressource)
                            {
                                foreach (Matiere mat1 in res.Matieres)
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
