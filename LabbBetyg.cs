using System;
using svar;

namespace test
{
    public class LabbBetyg
    {

        Betyg betyg;
        int elevID;
        DateTime datum;


        public LabbBetyg()
        {
        }

        public LabbBetyg(Betyg betyg, int elevID)
        {
            this.betyg = betyg;
            this.elevID = elevID;
        }

        public DateTime Datum { get => datum; set => datum = value; }
        public int ElevID { get => elevID; set => elevID = value; }
        internal Betyg Betyg { get => betyg; set => betyg = value; }
    }
}
