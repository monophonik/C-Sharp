using System;
using System.Collections.Generic;
using System.Globalization;

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

            List<Person> Persons = new List<Person>();

            string name, test, test2;

            int numberCars, age;

            bool moreInput = true;


            //Car car1 = new Car("BMW Z3")
            //{
            //    RegNr = "POI 456",
            //    RegDate = DateTime.Now,

            //    WeightKg = 1000,
            //    Electric = true,
            //};

            while (moreInput)
            {
             
                Console.Write("Ange ditt namn? ");
                name = Console.ReadLine();

                Console.Write("Hur gammal är du? ");
                age = int.Parse(Console.ReadLine());

                Person p = new Person(name, age);

                Console.Write("Hur många bilar har du? ");
                numberCars = int.Parse(Console.ReadLine());

                Persons.Add(p);


                for (int i = 0; i < numberCars; i++)
                {

                    Console.Write("\r\nVad har du för bilmodell? ");
                    Car c = new Car(Console.ReadLine());

                    Console.Write("Hur långt har din bil gått i kilometer? ");
                    c.Travelled(uint.Parse(Console.ReadLine()));

                    Console.Write("Vad har din bil för registreringsnummer? ");
                    c.RegNr = Console.ReadLine();

                    Console.Write("Vilket datum registrerades din bil (åååå-mm-dd)? ");
                    c.RegDate = DateTime.Parse(Console.ReadLine());

                    Console.Write("Vad väger din bil i kilon? ");
                    c.WeightKg = int.Parse(Console.ReadLine());

                    Console.Write("Är det en elbil? Ange J eller N: ");
                    test = Console.ReadLine();
                    if (test == "J" || test == "j")
                    {
                        c.Electric = true;
                    }
                    else if (test == "N" || test == "n")
                    {
                        c.Electric = false;
                    }
                    else
                    {
                        c.Electric = false;
                    }

                    p.AddCar(c);

                }


                Console.Write("\r\nLägg till ytterligare en person? Ange J eller N: ");
                test2 = Console.ReadLine();
                if (test2 == "J" || test2 == "j")
                {
                    moreInput = true;
                }
                else
                {
                    moreInput = false;
                }

            }


            foreach (var x in Persons)
            {

                x.ShowCars();

            }                      

        }
    }

   
}