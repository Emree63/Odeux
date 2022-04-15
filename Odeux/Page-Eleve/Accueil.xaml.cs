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
using System.Windows.Shapes;
using Odeux.User_Control;

namespace Odeux.Page_Eleve
{
    /// <summary>
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Window
    {
        public Accueil()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous déclarer votre présence à tous les cours pour lesquels vous ne l'avez pas encore fait ?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question);

        }

        private void Declarer_Loaded(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new DéclarerVotrePrésence();
        }
        private void Home(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new User_control.Accueil_fill_detail();
        }

    }
}
