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

namespace Odeux.User_Control.Etu
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
            mng.CourSélectionné = null;
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = (ListBox)sender;
            var Cour = (Cour)item.SelectedItem;
            if (Cour != null)
            {
                ShowDetail(Cour);
                item.SelectedItem = null;
            }
        }

        private void ShowDetail(Cour cour)
        {
            mng.CourSélectionné = cour;
        }

        private void Declarer(object sender, RoutedEventArgs e)
        {
            if (mng.CourSélectionné != null)
            {
                mng.SupprimerEtuCour(mng.CourSélectionné);
                mng.LesAnciensCour = mng.CoursDejaPasser();
                mng.CourSélectionné = null;

            }

        }

    }
}
