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

namespace Odeux.User_Control
{
    /// <summary>
    /// Logique d'interaction pour Thème_Affichage.xaml
    /// </summary>
    public partial class Thème_Affichage : UserControl
    {
        public Thème_Affichage()
        {
            InitializeComponent();
            Clair.Height = 0;
            Sombre.Height = 22;
            Oled.Height = 0;
        }
        private void Clair_button(object sender, RoutedEventArgs e)
        {
            Clair.Height = 22;
            Sombre.Height = 0;
            Oled.Height = 0;
        }
        private void Sombre_button(object sender, RoutedEventArgs e)
        {
            Clair.Height = 0;
            Sombre.Height = 22;
            Oled.Height = 0;
        }
        private void Oled_button(object sender, RoutedEventArgs e)
        {
            Clair.Height = 0;
            Sombre.Height = 0;
            Oled.Height = 22;
        }

    }
}
