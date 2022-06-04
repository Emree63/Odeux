using Modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;

namespace DataContractPersistance
{
    public class DataContractPers : IPersistanceManager
    {
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//XML");

        public string FileName { get; set; } = "Odeux.xml";
        public (IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut) ChargeDonnées()
        {
            throw new NotImplementedException();
        }

        public void SauvegardeDonnées(IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut)
        {
            var serializer = new DataContractSerializer(typeof(IEnumerable<Personne>));

            if(!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            using(Stream s = File.Create(Path.Combine(FilePath, FileName)))
            {
                serializer.WriteObject(s, personnes);
            }
        }
    }
}
