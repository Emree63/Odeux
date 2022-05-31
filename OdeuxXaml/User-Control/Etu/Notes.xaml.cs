using System;
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

namespace OdeuxXaml.User_Control.Etu
{
    /// <summary>
    /// Logique d'interaction pour Absence.xaml
    /// </summary>
    public partial class Notes : UserControl
    {
        int i = 0;
        public Modele.Manager mng => (App.Current as App).LeManager;
        public Notes()
        {
            InitializeComponent();

            mng.EtuSemestreSélectionné = mng.EtuActuel.semestre1;
            mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            DataContext = mng;
        }

        private void SemestrePrecedent(object sender, RoutedEventArgs e)
        {
            if(mng.EtuSemestreSélectionné == mng.EtuActuel.semestre1)
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.semestre2;
                i = 0;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            }
            else
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.semestre1;
                i = 0;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            }
        }

        private void SemestreSuivant(object sender, RoutedEventArgs e)
        {
            if (mng.EtuSemestreSélectionné == mng.EtuActuel.semestre1)
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.semestre2;
                i = 0;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            }
            else
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.semestre1;
                i = 0;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            }
        }

        private void UeSuivant(object sender, RoutedEventArgs e)
        {
            if(i<mng.EtuSemestreSélectionné.LesUE.Count-1)
            {
                i++;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            }
            else
            {
                i=0;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            }
            
        }

        private void UePrecedent(object sender, RoutedEventArgs e)
        {
            if (i !=0)
            {
                i--;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            }
            else
            {
                i = 5;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            }
        }
    }
}
