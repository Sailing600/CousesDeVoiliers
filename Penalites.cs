using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voilier
{
    enum penalite
    {

        NonRespectBouee,
        ToucheUneBouee,
        RefusPrioriteConcurrent,
        DepartAnticiper,
        UtilisationMoteur,
        AideExterieur,
        RejetDetritus

    }
    class penalites
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string TempsPrecis { get; set; }
        public penalite pen { get; set; }



        public penalites()
        {
            this.ID = ID;
            this.Code = Code;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.TempsPrecis = TempsPrecis;
            this.pen = pen;
        }

    }
}
