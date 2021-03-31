using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class Car
    {

        public Car()
        {
            CarLot.numberOfCars++;
        }

        public Car(int yearinput, string makeinput, string modelinput, string enginenoiseinput, string honknoiseinput, bool isdriveableinput)
        {
            Year = yearinput;
            Make = makeinput;
            Model = modelinput;
            EngineNoise = enginenoiseinput;
            HonkNoise = honknoiseinput;
            IsDriveable = isdriveableinput;
        }
        //properties
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
        public bool IsDriveable { get; set; }

        //Methods

        public void MakeEngineNoise()
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise()
        {
            Console.WriteLine(HonkNoise);
        }
    }

}
