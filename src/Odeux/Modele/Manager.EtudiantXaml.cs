﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public partial class Manager
    {
        /// <summary>
        /// Les nouvelles notes de l'élève.
        /// </summary>
        public List<Note> NouvelNote { get; set; }

        /// <summary>
        /// Etudiant actuel sur lequel on va récupérer ses informations
        /// </summary>
        public Etudiant EtuActuel
        {
            get => Etuactuel;
            set
            {
                if (Etuactuel != value)
                {
                    Etuactuel = value;
                    OnPropertyChanged("Etuactuel");
                }
            }
        }
        private Etudiant Etuactuel;

        /// <summary>
        /// Semestre sélectionné de l'étudiant actuel
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
        /// UE sélectionnée du semestre
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
        /// Contient la moyenne du semestre de l'étudiant
        /// </summary>
        public double EtuMoySemestre
        {
            get => EtumoySemestre;
            set
            {
                if (EtumoySemestre != value)
                {
                    EtumoySemestre = value;
                    OnPropertyChanged("EtumoySemestre");
                }
            }
        }
        private double EtumoySemestre;

        /// <summary>
        /// Contenir la moyenne de l'UE sélectionnée de l'étudiant
        /// </summary>
        public double EtuMoyUE
        {
            get => EtumoyUE;
            set
            {
                if (EtumoyUE != value)
                {
                    EtumoyUE = value;
                    OnPropertyChanged("EtuMoyUE");
                }
            }
        }
        private double EtumoyUE;

        /// <summary>
        /// Variable qui va contenir la moyenne générale de la promo pour le XAML
        /// </summary>
        public double MoyGeneral { get; private set; }

        /// <summary>
        /// Va contenir la moyenne de l'UE de la classe (Ensemble des élèves)
        /// </summary>
        public double MoyUE
        {
            get => moyUE;
            set
            {
                if (moyUE != value)
                {
                    moyUE = value;
                    OnPropertyChanged("MoyUE");
                }
            }
        }
        private double moyUE;

        /// <summary>
        /// Va prendre la matière choisie par le professeur
        /// </summary>
        public Matiere EtuMat
        {
            get => Etumat;
            set
            {
                if (Etumat != value)
                {
                    Etumat = value;
                    OnPropertyChanged("EtuMat");
                }
            }
        }
        private Matiere Etumat;

        /// <summary>
        /// Va prendre la matière choisie par le professeur
        /// </summary>
        public Ressource EtuRes
        {
            get => Etures;
            set
            {
                if (Etures != value)
                {
                    Etures = value;
                    OnPropertyChanged("EtuRes");
                }
            }
        }
        private Ressource Etures;
    }
}
