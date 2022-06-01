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
    /// Logique d'interaction pour DéclarerVotrePrésence.xaml
    /// </summary>
    public partial class DéclarerVotrePrésence : UserControl
    {
        public Modele.Manager mng => (App.Current as App).LeManager;
        public DéclarerVotrePrésence()
        {
            InitializeComponent();
            mng.LesAnciensCour = mng.CoursDejaPasser();
            DataContext = mng;
        }
    }
}