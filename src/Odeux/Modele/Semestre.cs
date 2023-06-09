﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    public class Semestre
    {
        /// <summary>
        /// Numéro du Semestre
        /// </summary>
        [DataMember]
        public int NumSemestre { get; set; }

        /// <summary>
        /// Liste des UE du Semestre
        /// </summary>
        [DataMember]
        public List<UE> LesUE { get; set; }


        /// <summary>
        /// Constructeur d'un Semestre
        /// </summary>
        /// <param name="num">numéro du Semestre</param>
        /// <param name="ue">Liste des UE lors de sa construction</param>
        public Semestre(int num, List<UE> ue)
        {
            if (num < 0) throw new ArgumentException("Veuillez entrer un numéro positif !");
            NumSemestre = num;
            LesUE = ue;
        }

        /// <summary>
        /// Ajouter une UE
        /// </summary>
        /// <param name="ue">UE concerner</param>
        public void AddUE(UE ue) => LesUE.Add(ue);


        /// <summary>
        /// Supprimer une UE de la liste 
        /// </summary>
        /// <param name="ue">UE concerner</param>
        public void SuppUE(UE ue) => LesUE.Remove(ue);

        public override string ToString()
        {
            Console.WriteLine("Semestre " + NumSemestre);
            foreach (UE ue in LesUE)
            {
                Console.WriteLine(ue);
            }
            return null;
        }

        /// <summary>
        /// Moyenne du Semestre sur toute ses UE
        /// </summary>
        /// <returns>double : Moyenne du Semestre</returns>
        public double MoySemestre()
        {
            if (LesUE.Count == 0)
            {
                return -1;
            }
            double total = 0;
            int Coef = 0;
            foreach (UE ue in LesUE)
            {
                if (ue.MoyUE() != -1)
                {
                    total += ue.MoyUE();
                    Coef++;
                }
            }
            if (Coef != 0)
                return Math.Round(total / Coef, 2);
            else
                return -1;
        }
    }
}
