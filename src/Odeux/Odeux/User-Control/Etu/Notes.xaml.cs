﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Odeux.User_Control.Etu
{
    /// <summary>
    /// Logique d'interaction pour Notes.xaml
    /// </summary>
    public partial class Notes : UserControl
    {
        int i = 0;
        public Modele.Manager mng => (App.Current as App).LeManager;
        public Notes()
        {
            InitializeComponent();

            mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre1;
            mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            mng.EtuMoySemestre = mng.EtuSemestreSélectionné.MoySemestre();
            mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
            mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
            DataContext = mng;
        }

        private void SemestrePrecedent(object sender, RoutedEventArgs e)
        {
            if (mng.EtuSemestreSélectionné == mng.EtuActuel.Semestre1)
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre2;
            }
            else
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre1;
            }
            mng.EtuMoySemestre = mng.EtuSemestreSélectionné.MoySemestre();
            i = 0;
            mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
            mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
        }

        private void SemestreSuivant(object sender, RoutedEventArgs e)
        {
            if (mng.EtuSemestreSélectionné == mng.EtuActuel.Semestre1)
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre2;
            }
            else
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre1;
            }
            mng.EtuMoySemestre = mng.EtuSemestreSélectionné.MoySemestre();
            i = 0;
            mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
            mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
        }

        private void UeSuivant(object sender, RoutedEventArgs e)
        {
            if (i < mng.EtuSemestreSélectionné.LesUE.Count - 1)
            {
                i++;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
                mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
                mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
            }
            else
            {
                i = 0;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
                mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
                mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
            }
        }

        private void UePrecedent(object sender, RoutedEventArgs e)
        {
            if (i != 0)
            {
                i--;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
                mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
                mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
            }
            else
            {
                i = 5;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
                mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
                mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
            }
        }
    }
}
