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
using System.Windows.Media.Animation;
using System.Windows.Media.Media3D;
using Odeux.Page_Eleve;
using Odeux.Page_Prof;


namespace Odeux
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private static Random MyRandomGenerator = new Random();
        private void Button_Connection(object sender, RoutedEventArgs e)
        {
            int entierUnChiffre = MyRandomGenerator.Next(3);
            Accueil win = new Accueil();
            win.Show();
            this.Close();
            if(entierUnChiffre==1)
                MessageBox.Show("C'est important et ça fait gagner du temps et de l'énergie à tout le monde !","Lisez vos mails tous les jours !", MessageBoxButton.OK, MessageBoxImage.Information,MessageBoxResult.OK);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }


        private void Aide(object sender, EventArgs e)
        { 
            System.Diagnostics.Process.Start("https://jira.dsi.uca.fr/plugins/servlet/desk/portal/29");
            this.Close();
        }

    }
}
