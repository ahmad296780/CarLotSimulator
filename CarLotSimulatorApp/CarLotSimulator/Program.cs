using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            CarLotParking list1 = new CarLotParking();
            

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            Car car1 = new Car();
            Car car2 = new Car();
            Car car3 = new Car();
            
            car1.Make = "toyota";
            car1.Model = "camry";
            car1.Year = 2020;
            car1.EngineNoise = "zoom";
            car1.HonkNoise = "beep";
            car1.IsDrivable = "yes";

            car1.MakeEngineNoise();
            car1.MakeHonkNoise();

            car2.Make = "Honda";
            car2.Year = 2021;
            car2.Model = "Accord";
            car2.EngineNoise = "zoom zoom";
            car2.HonkNoise = "beep beep";
            car2.IsDrivable = "yes";

            Console.WriteLine("--------------");

            car2.MakeEngineNoise();
            car2.MakeHonkNoise();

            Console.WriteLine("----------------");

            car3.Make = "H";
            car3.Year = 2021;
            car3.Model = "ABC";
            car3.EngineNoise = "zoom zoom zoooom";
            car3.HonkNoise = "beep beep bbbeeepp";
            car3.IsDrivable = "No";

            car3.MakeEngineNoise();
            car3.MakeHonkNoise();





            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make,
            //and Model to the console
            Console.WriteLine("test ---");
            list1.listOfCars.Add(car1);
            list1.listOfCars.Add(car2);
            list1.listOfCars.Add(car3);

            foreach (var car in list1.listOfCars)
            {
                Console.WriteLine($"{car.Year}, {car.Make}, {car.Model}");
            }


        }
    }
}
