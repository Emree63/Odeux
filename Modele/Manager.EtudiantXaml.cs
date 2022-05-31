using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public partial class Manager 
    {
        public Etudiant EtuActuel { get; set; }

        public Semestre EtuSemestreSélectionné
        {
            get => etuSemestreSélectionné;
            set
            {
                if (etuSemestreSélectionné != value)
                {
                    etuSemestreSélectionné = value;
                    OnPropertyChanged("EtuSemestreSélectionné");
                }
            }
        }
        private Semestre etuSemestreSélectionné;

    }
}
