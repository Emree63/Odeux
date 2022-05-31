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
        /// <summary>
        /// Etudiant actuelle sur lequelle on va récuperer ses informations
        /// </summary>
        public Etudiant EtuActuel { get; set; }

        /// <summary>
        /// Semestre selectionner de l'etudiant actuel
        /// </summary>
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

        /// <summary>
        /// UE selectionner du semestre
        /// </summary>
        public UE EtuUESélectionné
        {
            get => etuUESélectionné;
            set
            {
                if (etuUESélectionné != value)
                {
                    etuUESélectionné = value;
                    OnPropertyChanged("EtuUESélectionné");
                }
            }
        }
        private UE etuUESélectionné;

        /// <summary>
        /// Contenir la moyenne du semestre de l'étudiant
        /// </summary>
        public double EtuMoySemestre
        {
            get => EtumoySemestre;
            set
            {
                if (EtumoySemestre != value)
                {
                    EtumoySemestre = value;
                    OnPropertyChanged("MoySemestre");
                }
            }
        }
        private double EtumoySemestre;

        public double EtuMoyUE
        {
            get => EtumoyUE;
            set
            {
                if (EtumoyUE != value)
                {
                    EtumoyUE = value;
                    OnPropertyChanged("MoySemestre");
                }
            }
        }
        private double EtumoyUE;
    }
}
