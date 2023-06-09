﻿using DataContractPersistance;
using Modele;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Odeux
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Manager LeManager { get; private set; } = new Manager(new DataContractPersJSON());

        public App()
        {
            LeManager.ChargeDonnées();
            Exit += ApplicationExit;
        }

        private void ApplicationExit(object sender, ExitEventArgs e)
        {
            LeManager.SauvegardeDonnées();
        }
    }
}
