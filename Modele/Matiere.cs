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
        /// <param name="nom"></param>
        /// <param name="Notes">Listes des notes concernants la matière</param>
        public Matiere(string nom, List<Note> Notes)
        {
            Nom = nom;
            notes = Notes;
        }

        /// <summary>
        /// Calcul de la moyenne d'une matière
        /// </summary>
        /// <returns>float : Moyenne</returns>
        public float MoyMatière()
        {
            if (notes.Count==0)
            {
                throw new ArgumentException("Il n'y a pas de note dans la matière");
            }
            float total = 0;
            foreach (Note note in notes)
            {
                total += note.note;
            }
            return total / notes.Count(); 
        }

        public override string ToString()
        {
            Console.WriteLine(Nom + " :");

            foreach(Note note in notes)
            {
                Console.WriteLine("     "+note.Nom + " : " + note.note);
            }
            return null;
        }


    }
}
