using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class SAE
    {
        /// <summary>
        /// Nom de la SAE
        /// </summary>
        public string Nom { get; set; }
        
        /// <summary>
        /// note de la SAE
        /// </summary>
        private Note note;
        public Note note1 { get => note; set => note = value; }

        /// <summary>
        /// Coefficient de la SAE
        /// </summary>
        public int Coef { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="nom">Nom de la SAE</param>
        /// <param name="n">note de la SAE</param>
        /// <param name="coef">Coefficient de la SAE</param>
        public SAE(string nom, Note n, int coef)
        {
            if (string.IsNullOrWhiteSpace(nom))
                Nom = "Aucun Nom";
            else 
                Nom = nom;
            note = n;
            if (coef < 0)
                Coef = 1;
            else Coef = coef;
        }

        /// <summary>
        /// Renvoie la note de la SAE
        /// </summary>
        /// <returns>double : note</returns>
        public double getNote() => note.note;

        public override string ToString() => $"{Nom} - {Coef}\n\t {note.Nom}: {note.note}";
        
    }
}
