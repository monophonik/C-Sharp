using Klasser;
using System;
using System.Collections.Generic;
using System.Text;

namespace ArvOchAbstraktion
{
    public enum Fordonstyp
    {
        bil,
        motorcykel,
        buss,
        lastbil
    }

    public class Verkstad : IVerkstad
    {
        private List<Bil> _bilar;
        private List<Motorcykel> _motorcyklar;
        private List<Buss> _bussar;
        private List<Lastbil> _lastbilar;

        public List<Bil> Bilar
        {
            get
            {
                if (_bilar == null)
                {
                    _bilar = new List<Bil>();

                }

                return _bilar;

            }

            set { _bilar = value; }

        }

        public List<Motorcykel> Motorcyklar
        {
            get
            {
                if (_motorcyklar == null)
                {
                    _motorcyklar = new List<Motorcykel>();

                }

                return _motorcyklar;

            }

            set { _motorcyklar = value; }

        }

        public List<Buss> Bussar
        {
            get
            {
                if (_bussar == null)
                {
                    _bussar = new List<Buss>();

                }

                return _bussar;

            }

            set { _bussar = value; }

        }

        public List<Lastbil> Lastbilar
        {
            get
            {
                if (_lastbilar == null)
                {
                    _lastbilar = new List<Lastbil>();

                }

                return _lastbilar;

            }

            set { _lastbilar = value; }

        }

        public Verkstad()
        {

        }
        
        //Fråga: this? Förhållande mellan field och prop, get/set? Se metod nedan.

        public void LaggTillFordon(Fordon fordon)
        {

            //Använda switch här eller i main?
            Fordonstyp x = 0;

            switch (x)
            {
                case Fordonstyp.bil:

                default:
                    break;
            }
            


            if (fordon is Bil)
            {
                _bilar.Add(fordon as Bil);
            }
            else if (fordon is Motorcykel)
            {
                _motorcyklar.Add(fordon as Motorcykel);
            }
            else if (fordon is Buss)
            {
                _bussar.Add(fordon as Buss);
            }
            else if (fordon is Lastbil)
            {
                _lastbilar.Add(fordon as Lastbil);
            }
            
        }

        public void TaBortFordon()
        {

        }

        public void Test()
        {

        }
        
        
        //Hur ska jag få till metoden så att den funkar på alla listor???
        //public static void ShowList(List<Fordon> list, int x)
        //{
            
        //    //Om listan är av typen Bil/Motorcykel/....
        //    if (list is List<Bil>)
        //    {

        //    }
        //    Console.WriteLine(list[x].Modell.ToString());
        //}


    }
}
