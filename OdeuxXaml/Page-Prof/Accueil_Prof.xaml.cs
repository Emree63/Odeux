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
using OdeuxXaml.User_Control.General;
using OdeuxXaml.User_Control.Prof;

namespace OdeuxXaml.Page_Prof
{
    /// <summary>
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil_Prof : Window
    {
        public Accueil_Prof()
        {
            InitializeComponent();
        }
        private void Home(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Accueil_fill_detail();
        }


        private void Der_Infos(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Der_Infos();
        }

        private void Edt(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Edt_Prof();
        }
        private void Consulter(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new ConsulterNotes();
        }

        private void Button_Notes(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new EntrerDesNotes();
        }
        private void Deco(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
