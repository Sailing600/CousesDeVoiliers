using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voilier
{
    class VoilierInscrit
    {

        public int ID { get; set; }
        public int NumeroDeVoile { get; set; }
        public string NomEquipe { get; set; }
        public string NomDeLaCourse { get; set; }
        public List<string> Sponsor { get; set; }



        public VoilierInscrit(int id, int numeroVoile, string NomEquipe, string NomCourse, List<string> Sponsor)
        {
            this.ID = ID;
            this.NumeroDeVoile = numeroVoile;
            this.NomEquipe = NomEquipe;
            this.NomDeLaCourse = NomDeLaCourse;
            this.Sponsor = Sponsor;
        }
    }
}