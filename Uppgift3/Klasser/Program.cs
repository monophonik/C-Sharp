using System;
using System.Collections.Generic;

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

            List<string> Cars = new List<string>();

            Car car1 = new Car("BMW Z3")
            {
                RegNr = "POI 456",
                RegDate = DateTime.Now, //Varför behövs parse? Varför inte bara kunna skriva datumet 2002-01-01
                WeightKg = 1000,
                Electric = false,
            };

            Console.WriteLine($"Modell: {car1._model}");
            Console.WriteLine($"Registreringsnummer: {car1.RegNr}");
            Console.WriteLine($"Registrerades: {car1.RegDate}");
            Console.WriteLine($"Model: {car1._model}");

            if (car1.Electric)
            {
                Console.WriteLine("Det här är en elbil.");
            }

        }
    }

   
}