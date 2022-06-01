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
    /// Interaction logic for Accueil_fill_detail.xaml
    /// </summary>
    public partial class Accueil_fill_detail : UserControl
    {
        public Modele.Manager mng => (App.Current as App).LeManager;
        public Accueil_fill_detail()
        {
            InitializeComponent();

            mng.LesCoursDuJour = mng.RechCourEtu(DateTime.Now);
            DataContext = mng;
            mng.LesAnciensCour = mng.CoursDejaPasser();
        }
        private void MaMessageBox(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Voulez-vous déclarer votre présence à tous les cours pour lesquels vous ne l'avez pas encore fait ?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if(result == MessageBoxResult.Yes)
            {
                mng.SupprimerListeEtuCour(mng.LesAnciensCour);
            }
        }
    }
}
