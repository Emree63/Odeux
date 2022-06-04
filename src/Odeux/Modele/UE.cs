using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    public class UE
    {
        /// <summary>
        /// Code de l'UE
        /// </summary>
        [DataMember]
        public string Num { get => num; set => num = value; }
        private string num;

        /// <summary>
        /// Description des éléments l'UE 
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Liste des Ressouces dans l'UE
        /// </summary>
        [DataMember]
        public List<Ressource> Ressources { get; set; }

        /// <summary>
        /// SAE concernant l'UE
        /// </summary>
        [DataMember]
        public SAE sae;

        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="num">Code de l'UE</param>
        /// <param name="Des">Description de l'UE</param>
        public UE(string num, string Des)
        {
            if (string.IsNullOrWhiteSpace(num)) throw new ArgumentException("Le nom doit être renseigner");
            this.num = num;
            Description = Des;
            sae = null;
            Ressources = new List<Ressource>();
        }

        /// <summary>
        /// Constructeur sans Description renseigner
        /// </summary>
        /// <param name="num">Code de l'UE</param>
        public UE(string num) : this(num, null)
        {

        }

        /// <summary>
        /// Ajouter une ressource à la liste des ressources de l'UE
        /// </summary>
        /// <param name="res">Ressource à ajouter</param>
        public void AddRessource(Ressource res) => Ressources.Add(res);

        /// <summary>
        /// Ajouter une liste de ressource à l'UE
        /// </summary>
        /// <param name="res">Liste des ressources</param>
        public void AddListesRessources(List<Ressource> res) => Ressources.AddRange(res);

        /// <summary>
        /// Suppresion d'une ressource
        /// </summary>
        /// <param name="res">Resource qu'on veut supprimer</param>
        public void SuppRessource(Ressource res) => Ressources.Remove(res);


        /// <summary>
        /// Calcule la Moyenne d'une UE sur l'ensemble de ses Ressources
        /// </summary>
        /// <returns>double : Moyenne Total de l'UE</returns>
        public double MoyUE()
        {
            if (Ressources.Count == 0) return -1;

            double total = 0;
            int Coef = 0;
            foreach (Ressource res in Ressources)
            {
                if (res.MoyRessource() != -1)
                {
                    total += res.MoyRessource() * res.Coef;
                    Coef += res.Coef;
                }
            }
            if (sae != null)
            {
                total += sae.getNote() * sae.Coef;
                Coef += sae.Coef;
            }
            if (Coef != 0)
                return total / Coef;
            else
                return -1;
        }

        /// <summary>
        /// Ajouter une SAE à l'UE
        /// </summary>
        /// <param name="sae1">SAE à ajouter</param>
        public void AddSAE(SAE sae1) => sae = sae1;

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(Description)) Console.WriteLine(num + " - " + Description + ":");
            else Console.WriteLine(num + ":");
            if (Ressources.Count == 0)
            {
                Console.WriteLine("Il n'y a aucune Ressource !");
            }
            foreach (Ressource res in Ressources)
            {
                Console.WriteLine("         " + res);
            }
            if (sae != null) Console.WriteLine(sae);
            return null;
        }
    }
}
