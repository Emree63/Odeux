using System;
using System.Globalization;
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
using Modele;

namespace OdeuxXaml.User_Control.Etu
{
    /// <summary>
    /// Logique d'interaction pour Edt_Eleve.xaml
    /// </summary>
    public partial class Edt_Eleve : UserControl
    {
        public Modele.Manager mng => (App.Current as App).LeManager;
        public Edt_Eleve()
        {
            InitializeComponent();

            DateSaisie.SelectedDate = DateTime.Now;
            mng.LesCoursDuJour = mng.RechCourEtu(DateSaisie.DisplayDate);
            DataContext = mng;
        }

        private void NouvelDate(object sender, RoutedEventArgs e)
        {
            DateTime d = (DateTime)this.DateSaisie.SelectedDate;
            mng.LesCoursDuJour = mng.RechCourEtu(d);

        }
    }
}
