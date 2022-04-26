using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odeux
{
    class Cour
    {
        public DateTime DateCour { get; set; }

        public string Matiere { get; set; }
        
        public List<int> Groupe { get; set; }

        public string Salle { get; set; }

        public string Intervenant { get; set; }

        public double Duree { get; set; }

        public DateTime DateCourFin { get; set; }

        public Cour(DateTime DateCour, string Matiere, string Salle, string Intervenant, double Duree, int nbGroupe, int Groupe1)
        {
            this.DateCour = DateCour;
            this.Matiere = Matiere;
            this.Groupe = new List<int>(nbGroupe);
            this.Groupe.Add(Groupe1);


            this.Salle = Salle;
            this.Intervenant = Intervenant;
            this.Duree = Duree;
            this.DateCourFin = DateCour.AddHours(Duree);
        }

        public Cour(DateTime DateCour, string Matiere, string Salle, string Intervenant, double Duree,int nbGroupe, int Groupe1, int Groupe2)
        {
            this.DateCour = DateCour;
            this.Matiere = Matiere;
            this.Groupe = new List<int>(nbGroupe);
            this.Groupe.Add(Groupe1);
            this.Groupe.Add(Groupe2);


            this.Salle = Salle;
            this.Intervenant = Intervenant;
            this.Duree = Duree;
            this.DateCourFin = DateCour.AddHours(Duree);
        }
   
        public override string ToString()
        {
            return $"{DateCour.Year}";
        }



    }
}
