using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public partial class Manager
    {

        /// <summary>
        /// Liste des cours dans l'administration
        /// </summary>
        private List<Cour> LesCours;
        public List<Cour> lescours { get => LesCours; set => LesCours = value; }

        /// <summary>
        /// Ajouter des cours
        /// </summary>
        /// <param name="cours">Liste de cours</param>
        public void AjouterDesCours(List<Cour> cours)
        {
            LesCours.AddRange(cours);
        }


    }
}
