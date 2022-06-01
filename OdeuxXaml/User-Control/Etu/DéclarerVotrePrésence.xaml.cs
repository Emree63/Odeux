using Modele;
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
    /// Logique d'interaction pour DéclarerVotrePrésence.xaml
    /// </summary>
    public partial class DéclarerVotrePrésence : UserControl
    {
        public Modele.Manager mng => (App.Current as App).LeManager;
        public DéclarerVotrePrésence()
        {
            InitializeComponent();
            mng.LesAnciensCour = mng.CoursDejaPasser();
            DataContext = mng;
            if (mng.LesAnciensCour.Count() != 0)
                mng.CourSélectionné = mng.LesAnciensCour.First();
            else
                mng.CourSélectionné = null;
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)=> mng.CourSélectionné = e.AddedItems[0] as Cour;
        

        private void Declarer(object sender, RoutedEventArgs e)
        {
            if (mng.CourSélectionné != null)
            {
                mng.SupprimerEtuCour(mng.CourSélectionné);
                mng.LesAnciensCour = mng.CoursDejaPasser();
                if (mng.LesAnciensCour.Count() != 0)
                {
                    mng.CourSélectionné = mng.LesAnciensCour.First();
                }
                else
                {
                    mng.CourSélectionné = null;
                }
            }

        }

    }
}   