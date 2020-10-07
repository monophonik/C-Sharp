using System;
using System.Text;
using System.Collections.Generic;
using Klasser;


namespace ArvOchAbstraktion
{
    public class Program
    {

        static void Main(string[] args)
        {


            Bil bil1 = new Bil() { Modell = "Nissan", HarDrag = true };

            IVerkstad stockholm = new Verkstad();

            stockholm.LaggTillFordon(bil1);


            //Välj lista att skriva ut, bil etc...
            //public void ValjLista()
            //{
            //    switch (switch_on)
            //    {
            //        default:
            //    }
            //}

            

            //Funkar ej än
            //Verkstad.ShowList(_bilar, 0);


        }


        //public static void ValjLista(Fordonstyp fordon)
        //{
            
            
        //    switch (fordon)
        //    {
        //        case Fordonstyp.bil:

        //        default:
        //            break;
        //    }
        //}

    }
}
