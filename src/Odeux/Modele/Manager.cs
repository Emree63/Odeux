using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        /// <summary>
        /// Creer un nouveau cour et l'ajoute à la liste des cours
        /// </summary>
        /// <param name="date">Date du cour</param>
        /// <param name="Duree">Duree du cour</param>
        /// <param name="Salle">Salle où à lieu </param>
        /// <param name="mat">Matière qui à lieu</param>
        /// <param name="ens">Enseignant charger de s'occuper du cour</param>
        /// <param name="groupes">Les groupes d'élèves à qui sont assigner les cours.</param>
        public void CreerCour(DateTime date, TimeSpan Duree, string Salle, string mat, Professeur ens, List<Groupe> groupes) => LesCours.Add(new Cour(date, Duree, Salle, mat, ens, groupes));

        public void ChargeDonnées()
        {
            List<Personne> per = new List<Personne>();
            var données = Persistance.ChargeDonnées();
            foreach (var j in données.cours)
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
            MoyGeneral = LaPromo.MoyGeneral()*2;
        }

        public void SauvegardeDonnées()
        {
            Persistance.SauvegardeDonnées(LesCours, Personnes, LaPromo);
        }

    }
}
