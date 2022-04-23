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
    /// Logique d'interaction pour DéclarerVotrePrésence.xaml
    /// </summary>
    public partial class DéclarerVotrePrésence : UserControl
    {
        public DéclarerVotrePrésence()
        {
            InitializeComponent();

            List<Presence> LesPresence = new List<Presence>()
            {
                new Presence{date = new DateTime(2022,03,25), Matiere = "Math", groupe=3, Salle="A13", Intervenant = "Marc"},
                new Presence{date = new DateTime(2022,03,26), Matiere = "Anglais", groupe=3, Salle="B18", Intervenant = "Astier"},
            };

            ListBox.ItemsSource = LesPresence;
        }
    }
}
