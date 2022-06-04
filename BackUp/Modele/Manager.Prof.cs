using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        /// <summary>
        /// Moyenne General de la promo
        /// </summary>
        public double MoyGeneral { get; private set; }

        public Groupe GroupeSélectionné { get; set; }

    }
}
