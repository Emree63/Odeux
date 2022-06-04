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
    /// Logique d'interaction pour button_AideEnLigne.xaml
    /// </summary>
    public partial class button_AideEnLigne : UserControl
    {
        public button_AideEnLigne()
        {
            InitializeComponent();
        }
        private void Aide(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("https://jira.dsi.uca.fr/plugins/servlet/desk/portal/29");
            var uri = "https://jira.dsi.uca.fr/plugins/servlet/desk/portal/29";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
    }
}
