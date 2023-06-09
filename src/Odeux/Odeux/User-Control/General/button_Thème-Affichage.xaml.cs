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

namespace Odeux.User_Control.General
{
    /// <summary>
    /// Logique d'interaction pour button_Thème_Affichage.xaml
    /// </summary>
    public partial class button_Thème_Affichage : UserControl
    {
        public button_Thème_Affichage()
        {
            InitializeComponent();
            Clair.Height = 0;
            Sombre.Height = 22;
            Oled.Height = 0;
        }
        private void Clair_button(object sender, RoutedEventArgs e)
        {
            Clair.Height = 22;
            Sombre.Height = 0;
            Oled.Height = 0;
            Application.Current.Resources["BackgroundColor"] = new SolidColorBrush(Color.FromRgb(235, 249, 254));
            Application.Current.Resources["BackgroundColor2"] = new SolidColorBrush(Color.FromRgb(198, 238, 253));
            Application.Current.Resources["TextColor"] = new SolidColorBrush(Color.FromRgb(2, 27, 34));
            Application.Current.Resources["BackgroundDeco"] = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            Application.Current.Resources["TextDeco"] = new SolidColorBrush(Color.FromRgb(205, 202, 228));
            Application.Current.Resources["BackgroundEdt"] = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            Application.Current.Resources["TextEdt"] = new SolidColorBrush(Color.FromRgb(255, 255, 255));
        }
        private void Sombre_button(object sender, RoutedEventArgs e)
        {
            Clair.Height = 0;
            Sombre.Height = 22;
            Oled.Height = 0;
            Application.Current.Resources["BackgroundColor"] = new SolidColorBrush(Color.FromRgb(3, 50, 67));
            Application.Current.Resources["BackgroundColor2"] = new SolidColorBrush(Color.FromRgb(6, 106, 145));
            Application.Current.Resources["TextColor"] = new SolidColorBrush(Color.FromRgb(241, 251, 254));
            Application.Current.Resources["BackgroundDeco"] = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            Application.Current.Resources["TextDeco"] = new SolidColorBrush(Color.FromRgb(241, 251, 254));
            Application.Current.Resources["BackgroundEdt"] = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Application.Current.Resources["TextEdt"] = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }
        private void Oled_button(object sender, RoutedEventArgs e)
        {
            Clair.Height = 0;
            Sombre.Height = 0;
            Oled.Height = 22;
            Application.Current.Resources["BackgroundColor"] = new SolidColorBrush(Color.FromRgb(0, 0, 0));
            Application.Current.Resources["BackgroundColor2"] = new SolidColorBrush(Color.FromRgb(3, 44, 58));
            Application.Current.Resources["TextColor"] = new SolidColorBrush(Color.FromRgb(241, 251, 254));
            Application.Current.Resources["BackgroundDeco"] = new SolidColorBrush(Color.FromRgb(165, 28, 28));
            Application.Current.Resources["TextDeco"] = new SolidColorBrush(Color.FromRgb(2, 27, 34));
            Application.Current.Resources["BackgroundEdt"] = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            Application.Current.Resources["TextEdt"] = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

    }
}
