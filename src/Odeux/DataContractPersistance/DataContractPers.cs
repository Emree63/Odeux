using Modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;

namespace DataContractPersistance
{
    public class DataContractPers : IPersistanceManager
    {
        public string FilePath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "..//XML");

        public string FileName { get; set; } = "Odeux.xml";

        string PersFile => Path.Combine(FilePath, FileName);

        private DataContractSerializer Serializer { get; set; } = new DataContractSerializer(typeof(DataToPersist),
                                                new DataContractSerializerSettings()
                                                {
                                                    PreserveObjectReferences = true
                                                });
        public (IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut) ChargeDonnées()
        {
            if (!File.Exists(PersFile))
            {
                throw new FileNotFoundException("the persistance file is missing");
            }


            DataToPersist data = new DataToPersist();

            using (Stream s = File.OpenRead(PersFile))
            {
                data = Serializer.ReadObject(s) as DataToPersist;
            }
            return (data.Cours, data.Personnes, new Promo(new List<Groupe>()));
        }

        public void SauvegardeDonnées(IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut)
        {
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            DataToPersist data = new DataToPersist();
            data.Personnes.AddRange(personnes);
            data.Cours.AddRange(cours);


            var settings = new XmlWriterSettings() { Indent = true };
            using (TextWriter tw = File.CreateText(PersFile))
            {
                using (XmlWriter writer = XmlWriter.Create(tw, settings))
                {
                    Serializer.WriteObject(writer, data);
                }
            }
        }
    }
}
