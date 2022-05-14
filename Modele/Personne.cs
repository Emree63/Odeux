using System;
using System.Collections.Generic;
using System.Text;

namespace Modele
{
        /// <summary>
        /// Représente les spécificités des Personnes qui vont utiliser l'application
        /// </summary>
    public abstract class Personne
    {
        /// <summary>
        /// Nom de la Personne
        /// </summary>
        private string Nom;
        public string nom { get => Nom; set => Nom = value; }

        /// <summary>
        /// Prénom de la Personne
        /// </summary>
        private string Prénom;
        public string prénom { get => Prénom; set => Prénom = value; }

        /// <summary>
        /// Date de Naissance de la Personne
        /// </summary>
        private DateTime Naissance;
        public DateTime naissance { get => Naissance; set => Naissance = value; }

        /// <summary>
        /// Mot de Passe de la Personne pour se connecter
        /// </summary>
        private string PassWord;
        public string password { get => PassWord; set => PassWord = value; }

        /// <summary>
        ///  Constructeur
        /// </summary>
        /// <param name="nom">Nom de la Personne</param>
        /// <param name="prénom">Prénom de la Personne</param>
        /// <param name="naissance">Date de Naissance de la Personne</param>
        /// <param name="password">Mot de Passe</param>
        public Personne(string nomP, string prénomP, DateTime naissanceP, string passwordP)
        {
            Nom = nomP;
            Prénom = prénomP;
            Naissance = naissanceP;
            PassWord = passwordP;
        }

        public override string ToString()
        {
            return $"{Nom} {Prénom}";
        }

}
}
