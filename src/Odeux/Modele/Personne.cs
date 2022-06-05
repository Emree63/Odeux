using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    /// <summary>
    /// Représente les spécificités des Personnes qui vont utiliser l'application
    /// </summary>
    [DataContract, KnownType(typeof(Etudiant)), KnownType(typeof(Professeur))]
    public abstract class Personne : IEquatable<Personne>
    {
        /// <summary>
        /// Nom de la Personne
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 0)]
        public string Nom { get => nom; set => nom = value; }
        private string nom;

        /// <summary>
        /// Prénom de la Personne
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 1)]
        public string Prénom { get => prénom; set => prénom = value; }
        private string prénom;

        /// <summary>
        /// Date de Naissance de la Personne
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 3)]
        public DateTime Naissance { get => naissance; set => naissance = value; }
        private DateTime naissance;

        /// <summary>
        /// Mot de Passe de la Personne pour se connecter
        /// </summary>
        [DataMember(EmitDefaultValue = false, Order = 2)]
        public string Password { get => password; set => password = value; }
        private string password;

        /// <summary>
        ///  Constructeur de la classe Personne
        /// </summary>
        /// <param name="nom">Nom de la Personne</param>
        /// <param name="prénom">Prénom de la Personne</param>
        /// <param name="naissance">Date de Naissance de la Personne</param>
        /// <param name="password">Mot de Passe</param>
        public Personne(string nom, string prénom, DateTime naissance, string password)
        {
            if (string.IsNullOrWhiteSpace(nom)) throw new ArgumentException("Nom manquant");
            if (string.IsNullOrWhiteSpace(prénom)) throw new ArgumentException("Prénom manquant");
            if (naissance>DateTime.Now) throw new ArgumentException("La date de naissance ne correspond pas");
            if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Le mot de passe doit être renseigner !");
            this.nom = nom;
            this.prénom = prénom;
            this.naissance = naissance;
            this.password = password;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null)) return false;
            if (ReferenceEquals(obj, this)) return true;
            if (GetType() != obj.GetType()) return false;
            return base.Equals(obj as Personne);
        }

        public bool Equals(Personne other) => Nom == other.Nom;

        public override int GetHashCode()
        {
            return Nom.GetHashCode();
        }
        public override string ToString() => nom;

    }
}
