using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Modele
{
    public partial class Manager : INotifyPropertyChanged
    {
        /// <summary>
        /// Dépendance vers le gestionnaire de la persistance
        /// </summary>
        public IPersistanceManager Persistance { get; /*private*/ set; }

        /// <summary>
        /// Constructeur de la classe Manager.
        /// </summary>
        public Manager(IPersistanceManager persistance)
        {
            Persistance = persistance;
            Personnes = new List<Personne>();
            LesCours = new List<Cour>();
            LaPromo = new Promo(new List<Groupe>());
        }

        /// <summary>
        /// Récuperer une nouvelPromo
        /// </summary>
        /// <param name="promo"></param>
        public void NouvelPromo(Promo promo)
        {
            LaPromo = promo;
        }

        public void CreerCour(DateTime date, TimeSpan Duree, string salle, string mat, Professeur ens, List<Groupe> groupes) => LesCours.Add(new Cour(date, Duree, salle, mat, ens, groupes));

        public void ChargeDonnées()
        {
            List<Personne> per = new List<Personne>();
            var données = Persistance.ChargeDonnées();
            foreach(var j in données.cours)
            {
                LesCours.Add(j);
            }
            foreach (var p in données.personnes)
            {
                per.Add(p);
            }
            AjouterPersonne(per);
            LaPromo = données.Iut;
            GroupeSélectionné = LaPromo.Groupes[0];
            MoyGeneral = LaPromo.MoyGeneral();
        }

        public void SauvegardeDonnées()
        {
            Persistance.SauvegardeDonnées(LesCours,Personnes,LaPromo);
        }


    }
}
