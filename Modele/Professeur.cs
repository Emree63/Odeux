using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Professeur : Personne
    {
        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom du Professeur</param>
        /// <param name="prénom">Prenom du Professeur</param>
        /// <param name="naissance">date de Naissance </param>
        /// <param name="password">Mot de passe pour la connection à l'application</param>
        public Professeur(string nom, string prénom, DateTime naissance, string password) : base(nom, prénom, naissance, password)
        {

        }

        public void Noter()
        {
            string nom;
            double note;
            Console.Write("Nom :");
            nom=Console.ReadLine();
            Console.Write("Note :")
            note = Console.ReadLine();

        }
    }
}
