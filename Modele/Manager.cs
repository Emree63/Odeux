using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Modele
{
    public partial class Manager
    {

        /// <summary>
        /// Liste des cours dans l'administration
        /// </summary>
        private List<Cour> LesCours; 
        public List<Cour> lescours { get => LesCours; set => LesCours = value; }


        /// <summary>
        /// La classe concernant l'application
        /// </summary>
        public Promo LaPromo { get; private set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="desPersonnes">Liste des personnes</param>
        /// <param name="cours">Listes des cours</param>
        /// <param name="promo">Promo concerner</param>
        public Manager(List<Cour> cours, Promo promo, List<Personne> desPersonnes)
        {
            Personnes.AddRange(desPersonnes);
            LesCours = cours;
            LaPromo = promo;
        }

        public void CreerCour(DateTime date, TimeSpan Duree, string salle, string mat, Professeur ens, List<Groupe> groupes) => LesCours.Add(new Cour(date, Duree, salle, mat, ens, groupes));



    }
}
