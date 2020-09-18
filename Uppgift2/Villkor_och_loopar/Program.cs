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

            int fastestTime = int.MaxValue;

            int nrRunners = 0;

            //int runTime = int.MaxValue;


            int timeSec;

            int startHr;
            int startMin;
            int startSec;
            int startTimeSec;

            int endHr;
            int endMin;
            int endSec;
            int endTimeSec;

            int bestEndHr;
            int bestEndMin;
            int bestEndSec;

            Console.Write("Ange ditt startnummer: ");
            startNumber = int.Parse(Console.ReadLine());

            while (startNumber > 1)
            {

                
                Console.Write("Vilken timme startade du: Ange 0-24: ");
                int.TryParse(Console.ReadLine(), out startHr);

                Console.Write("Vilken minut startade du? Ange 0-59: ");
                int.TryParse(Console.ReadLine(), out startMin);

                Console.Write("Vilken sekund startade du? Ange 0-59: ");
                int.TryParse(Console.ReadLine(), out startSec);

                Console.Write("Vilken timme gick du i mål? Ange 0-24: ");
                int.TryParse(Console.ReadLine(), out endHr);

                Console.Write("Vilken minut gick du i mål? Ange 0-59: ");
                int.TryParse(Console.ReadLine(), out endMin);

                Console.Write("Vilken sekund gick du i mål? Ange 0-59: ");
                int.TryParse(Console.ReadLine(), out endSec);

                startTimeSec = (startHr * 3600) + (startMin * 60) + startSec;
                
                endTimeSec = (endHr * 3600) + (endMin * 60) + endSec;

                timeSec = endTimeSec - startTimeSec;

                //Kontroll för efter midnatt.
                if (timeSec < 0)
                {
                    timeSec += 24 * 3600; //Ett dygn i sekunder för att undvika negativ sluttid.
                }

                //En timme = 3600 sek
                //Ett dygn = 86400 sek

                if (timeSec < fastestTime)
                {

                    startNumberFast = startNumber;
                    fastestTime = timeSec;

                }

                nrRunners++;


                Console.Write("Ange ditt startnummer: ");
                int.TryParse(Console.ReadLine(), out startNumber);
            }


            
            bestEndHr = (int)Math.Floor((decimal)fastestTime / 3600);
            bestEndMin = (int)Math.Floor((decimal)(fastestTime / 60)); //- endSec * 60);
            bestEndSec = fastestTime % 60;

            Console.WriteLine($"Antal tävlande i loppet: {nrRunners}");
            Console.WriteLine($"Löparen med startnummer {startNumberFast} vann loppet.");
            Console.WriteLine($"Den vinnande sluttiden är {bestEndHr} timmar, {bestEndMin} minuter, och {bestEndSec} sekunder.");
                    

        }


                
    }


}
