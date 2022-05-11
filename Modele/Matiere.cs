 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Matiere
    {
        /// <summary>
        /// Nom de la matiere
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Listes des notes d'una matière
        /// </summary>
        private List<Note> notes;
        public List<Note>Notes1 { get => notes; set => notes= value;}

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom de la matiere</param>
        /// <param name="Notes">Listes des notes concernants la matière</param>
        public Matiere(string nom, List<Note> Notes)
        {
            Nom = nom;
            notes = Notes;
        }

        /// <summary>
        /// Constructeur sans Liste
        /// </summary>
        /// <param name="nom">Nom de la matiere</param>
        public Matiere(string nom)
        {
            List<Note> n = new List<Note>();
            Nom = nom;
            notes = n;
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="Notes">Listes des notes concernants la matière</param>
        public Matiere(List<Note> Notes): this(null,Notes)
        {

        }

        /// <summary>
        /// Calcul de la moyenne d'une matière
        /// </summary>
        /// <returns>float : Moyenne</returns>
        public double MoyMatière()
        {
            if (notes.Count==0)
            {
                throw new ArgumentException("Il n'y a pas de note dans la matière");
            }
            double total = 0;
            foreach (Note note in notes)
            {
                total += note.note;
            }
            return total / notes.Count(); 
        }

        /// <summary>
        /// Ajouter une nouvelle note à la matière
        /// </summary>
        /// <param name="NouvelNote">La nouvelle note à inserer</param>
        public void AddNote(Note NouvelNote)
        {
            notes.Add(NouvelNote);
        }

        /// <summary>
        /// Supprimer une note de la matière
        /// </summary>
        /// <param name="note">La note à supprimer</param>
        public void SuppNote(Note note)
        {
            notes.Remove(note);
        }
        public override string ToString()
        {
            if(Nom !=  null) Console.WriteLine(Nom + " :");

            foreach(Note note in notes)
            {
                Console.WriteLine("     "+note.Nom + " : " + note.note);
            }
            return null;
        }


    }
}
