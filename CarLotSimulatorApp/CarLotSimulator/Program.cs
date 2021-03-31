using System;
using System.Collections.Generic;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            CarLot.numberOfCars = 1;

            CarLot lot = new CarLot();

            Car x5 = new Car();
            x5.Year = 2021;
            x5.Make = "BMW";
            x5.Model = "sDrive";
            x5.EngineNoise = "Vroom bun bun";
            x5.HonkNoise = "Fom Fom";
            x5.IsDriveable = true;
            lot.CarList.Add(x5);

            x5.MakeEngineNoise();
            x5.MakeHonkNoise();

            Car Highlander = new Car() { Year = 2020, Make = "Toyota", Model = "XLE", EngineNoise = "Fram Fram", HonkNoise = "bi-bi", IsDriveable = true};  // Object Initializer syntax**
            lot.CarList.Add(Highlander);

            Highlander.MakeEngineNoise();
            Highlander.MakeHonkNoise();

            Car passat = new Car(2018, "Volkswagen", "Turbo", "Pram Pram", "tink tink", true);     //Constructor Initializer**
            lot.CarList.Add(passat);

            passat.MakeEngineNoise();
            passat.MakeHonkNoise();

            var cardetails = new List<Car>() { x5, Highlander, passat };


            foreach (var carspecs in cardetails)
            {
                Console.WriteLine($"{carspecs.Year}, {carspecs.Make}, {carspecs.Model}, {carspecs.EngineNoise}, {carspecs.HonkNoise}, {carspecs.IsDriveable}");
            }

            Console.WriteLine("---------------------------");

            Console.WriteLine($"The current number of cars in the carlot is : {CarLot.numberOfCars}");

            foreach (var caradded in lot.CarList)
            {
                Console.WriteLine($"Year:{caradded.Year}, Make:{caradded.Make}, Model:{caradded.Model}");
            }

            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable

            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

        }
    }
}
