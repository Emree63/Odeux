using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    public class Matiere
    {
        /// <summary>
        /// Nom de la matière
        /// </summary>
        [DataMember]
        public string Nom { get; set; }

        /// <summary>
        /// Liste des notes d'une matière
        /// </summary>
        [DataMember]
        public List<Note> notes { get; set; }

        /// <summary>
        /// Cette variable n'est là que pour reprendre le résultat de la fonction MoyMatière() pour le côté binding de l'application
        /// </summary>
        [DataMember]
        public double MoyMat { get; set; }

        /// <summary>
        /// Constructeur de la classe Matière
        /// </summary>
        /// <param name="nom">Nom de la matière</param>
        /// <param name="Notes">Liste des notes concernant la matière</param>
        public Matiere(string nom, List<Note> Notes)
        {
            if (string.IsNullOrWhiteSpace(nom)) throw new ArgumentException("Le nom doit être renseigner");
            else Nom = nom;
            notes = Notes;
            MoyMat = MoyMatière();
        }

        /// <summary>
        /// Constructeur sans liste de note
        /// </summary>
        /// <param name="nom">Nom de la matière</param>
        public Matiere(string nom) : this(nom, new List<Note>())
        {
        }

        /// <summary>
        /// Constructeur d'une matière sans Nom
        /// </summary>
        /// <param name="Notes">Listes des notes concernant la matière</param>
        public Matiere(List<Note> Notes) : this("Aucun Nom", Notes)
        {

        }

        /// <summary>
        /// Calcul de la moyenne d'une Matière
        /// </summary>
        /// <returns>Float : Moyenne</returns>
        public double MoyMatière()
        {
            if (notes.Count() == 0)
            {
                MoyMat = -1;
                return -1;
            }
            double total = 0;
            foreach (Note note in notes)
            {
                total += note.note;
            }
            MoyMat = total / notes.Count();
            return MoyMat;
        }

        /// <summary>
        /// Ajouter une nouvelle note à la matière
        /// </summary>
        /// <param name="NouvelNote">La nouvelle note à insérer</param>
        public void AddNote(Note NouvelNote) => notes.Add(NouvelNote);

        /// <summary>
        /// Supprimer une note de la matière
        /// </summary>
        /// <param name="note">La note à supprimer</param>
        public void SuppNote(Note note) => notes.Remove(note);

        public override string ToString()
        {
            if (Nom != null) Console.WriteLine(Nom + " :");

            foreach (Note note in notes)
            {
                Console.WriteLine("     " + note.Nom + " : " + note.note);
            }
            return null;
        }

    }
}
