﻿using System;
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

            List<Car> Cars = new List<Car>();

            string name;

            int age;

            int numberCars = 0;

            bool moreInput = true;


            //Car car1 = new Car("BMW Z3")
            //{
            //    RegNr = "POI 456",
            //    RegDate = DateTime.Now, //Varför behövs parse? Varför inte bara kunna skriva datumet 2002-01-01
            //    WeightKg = 1000,
            //    Electric = true,
            //};


            //Iterera lista över personer och deras lista av bilar efter inmatning.
            while (moreInput)
            {
             
                //Person p = new Person;
                //Persons.Add() 
                Console.Write("Vad är ditt namn? ");
                name = Console.ReadLine();

                Console.Write("Hur gammal är du? ");
                age = int.Parse(Console.ReadLine());

                Person p = new Person(name, age);

                //Hur många bilar har du?
                Console.Write("Hur många bilar har du? ");
                numberCars = int.Parse(Console.ReadLine());

                for (int i = 0; i < numberCars; i++)
                {

                    Console.Write("Vad har du för bilmodell? ");
                    Car c = new Car(Console.ReadLine());

                    Console.Write("Hur långt har din bil gått i kilometer? ");
                    c.Travelled(uint.Parse(Console.ReadLine()));

                    Console.Write("Vad har din bil för registreringsnummer? ");
                    c.RegNr = Console.ReadLine();

                    Console.Write("Vilket datum registrerades din bil (åååå-mm-dd)? ");
                    c.RegDate = DateTime.Parse(Console.ReadLine());

                    Console.Write("Vad väger din bil i kilon? ");
                    c.WeightKg = int.Parse(Console.ReadLine());

                    string test;
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

                    p.Cars.Add(c);


                }


                string test2;
                Console.Write("Lägg till ytterligare en person? Ange J eller N: ");
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



            //for (int i = 0; i < 4; i++)
            //{
                
            //    Console.Write("Vad har du för bilmodell? ");
            //    Car c = new Car(Console.ReadLine());
                
            //    Console.Write("Hur långt har din bil gått i kilometer? ");
            //    c.Travelled(uint.Parse(Console.ReadLine()));

            //    Console.Write("Vad har din bil för registreringsnummer? ");
            //    c.RegNr = Console.ReadLine();

            //    Console.Write("Vilket datum registrerades din bil (åååå-mm-dd)? ");
            //    c.RegDate = DateTime.Parse(Console.ReadLine());

            //    Console.Write("Vad väger din bil i kilon? ");
            //    c.WeightKg = int.Parse(Console.ReadLine());

            //    string test;
            //    Console.Write("Är det en elbil? Ange J eller N: ");
            //    test = Console.ReadLine();
            //    if (test == "J" || test == "j")
            //    {
            //        c.Electric = true;
            //    }
            //    else if (test == "N" || test == "n")
            //    {
            //        c.Electric = false;
            //    }
            //    else
            //    {
            //        c.Electric = false;
            //    }

            //    Cars.Add(c);

            //    Console.WriteLine();

            //}


            //foreach(var x in Cars)
            //{
            //    Console.WriteLine($"Modell: {x._model}");
            //    Console.WriteLine($"Registreringsnummer: {x.RegNr}");
            //    Console.WriteLine($"Registrerades: {x.RegDate}");
            //    Console.WriteLine($"Vikt: {x.WeightKg}");

            //    if (x.Electric)
            //    {
            //        Console.WriteLine("Det här är en elbil.");
            //    }

            //    Console.WriteLine();

            //}
            

            //Console.WriteLine($"Modell: {car1._model}");
            //Console.WriteLine($"Registreringsnummer: {car1.RegNr}");
            //Console.WriteLine($"Registrerades: {car1.RegDate}");
            //Console.WriteLine($"Model: {car1._model}");

            //if (car1.Electric)
            //{
            //    Console.WriteLine("Det här är en elbil.");
            //}

        }
    }

   
}