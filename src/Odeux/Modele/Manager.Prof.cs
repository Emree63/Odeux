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
        /// La classe concernant l'application.
        /// </summary>
        public Promo LaPromo { get; private set; }


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

    }
}
