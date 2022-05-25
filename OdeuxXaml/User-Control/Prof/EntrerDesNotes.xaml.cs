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
using System.Windows.Threading;

namespace OdeuxXaml.User_Control.Prof
{
    /// <summary>
    /// Logique d'interaction pour EntrerDesNotes.xaml
    /// </summary>
    public partial class EntrerDesNotes : UserControl
    {
        public EntrerDesNotes()
        {
            InitializeComponent();
        }

        DispatcherTimer dt = new DispatcherTimer();
        private void Valider(object sender, RoutedEventArgs e)
        {
            mProgressBar.Height = 20;
            dt.Tick += dt_Tick;
            dt.Interval = TimeSpan.FromMilliseconds(20);
            dt.Start();
        }

        void dt_Tick(object sender, EventArgs e)
        {
            mProgressBar.Value++;
            if (mProgressBar.Value == mProgressBar.Maximum)
            {
                dt.Stop();
                dt.Interval = TimeSpan.FromMilliseconds(20);
                mProgressBar.Height = 0;
            }
        }


    }
}
