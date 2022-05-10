using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    class Etudiant : Personne
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom de l'étudiant</param>
        /// <param name="prénom">prénom de l'étudiant</param>
        /// <param name="naissance">date de naissance de l'étudiant</param>
        /// <param name="password">Mot de passe(privé) pour se connecter</param>
        public Etudiant(string nom, string prénom, DateTime naissance, string password) : base(nom,prénom,naissance,password)
        {

        }

        public override string ToString()
        {
            return $"Je suis un étudiant et je m'appelle : {nom} {prénom}";
        }

    }
}
