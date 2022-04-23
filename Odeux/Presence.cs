using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odeux
{
    class Presence
    {
        public DateTime dateCour { get; set; }

        public string Matiere { get; set; }

        public int groupe { get; set; }

        public string Salle { get; set; }

        public string Intervenant { get; set; }

        public override string ToString()
        {
            return $"{dateCour}";
        }

    }
}
