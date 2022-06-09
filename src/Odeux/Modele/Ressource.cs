using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    public class Ressource
    {
        /// <summary>
        /// Numéro de la Ressource
        /// </summary>
        private string num;
        [DataMember]
        public string Num { get => num; set => num = value; }

        /// <summary>
        /// Description détailler de la Ressource
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Coefficient de la Ressource
        /// </summary>
        [DataMember]
        public int Coef { get; set; }

        /// <summary>
        /// Liste des Matières dans une Ressource
        /// </summary>
        [DataMember]
        public List<Matiere> Matieres { get; set; }

        /// <summary>
        /// Cette variable n'est là que pour stocker le résultat de l'opération MoyRessource
        /// </summary>
        [DataMember]
        public double MoyRes { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="num">Numéro de la nouvelle Ressource</param>
        /// <param name="description">(Optionnel :) Description de la nouvelle Ressource</param>
        /// <param name="coef">Coefficient de la nouvelle Ressource</param>
        /// <param name="mat">Liste des matières</param>
        public Ressource(string num, string description, int coef, List<Matiere> mat)
        {
            if (string.IsNullOrWhiteSpace(num))
            {
                throw new ArgumentException("Le numéro de la Ressource doit être fournie");
            }
            if (coef < 0)
            {
                throw new ArgumentException("Le coefficient ne peut pas être égale ou inférieur à zéro");
            }
            this.num = num;
            Description = description;
            Coef = coef;
            Matieres = mat;
            MoyRes = MoyRessource();
        }

        /// <summary>
        /// Constructeur sans Description
        /// </summary>
        /// <param name="num">Numéro de la nouvelle Ressource</param>
        /// <param name="coef">Coefficient de la nouvelle Ressource</param>
        /// <param name="mat">Listes des matières</param>
        public Ressource(string num, int coef, List<Matiere> mat) : this(num, "Aucune Description", coef, mat)
        { }

        /// <summary>
        /// Calcul de la moyenne d'une UE d'un élève
        /// </summary>
        /// <returns>Float : moyenne</returns>
        public double MoyRessource()
        {
            MoyRes = -1;
            if (Matieres.Count() == 0) return MoyRes; //Si il n'y a pas de matières dans la ressource on retourne -1

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
            if (c != 0) //Si on n'a pas obtenu de moyenne dans la matière on return -1 
            {
                MoyRes = Math.Round(total / c,2);
                return MoyRes;
            }
            else
                return -1;

        }

        /// <summary>
        /// Ajouter une nouvel matière à la Ressource.
        /// </summary>
        /// <param name="Mat">Nouvelle Matière</param>
        public void AddMatiere(Matiere Mat) => Matieres.Add(Mat);


        /// <summary>
        ///  Matière qu'on veut supprimer.
        /// </summary>
        /// <param name="Mat">Matière à supprimer</param>
        public void SuppMatiere(Matiere Mat) => Matieres.Remove(Mat);

        public override string ToString()
        {
            Console.WriteLine(num + " ( Coef " + Coef + ") :");
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
