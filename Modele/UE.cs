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

        /// <summary>
        /// Liste des Ressouces dans l'UE
        /// </summary>
        private List<Ressource> ressources;
        public List<Ressource> Res { get => ressources; set => ressources = value; }

        /// <summary>
        /// SAE concernant l'UE
        /// </summary>
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
            sae = null;
            ressources = new List<Ressource>();
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
        /// Ajouter une ressource à la liste des ressources de l'UE
        /// </summary>
        /// <param name="res">Ressource à ajouter</param>
        public void AddRessource(Ressource res)
        {
            ressources.Add(res);
        }

        /// <summary>
        /// Suppresion d'une ressource
        /// </summary>
        /// <param name="res">Resource qu'on veut supprimer</param>
        public void SuppRessource(Ressource res)
        {
            ressources.Remove(res);
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
            if(sae != null)
            {
                total += sae.getNote() * sae.Coef;
                Coef += sae.Coef;
            }
            return total / Coef;
        }

        /// <summary>
        /// Ajouter une SAE à l'UE
        /// </summary>
        /// <param name="sae1">SAE à ajouter</param>
        public void AddSAE(SAE sae1)
        {
            sae = sae1;
        }
        public override string ToString()
        {

            if(Description != null) Console.WriteLine(Num +" - "+ Description +":");
            else Console.WriteLine(Num + ":");
            if (ressources.Count == 0)
            {
                Console.WriteLine("Il n'y a aucune Ressource !");
            }
            foreach (Ressource res in ressources)
            {
                Console.WriteLine("         " +res);
            }
            if (sae != null) Console.WriteLine(sae);
            return null;
        }


    }
}
