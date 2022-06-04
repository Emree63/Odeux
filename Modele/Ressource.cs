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
        private string num;
        public string Num { get => num; set => num = value; }

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
        public List<Matiere> Matieres { get; set; }


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="num">Numéro de la nouvelle Ressource</param>
        /// <param name="description">(Optionnel :) Description de la nouvelle Ressource</param>
        /// <param name="coef">Coefficient de la nouvelle Ressource</param>
        /// <param name="mat">Listes des matieres</param>
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
            this.num = num;
            Description = description;
            Coef = coef;
            Matieres = mat;
        }

        /// <summary>
        /// Constructeur sans Description
        /// </summary>
        /// <param name="num">Numéro de la nouvelle Ressource</param>
        /// <param name="coef">Coefficient de la nouvelle Ressource</param>
        /// <param name="mat">Listes des matieres</param>
        public Ressource(string num, int coef, List<Matiere> mat) : this(num,"Aucune Description",coef, mat)
        { }

        /// <summary>
        /// Calcul de la moyenne d'une UE d'un élève
        /// </summary>
        /// <returns>float : moyenne</returns>
        public double MoyRessource()
        {
            if (Matieres.Count == 0) return -1; //Si il n'y a pas de matières dans la ressource on retourne -1
            
            double total = 0;
            int c = 0;
            foreach (Matiere mat in Matieres)
            {
                if (mat.MoyMatière() != -1)
                {
                    total += mat.MoyMatière();
                    c++;
                }
            }
            if(c!=0) //Si on a pas obtenu de moyenne dans la matière on return -1 
                return total / c;
            else
                return -1;
           
        }

        /// <summary>
        /// Ajouter une nouvel matiere à la Ressource.
        /// </summary>
        /// <param name="Mat">Nouvelle Matière</param>
        public void AddMatiere(Matiere Mat) => Matieres.Add(Mat);
        

        /// <summary>
        ///  Matiere qu'on veut supprimer.
        /// </summary>
        /// <param name="Mat">Matiere à supprimer</param>
        public void SuppMatiere(Matiere Mat) => Matieres.Remove(Mat);

        public override string ToString()
        {
            Console.WriteLine(num + " ( Coef "+Coef+") :");
            if (Matieres.Count == 0)
            {
                Console.WriteLine("Aucune Matière n'est encore dans la Ressource !");
            }
            foreach (Matiere mat in Matieres)
            {
                Console.WriteLine(mat);
            }
            return null;
        }



    }
}
