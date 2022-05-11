using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class UE
    {
        /// <summary>
        /// Numéro du Semestre
        /// </summary>
        private int Semestre;
        public int semestre { get => Semestre; set => Semestre = value; }

        /// <summary>
        /// Code de l'UE
        /// </summary>
        private string Num;
        public string num { get => Num; set => Num = value; }

        /// <summary>
        /// Description des éléments l'UE 
        /// </summary>
        public string Description { get; set; }

        private List<Ressource> ressources;
        public List<Ressource> Res { get => ressources;  }

        public SAE sae;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="semestre"> Semestre de l'UE</param>
        /// <param name="num">Code de l'UE</param>
        /// <param name="Des">Description de l'UE</param>
        public UE(int semestre, string num, string Des)
        {
            Semestre = semestre;
            Num = num;
            Description = Des;
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="semestre"> Semestre de l'UE</param>
        /// <param name="num">Code de l'UE</param>
        public UE(int semestre, string num): this(semestre,num,null)
        {

        }

        /// <summary>
        /// Calcule la Moyenne d'une UE sur l'ensemble de ses Ressources
        /// </summary>
        /// <returns>double : Moyenne Total de l'UE</returns>
        public double MoyUE()
        {
            if (ressources.Count == 0)
            {
                throw new ArgumentException("L'UE ne contient aucune Ressource");
            }
            double total = 0;
            int Coef = 0;
            foreach (Ressource res in ressources)
            {
                total += res.MoyRessource()*res.Coef;
                Coef += res.Coef;
            }
            return total / Coef;
        }

        public override string ToString()
        {
            if(Description != null) Console.WriteLine(Num + Description +":");
            else Console.WriteLine(Num + ":");
            if (ressources.Count == 0)
            {
                Console.WriteLine("Il n'y a aucune Ressource !");
            }
            foreach (Ressource res in ressources)
            {
                Console.WriteLine("         " +res);
            }
            return null;
        }

    }
}
