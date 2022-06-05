using Modele;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DataContractPersistance
{
    public class DataContractPersJSON : DataContractPers
    {
        public DataContractPersJSON()
        {
            RelativePath = "..//JSON";
            FileName = "Odeux.json";
            Serializer
                = new DataContractJsonSerializer(typeof(DataToPersist));
        }

        public override void SauvegardeDonnées(IEnumerable<Cour> cours, IEnumerable<Personne> personnes, Promo Iut)
        {
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
            }

            DataToPersist data = new DataToPersist();
            data.Personnes.AddRange(personnes);
            data.Cours.AddRange(cours);
            data.Iut = Iut;


            using (Stream writer = File.Create(PersFile))
            {
                Serializer.WriteObject(writer, data);
            }
            
        }
    }
}
