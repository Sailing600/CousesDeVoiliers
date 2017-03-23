using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voilier
{
    enum TypeVoilier
    {

        Caravelle,
        Class40,
        Dragon,
        Elliott6M,
        Mousse,
        Mousquetaire,
        Micro,
        Swallow
    }

    class Voilier
    {

        public int ID { get; set; }
        public string NuméroDeSerie { get; set;}
        public string Nom { get; set; }
        public TypeVoilier Type { get; set; }
        public bool EnCourse { get; set; }


        public Voilier(int ID, string NuméroDeSerie, string Nom, TypeVoilier Type, bool EnCourse)
        {
            this.ID = ID;
            this.NuméroDeSerie = NuméroDeSerie;
            this.Nom = Nom;
            this.Type = Type;
            this.EnCourse = EnCourse;
        }
    }
}
