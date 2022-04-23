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

            List<Cour> LesPresence = new List<Cour>()
            {
                new Cour{dateCour = new DateTime(2022,03,25), Matiere = "R2.01 : Math", groupe=3, Salle="A13", Intervenant = "Marc"},
                new Cour{dateCour = new DateTime(2022,03,26), Matiere = "R2.04 : Anglais", groupe=3, Salle="B18", Intervenant = "Astier"},
                new Cour{dateCour = new DateTime(2022,03,25), Matiere = "R2.01 : Math", groupe=3, Salle="A13", Intervenant = "Marc"},
                new Cour{dateCour = new DateTime(2022,03,26), Matiere = "R2.04 : Anglais", groupe=3, Salle="B18", Intervenant = "Astier"},
            };

            ListBox.ItemsSource = LesPresence;
        }
    }
}
