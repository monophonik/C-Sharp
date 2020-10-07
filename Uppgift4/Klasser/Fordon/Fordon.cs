using System;

namespace Klasser
{
    public abstract class Fordon
    {

        public string Modell { get; set; }
        public string RegNr { get; set; }
        public int KmMatare { get; set; }
        public DateTime RegDatum { get; set; }

    }
}
