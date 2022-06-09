using System;
using static Modele.Note;
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
using Modele;

namespace Odeux.User_Control.Prof
{
    /// <summary>
    /// Logique d'interaction pour EntrerDesNotes.xaml
    /// </summary>
    public partial class EntrerDesNotes : UserControl
    {
        int i = 0, y = 0;
        public Modele.Manager mng => (App.Current as App).LeManager;

        public EntrerDesNotes()
        {
            InitializeComponent();

            mng.GroupeSélectionné = mng.LaPromo.Groupes[y];
            mng.EtuActuel = mng.GroupeSélectionné.etudiants[0];
            mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre1;
            mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            mng.EtuRes = mng.EtuUESélectionné.Ressources[0];
            mng.EtuMat = mng.EtuRes.Matieres[0];
            mng.EtuMoySemestre = mng.EtuSemestreSélectionné.MoySemestre();
            mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
            mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
            DataContext = mng;

        }


        private void SemestrePrecedent(object sender, RoutedEventArgs e)
        {
            if (mng.EtuSemestreSélectionné == mng.EtuActuel.Semestre1)
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre2;
            }
            else
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre1;
            }
            mng.EtuMoySemestre = mng.EtuSemestreSélectionné.MoySemestre();
            i = 0;
            mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
            mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
        }

        private void SemestreSuivant(object sender, RoutedEventArgs e)
        {
            if (mng.EtuSemestreSélectionné == mng.EtuActuel.Semestre1)
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre2;
            }
            else
            {
                mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre1;
            }
            mng.EtuMoySemestre = mng.EtuSemestreSélectionné.MoySemestre();
            i = 0;
            mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
            mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
        }

        private void UeSuivant(object sender, RoutedEventArgs e)
        {
            if (i < mng.EtuSemestreSélectionné.LesUE.Count - 1)
            {
                i++;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
                mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
                mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
            }
            else
            {
                i = 0;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
                mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
                mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
            }
        }

        private void UePrecedent(object sender, RoutedEventArgs e)
        {
            if (i != 0)
            {
                i--;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
                mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
                mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
            }
            else
            {
                i = 5;
                mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
                mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
                mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
            }
        }

        private void GroupePrecedent(object sender, RoutedEventArgs e)
        {

            if (y != 0)
            {
                y--;
                mng.GroupeSélectionné = mng.LaPromo.Groupes[y];
            }
            else
            {
                y = mng.LaPromo.Groupes.Count() - 1;
                mng.GroupeSélectionné = mng.LaPromo.Groupes[y];
            }
            mng.EtuActuel = mng.GroupeSélectionné.etudiants[0];
            mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre1;
            mng.EtuMoySemestre = mng.EtuSemestreSélectionné.MoySemestre();
            i = 0;
            mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
            mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Refresh(object sender, RoutedEventArgs e)
        {
            mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre1;
            mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            mng.EtuMoySemestre = mng.EtuSemestreSélectionné.MoySemestre();
            mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
            mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
        }

        private void GroupeSuivant(object sender, RoutedEventArgs e)
        {
            if (y < mng.LaPromo.Groupes.Count() - 1)
            {
                y++;
                mng.GroupeSélectionné = mng.LaPromo.Groupes[y];

            }
            else
            {
                y = 0;
                mng.GroupeSélectionné = mng.LaPromo.Groupes[y];
            }
            mng.EtuActuel = mng.GroupeSélectionné.etudiants[0];
            mng.EtuSemestreSélectionné = mng.EtuActuel.Semestre1;
            mng.EtuMoySemestre = mng.EtuSemestreSélectionné.MoySemestre();
            i = 0;
            mng.EtuUESélectionné = mng.EtuSemestreSélectionné.LesUE[i];
            mng.EtuMoyUE = mng.EtuUESélectionné.MoyUE();
            mng.MoyUE = mng.LaPromo.MoyUE(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num);
        }

        DispatcherTimer dt = new DispatcherTimer();

        private void Valider(object sender, RoutedEventArgs e)
        {
            string nom = NewNom.Text;
            double note;
            if (Double.TryParse(NewNote.Text, out note))
            {

                if (!string.IsNullOrWhiteSpace(nom))
                {
                    if (note >= 0 && note <= 20)
                    {
                        Note n= new (nom, note);
                        mProgressBar.Foreground = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
                        mng.profActuel.EntrerNote(mng.EtuSemestreSélectionné.NumSemestre, mng.EtuUESélectionné.Num, mng.EtuRes.Num, mng.EtuMat, mng.EtuActuel, n);
                        mng.LaPromo.NouvelNote.Add(n, mng.EtuActuel.Nom);
                    }
                    else
                        mProgressBar.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                }
                else
                {
                    mProgressBar.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                }
            }
            else
            {
                mProgressBar.Foreground = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
            }
            mProgressBar.Value = 0;
            mProgressBar.Height = 20;
            dt.Tick += dt_Tick;
            dt.Interval = TimeSpan.FromMilliseconds(20);
            dt.Start();
            
        }

        private void NewNote_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            NewNote.Text = "";
        }

        private void NewNom_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            NewNom.Text = "";
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
