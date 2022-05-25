using System;
using System.Globalization;
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
    /// Logique d'interaction pour Edt_Eleve.xaml
    /// </summary>
    public partial class Edt_Eleve : UserControl
    {
        public Edt_Eleve()
        {
            InitializeComponent();

            mCalendar.DisplayDateStart = DateTime.Now;

            /*int D = CultureInfo.CurrentCulture.Calendar.GetWeekOfYear;*/
        }
    }
}
