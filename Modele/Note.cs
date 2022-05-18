using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Note
    {
        /// <summary>
        /// Nom de la note
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Nombre d'une note
        /// </summary>
        public double note { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom de la note</param>
        /// <param name="Note">Nombre obtenu de la note note</param>
        public Note(string nom, double Note)
        {
            if (string.IsNullOrWhiteSpace(nom)) Nom = "Aucun Nom";
            else Nom = nom;
            if (Note < 0) note = 0;
            else    note = Note;
        }

        public override string ToString()
        {
            return $"{Nom} {note}";
        }
    }
}
