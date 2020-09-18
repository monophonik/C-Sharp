using System;
using System.Security.Cryptography.X509Certificates;

namespace Villkor_och_loopar
{

    /// <summary>
    
       
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //Variables

            int startNumber = 0;

            int startNumberFast = 0;

            int fastestTime = 0;

            int nrRunners = 0;


            Console.Write("Ange ditt startnummer: ");
            startNumber = int.Parse(Console.ReadLine());

            while (startNumber > 1)
            {


                //Anropa metod, deltagaren får mata in sina data.

                fastestTime = RunTime();



                nrRunners++;

                Console.Write("Ange ditt startnummer: ");
                startNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Antal tävlande i loppet: {nrRunners}");
            Console.WriteLine($"Löparen med startnummer {startNumberFast} vann loppet.");
            Console.WriteLine($"Den vinnande sluttiden är {fastestTime}");


            //Methods

            //Räknar ut lopptiden till sekunder
            static int RunTime()
            {
                int time = 0;

                int startHr;
                int startMin;
                int startSec;

                int endHr;
                int endMin;
                int endSec;
                
                Console.Write("Vilken timme startade du: Ange 0-24: ");
                startHr = int.Parse(Console.ReadLine());

                Console.Write("Vilken minut startade du? Ange 0-59: ");
                startMin = int.Parse(Console.ReadLine());

                Console.Write("Vilken sekund startade du? Ange 0-59: ");
                startSec = int.Parse(Console.ReadLine());


                Console.Write("Vilken timme gick du i mål? Ange 0-24: ");
                endHr = int.Parse(Console.ReadLine());

                Console.Write("Vilken minut gick du i mål? Ange 0-59: ");
                endMin = int.Parse(Console.ReadLine());

                Console.Write("Vilken sekund gick du i mål? Ange 0-59: ");
                endSec = int.Parse(Console.ReadLine());


                
                //Passerat midnatt? 24h (86400) - startHr (i sekunder)

                //En timme = 3600 sek
                //Ett dygn = 86400 sek

                return time;
            }

        }


                
    }


}
