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

        public override string ToString()
        {
            return $"Je suis un étudiant et je m'appelle : {nom} {prénom}";
        }

        /// <summary>
        /// Moyenne General de l'eleve sur toute son année
        /// </summary>
        /// <returns>double : Moyenne</returns>
        public double MoyGeneral()
        {

            double total = 0;

            try
            {
                total = Semestre1.MoySemestre() + Semestre2.MoySemestre();
            }
            catch (Exception msg)
            {
                Console.WriteLine(msg);
                return 0;
            }
            return total / 2;
        }
    }
    
}
