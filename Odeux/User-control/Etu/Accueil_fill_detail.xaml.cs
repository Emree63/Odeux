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
    /// Interaction logic for Accueil_fill_detail.xaml
    /// </summary>
    public partial class Accueil_fill_detail : UserControl
    {
        public Accueil_fill_detail()
        {
            InitializeComponent();

            List<Cour> LesPresence = new List<Cour>()
            {
                new Cour(new DateTime(2022,03,25,14,30,00),  "R2.01 : Math", "A13", "Marc", 1.5,2,3,4),
                new Cour(new DateTime(2022,03,26,13,30,00),  "R2.04 : Anglais", "B18", "Astier", 1.5,1,3),
                new Cour(new DateTime(2022,03,25,14,30,00),  "R2.01 : Math",  "A13", "Marc", 1.3,1,3),
                new Cour(new DateTime(2022,03,26,13,30,00),  "R2.04 : Anglais",  "B18", "Astier", 2.5,2,3,4),
                new Cour(new DateTime(2022,03,25,14,30,00),  "R2.01 : Math",  "A13", "Marc", 1.3,1,3),
                new Cour(new DateTime(2022,03,26,13,30,00),  "R2.04 : Anglais",  "B18", "Astier", 2.5,2,3,4),
            };

            ListBox_Edt.ItemsSource = LesPresence;
        }
        private void MaMessageBox(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous déclarer votre présence à tous les cours pour lesquels vous ne l'avez pas encore fait ?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question);

        }
    }
}
