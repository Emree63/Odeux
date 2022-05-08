using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    class Etudiant : Personne
    {
        public Etudiant(string nom, string prénom, DateTime naissance, string password) : base(nom,prénom,naissance,password)
        {

        }

    }
}
