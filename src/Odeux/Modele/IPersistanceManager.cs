using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public interface IPersistanceManager
    {
        (IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut) ChargeDonnées();

        void SauvegardeDonnées(IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut);
    }
}
