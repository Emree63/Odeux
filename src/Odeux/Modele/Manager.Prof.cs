using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public partial class Manager
    {
        /// <summary>
        /// La promo concernant l'application
        /// </summary>
        public Promo LaPromo { get; private set; }


        /// <summary>
        /// Groupe d'étudiant dans la promo qui est sélectionner dans l'application
        /// </summary>
        private Groupe Groupesélectionné;
        public Groupe GroupeSélectionné
        {
            get => Groupesélectionné;
            set
            {
                if (Groupesélectionné != value)
                {
                    Groupesélectionné = value;
                    OnPropertyChanged("Groupesélectionné");
                }
            }
        }

        /// <summary>
        /// Prof actuellement sur l'application
        /// </summary>
        public Professeur profActuel { get; set; }

    }
}
