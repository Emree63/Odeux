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

namespace OdeuxXaml.User_Control.Prof
{
    /// <summary>
    /// Logique d'interaction pour Accueil_fill_detail.xaml
    /// </summary>
    public partial class Accueil_fill_detail : UserControl
    {
        public Accueil_fill_detail()
        {
            InitializeComponent();

        }
        private void MaMessageBox(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous confirmer la présence de tous vos élèves ?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question);
        }
    }
}
