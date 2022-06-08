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
        /// Liste des cours du Jour d'une personne
        /// </summary>
        private IEnumerable<Cour> LesCoursduJour;
        public IEnumerable<Cour> LesCoursDuJour
        {
            get => LesCoursduJour;
            set
            {
                if (LesCoursDuJour != value)
                {
                    LesCoursduJour = value;
                    OnPropertyChanged("LesCoursduJour");
                }
            }
        }

        /// <summary>
        /// Liste des anciens non déclare de l'élève
        /// </summary>
        private IEnumerable<Cour> lesAnciensCour;
        public IEnumerable<Cour> LesAnciensCour
        {
            get => lesAnciensCour;
            set
            {
                if (lesAnciensCour != value)
                {
                    lesAnciensCour = value;
                    OnPropertyChanged("LesAnciensCour");
                }
            }
        }

        private Cour courSélectionné;
        public Cour CourSélectionné
        {
            get => courSélectionné;
            set
            {
                if (courSélectionné != value)
                {
                    courSélectionné = value;
                    OnPropertyChanged("courSélectionné");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}
