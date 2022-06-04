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

namespace Odeux.User_Control.General
{
    /// <summary>
    /// Logique d'interaction pour button_Deconnexion.xaml
    /// </summary>
    public partial class button_Deconnexion : UserControl
    {
        public button_Deconnexion()
        {
            InitializeComponent();
        }

        public event RoutedEventHandler ClickMenu;
        private void Deco(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Deconnexion", "Voulez-vous vraiment vous déconnecter", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Odeux.LoginPage win = new Odeux.LoginPage();
                win.Show();
                if (ClickMenu != null)
                {
                    ClickMenu(this, e);
                }
            }
        }
    }
}
