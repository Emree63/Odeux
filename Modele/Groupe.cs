using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class Groupe
    {
        private int Num;
        public int num { get => Num; set => Num = value; }

        private List<Etudiant> étudiants;
        public List<Etudiant> etudiants { get => étudiants; set => étudiants = value; }
        
        public double MinNote()
        {
            double pireNote;
            
        }
    }
}
