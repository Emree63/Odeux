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
        private int Clickedtimes;
        public MainWindow()
        {
            InitializeComponent();
            Clickedtimes = 0;
        }
        private void Prof(object sender, RoutedEventArgs e)
        {
            Accueil_Prof win = new Accueil_Prof(); //Juste pour aller sur l appli du prof
            win.Show();
            this.Close();
        }

        private void Button_Connection(object sender, RoutedEventArgs e)
        {
            Random aleatoire = new Random();
            int entierUnChiffre = aleatoire.Next(3);
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

        List<Point3D> mPositions = new List<Point3D>()
        {
            new Point3D(0.0, 0.0, 0.0),
            new Point3D(1.0, 1.0, 1.0),
            new Point3D(2.0, 0.0, 0.0),
            new Point3D(1.0, -1.0, -1.0),
            new Point3D(0.0, 0.0, 0.0),
            new Point3D(-1.0, -1.0, 1.0),
            new Point3D(-2.0, 0.0, 0.0),
            new Point3D(-1.0, 1.0, -1.0)
        };

        int index;

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var transforms = (mCube.Transform as Transform3DGroup).Children;

            var rotationTransform = transforms.Single(t => t is RotateTransform3D);
            Rotation3DAnimation rotate3DAnimation = new Rotation3DAnimation();
            rotate3DAnimation.From = new AxisAngleRotation3D(new Vector3D(2, 2, 2), 0.0);
            rotate3DAnimation.To = new AxisAngleRotation3D(new Vector3D(2, 2, 2), 190.0);
            rotate3DAnimation.Duration = TimeSpan.FromSeconds(0.5);
            rotate3DAnimation.IsAdditive = true;
            rotationTransform.BeginAnimation(RotateTransform3D.RotationProperty, rotate3DAnimation);

            var translateTransform = transforms.Single(t => t is TranslateTransform3D);
            DoubleAnimation[] translateAnimation = new DoubleAnimation[3];
            translateAnimation[0] = new DoubleAnimation();
            translateAnimation[1] = new DoubleAnimation();
            translateAnimation[2] = new DoubleAnimation();
            translateAnimation[0].From = mPositions[index].X;
            translateAnimation[1].From = mPositions[index].Y;
            translateAnimation[2].From = mPositions[index].Z;
            index++;
            index %= mPositions.Count;
            translateAnimation[0].To = mPositions[index].X;
            translateAnimation[1].To = mPositions[index].Y;
            translateAnimation[2].To = mPositions[index].Z;
            translateAnimation[0].Duration = TimeSpan.FromSeconds(0.5);
            translateAnimation[1].Duration = TimeSpan.FromSeconds(0.5);
            translateAnimation[2].Duration = TimeSpan.FromSeconds(0.5);
            translateTransform.BeginAnimation(TranslateTransform3D.OffsetXProperty, translateAnimation[0]);
            translateTransform.BeginAnimation(TranslateTransform3D.OffsetYProperty, translateAnimation[1]);
            translateTransform.BeginAnimation(TranslateTransform3D.OffsetZProperty, translateAnimation[2]);
            Clickedtimes++;
            MainLabel.Content = Clickedtimes;
            if(Clickedtimes>99)
            {
                MainLabel.Content = "Congratulation";
                Clickedtimes = 0;
            }
        }

        private void Aide(object sender, EventArgs e)
        { 
            System.Diagnostics.Process.Start("https://jira.dsi.uca.fr/plugins/servlet/desk/portal/29");
            this.Close();
        }

    }
}
