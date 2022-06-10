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
        /// <summary>
        /// Chemin vers le fichier
        /// </summary>
        public string FilePath => Path.Combine(Directory.GetCurrentDirectory(), RelativePath);

        /// <summary>
        /// Chemin relatif du fichier
        /// </summary>
        public string RelativePath { get; set; } = "..//XML";

        /// <summary>
        /// Nom du fichier
        /// </summary>
        public string FileName { get; set; } = "Odeux.xml";

        /// <summary>
        /// Propriété calculé au chemin d'accées
        /// </summary>
        protected string PersFile => Path.Combine(FilePath, FileName);

        protected XmlObjectSerializer Serializer { get; set; } = new DataContractSerializer(typeof(DataToPersist),
                                                new DataContractSerializerSettings()
                                                {
                                                    PreserveObjectReferences = true
                                                });
        /// <summary>
        /// Récupération de la fontion ChargeDonnées() de IPersistanceManager
        /// </summary>
        /// <returns></returns>
        public (IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut) ChargeDonnées()
        {
            if (!File.Exists(PersFile))
            {
                throw new FileNotFoundException("the persistance file is missing");
            }


            DataToPersist? data;

            using (Stream s = File.OpenRead(PersFile))
            {
                data = Serializer.ReadObject(s) as DataToPersist;
            }
            return (data.Cours, data.Personnes, data.Iut);
        }

        /// <summary>
        /// Implementation de la fontion SauvegardeDonnées() de IPersistanceManager
        /// </summary>
        public virtual void SauvegardeDonnées(IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut)
        {
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            DataToPersist data = new DataToPersist();
            data.Personnes.AddRange(personnes);
            data.Cours.AddRange(cours);
            data.Iut = Iut;

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
