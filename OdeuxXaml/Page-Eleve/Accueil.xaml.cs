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
using System.Windows.Navigation;
using OdeuxXaml.User_Control.General;
using OdeuxXaml.User_Control.Etu;

namespace OdeuxXaml.Page_Eleve
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

        private void Declarer_Loaded(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new DéclarerVotrePrésence();
        }
        private void Home(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Accueil_fill_detail();
        }

        private void Der_Infos(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Der_Infos();
        }
        private void Button_edt(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Edt_Eleve();
        }
        private void Consulter(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Notes();
        }
        private void Deco(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Deconnexion_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
