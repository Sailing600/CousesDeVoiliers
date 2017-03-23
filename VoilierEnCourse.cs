
namespace Voilier
{
    class VoilierEnCourse
    {
        public int ID { get; set; }
        public string Nom { get; set; }
        public int Classement { get; set; }
        public bool Participation { get; set; }
        public double TempsRéel { get; set; }
        public double TempsBrut { get; set; }



        public VoilierEnCourse()
        {
            this.ID = ID;
            this.Nom = Nom;
            this.Classement = Classement;
            this.Participation = Participation;
            this.TempsRéel = TempsRéel;
            this.TempsBrut = TempsBrut;
        }
    }
}
