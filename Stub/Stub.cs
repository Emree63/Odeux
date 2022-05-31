using System;
using System.Collections.Generic;
using Modele;

namespace Stub
{
    public class Stub : IPersistanceManager
    {
        public (IEnumerable<Cour> cours, IEnumerable<Personne> personnes) ChargeDonnées()
        {
            throw new NotImplementedException();
        }

        public void SauvegardedeDonnées(IEnumerable<Cour> cours, IEnumerable<Personne> personnes)
        {
            throw new NotImplementedException();
        }
    }
}
