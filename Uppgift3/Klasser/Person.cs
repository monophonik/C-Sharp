using System;
using System.Collections.Generic;
using System.Text;

namespace Klasser
{
    public class Person
    {

        private List<Car> Cars = new List<Car>();

        public string Name { get; set; }
        public int Age { get; set; }
        //public List<Car> Cars { get; set; } Varför funkar inte som property?


        public Person(string name, int age)
        {
           
            Name = name;
            Age = age;
            //Cars = new List<Car>(); Varför funkar inte som property?
        
        }

        public void AddCar(Car add)
        {
            Cars.Add(add);
        }

        public void ShowCars()
        {
            foreach(var i in Cars)
            {
                Console.WriteLine($"Modell: {i._model}");
                Console.WriteLine($"Registreringsnummer: {i.RegNr}");
                Console.WriteLine($"Registrerades: {i.RegDate}");
                Console.WriteLine($"Vikt: {i.WeightKg}");

                if (i.Electric)
                {
                    Console.WriteLine("Det här är en elbil.");
                }

                Console.WriteLine();
            }
        }

    }
}
