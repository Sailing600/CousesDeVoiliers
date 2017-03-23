using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voilier
{
    class Entreprise
    {

        public int id { get; set; }
        public string Nom { get; set; }
        public int VoilierSponsorisé { get; set; }



        public Entreprise()
        {
            this.id = id;
            this.Nom = Nom;
            this.VoilierSponsorisé = VoilierSponsorisé;
        }
    }
}