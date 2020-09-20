using System;

namespace Klasser
{
    class Program
    {
        /// <summary>
        /// Se instruktionenr i Uppgift.txt
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
        }
    }

    public class Bil
    {

        public string _model; //Varför public?
        private decimal _kilometers = decimal.MinValue;


        public string RegNr { get; set; }
        public int Kilograms { get; set; }
        public DateTime RegDate { get; set; }
        public bool Electric { get; set; }

        public Bil(string model)
        {
            _model = model;
        }

        private void Travelled(uint updateKilometers)
        {
            if(updateKilometers > _kilometers)
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