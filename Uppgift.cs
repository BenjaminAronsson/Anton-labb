using System.Collections.Generic;
using test;

namespace svar
{
   
    public class Uppgift
    {
        string fråga;
        string svar;

        List<LabbBetyg> betyg;

        public string Fråga { get => fråga; set => fråga = value; }
        public string Svar { get => svar; set => svar = value; }
        public List<LabbBetyg> Betyg { get => betyg; set => betyg = value; }


    }
}