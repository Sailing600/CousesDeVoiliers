using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voiliers
{
    class Utilisateur
    {
        public int id { get; set; }
        public string Identifiant { get; set; }
        public int MotDePasse { get; set; }



        public Utilisateur()
        {
            this.id = id;
            this.Identifiant = Identifiant;
            this.MotDePasse = MotDePasse;
        }
    }
}
