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

        public Groupe GroupeSélectionné { get; set; }

    }
}
