using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    class Note
    {
        public string Nom { get; set; }

        public int note { get; set; }

        public Note(string nom, int Note)
        {
            Nom = nom;
            note = Note;
        }

        public override string ToString()
        {
            return $"{Nom} {note}";
        }
    }
}
