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
using System.Windows.Shapes;

namespace Odeux
{
    /// <summary>
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : Window
    {
        public Accueil()
        {
            InitializeComponent();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           MessageBoxResult result = MessageBox.Show("Voulez-vous déclarer votre présence à tous les cours pour lesquels vous ne l'avez pas encore fait ?", " ", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
        }

    }
}