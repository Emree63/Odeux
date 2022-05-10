using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Ressource
    {
        /// <summary>
        /// Numéro de la Ressource
        /// </summary>
        private string Num;
        public string num { get => Num; set => Num = value; }

        /// <summary>
        /// Description détailler de la Ressource
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Coefficient de la Ressource
        /// </summary>
        public int Coef { get; set; }

        /// <summary>
        /// Liste des Matières dans une Ressource
        /// </summary>
        private List<Matiere> matieres;
        public List<Matiere> mat { get => matieres; set => matieres = value; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="num">Numéro de la nouvelle Ressource</param>
        /// <param name="description">(Optionnel :) Description de la nouvelle Ressource</param>
        /// <param name="coef">Coefficient de la nouvelle Ressource</param>
        public Ressource(string num, string description, int coef, List<Matiere> mat)
        {
            if(string.IsNullOrWhiteSpace(num))
            {
                throw new ArgumentException("Le numéro de la Ressource doit être fournie");
            }
            if(coef<0)
            {
                throw new ArgumentException("Le coefficient ne peut pas être égale ou inférieur à zéro");
            }
            Num = num;
            Description = description;
            Coef = coef;
            matieres = mat;
        }

        public Ressource(string num, int coef, List<Matiere> mat) : this(num,null,coef, mat)
        {

        }

        /// <summary>
        /// Calcul de la moyenne d'une UE d'un élève
        /// </summary>
        /// <returns>float : moyenne</returns>
        public float MoyRessource()
        {
            if (matieres.Count == 0)
            {
                throw new ArgumentException("La ressource ne contient aucune matière");
            }
            float total = 0;
            foreach (Matiere mat in matieres)
            {
                total += mat.MoyMatière();
            }
            return total / matieres.Count();
        }

        public override string ToString()
        {
            Console.WriteLine(Num + " ("+Coef+")");
            foreach (Matiere mat in matieres)
            {
                Console.WriteLine(mat);
            }
            return null;
        }



    }
}
