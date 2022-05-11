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
            if (string.IsNullOrWhiteSpace(nom) || Note<0)
            {
                throw new ArgumentException("La note n'est pas conforme, veuillez rentrer des informations valables !");
            }
            Nom = nom;
            note = Note;
        }

        public override string ToString()
        {
            return $"{Nom} {note}";
        }
    }
}
