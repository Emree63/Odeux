﻿using System;
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
using Odeux.Page_Eleve;

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

        private void Button_Connection(object sender, RoutedEventArgs e)
        {
            Accueil win = new Accueil();
            win.Show();
            this.Close();
            MessageBox.Show("C'est important et ça fait gagner du temps et de l'énergie à tout le monde !","Lisez vos mails tous les jours !", MessageBoxButton.OK, MessageBoxImage.Information,MessageBoxResult.OK);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
