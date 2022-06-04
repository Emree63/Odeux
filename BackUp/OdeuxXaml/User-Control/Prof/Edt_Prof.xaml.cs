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
    /// Logique d'interaction pour Edt_Prof.xaml
    /// </summary>
    public partial class Edt_Prof : UserControl
    {
        public Modele.Manager mng => (App.Current as App).LeManager;
        public Edt_Prof()
        {
            InitializeComponent();

            DateSaisie.SelectedDate = DateTime.Now;
            mng.LesCoursDuJour = mng.RechCourProf(DateSaisie.DisplayDate);
            DataContext = mng;
        }

        private void NouvelDate(object sender, RoutedEventArgs e)
        {
            DateTime d = (DateTime)this.DateSaisie.SelectedDate;
            mng.LesCoursDuJour = mng.RechCourProf(d);

        }
    }
}
