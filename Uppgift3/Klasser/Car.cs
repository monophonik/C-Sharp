using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Car
    {

        public string _model; //Varför public?
        private decimal _kilometers = decimal.MinValue;


        public string RegNr { get; set; }
        public DateTime RegDate { get; set; }
        public int WeightKg { get; set; }
        public bool Electric { get; set; }

        public Car(string model)
        {
            _model = model;
        }

        private void Travelled(uint updateKilometers)
        {
            if (updateKilometers > _kilometers)
            {
                _kilometers = updateKilometers;
            }
        }

        public string ShowTravelled(decimal distance)
        {
            distance = _kilometers;
            return distance.ToString();
        }

    }


    
}
