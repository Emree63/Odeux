using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Modele
{
    //Il va permettre de gerer l'authentification dans l'application!
    public partial class Manager
    {
        /// <summary>
        /// Personne (Prof ou étudiant) actuellement sur l'application.
        /// </summary>
        Personne personneActuel { get; set; }

        /// <summary>
        /// Collection de personne
        /// </summary>
        public ReadOnlyCollection<Personne> personnes => Personnes.AsReadOnly();
        List<Personne> Personnes = new List<Personne>();


        /// <summary>
        /// Ajouter des personnes à la liste
        /// </summary>
        /// <param name="pers">Liste de Personne à ajouter</param>
        public void AjouterPersonne(List<Personne> pers)
        {
            Personnes.AddRange(pers);
        }


        /// <summary>
        /// Regarde si le mot de passe et le nom existe pour la connexion dans l'application
        /// </summary>
        /// <param name="Nom">Nom qu'on va rechercher</param>
        /// <param name="PassWord">Mot de passe qui correspond à l'utilisateur</param>
        /// <returns>Renvoie le code correspondant au solution: 
        ///  1- On trouve un professeur
        ///  2- On trouve un Etudiant
        ///  0- Rien trouver</returns>
        public int Connection(string Nom, string PassWord)
        {
            var Per = personnes.FirstOrDefault(d => d.nom == Nom && d.password == PassWord);
            if (Per != null)
            {
                personneActuel = Per;
                if (personneActuel is Professeur)
                    return 1;
                if (personneActuel is Etudiant)
                {
                    EtuActuel = (Etudiant)Per;
                    return 2;
                }
            }
            return 0;
        }

        /// <summary>
        /// Modifier une personne de la Liste
        /// </summary>
        /// <param name="OldPer">Ancienne Personne</param>
        /// <param name="NewPer">Nouvel Personne</param>
        /// <returns>Booléen</returns>
        public bool ModifierPersonne(Personne OldPer,Personne NewPer)
        {
            if(!OldPer.Equals(NewPer))
            {
                return false;
            }
            Personnes.Remove(OldPer);
            Personnes.Add(NewPer);
            return true;
        }

    }
}
