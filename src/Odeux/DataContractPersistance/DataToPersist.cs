using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Modele;


namespace DataContractPersistance
{
    [DataContract]
    class DataToPersist
    {
        [DataMember]
        public List<Personne> Personnes { get; set; } = new List<Personne>();

        [DataMember]
        public List<Cour> Cours { get; set; } = new List<Cour>();

        public Promo Iut { get; set; } = new Promo(new List<Groupe>());
    }
}
