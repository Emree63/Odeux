﻿using System;
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
        [DataMember]
        public string Nom { get => nom; set => nom = value; }
        private string nom;

        /// <summary>
        /// Prénom de la Personne
        /// </summary>
        [DataMember]
        public string Prénom { get => prénom; set => prénom = value; }
        private string prénom;

        /// <summary>
        /// Date de Naissance de la Personne
        /// </summary>
        [DataMember]
        public DateTime Naissance { get => naissance; set => naissance = value; }
        private DateTime naissance;

        /// <summary>
        /// Mot de Passe de la Personne pour se connecter
        /// </summary>
        [DataMember]
        public string Password { get => password; set => password = value; }
        private string password;

        /// <summary>
        ///  Constructeur de la classe Personne
        /// </summary>
        /// <param name="nom">Nom de la Personne</param>
        /// <param name="prénom">Prénom de la Personne</param>
        /// <param name="naissance">Date de Naissance de la Personne</param>
        /// <param name="password">Mot de Passe</param>
        public Personne(string nomP, string prénomP, DateTime naissanceP, string passwordP)
        {
            nom = nomP;
            prénom = prénomP;
            naissance = naissanceP;
            password = passwordP;
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
