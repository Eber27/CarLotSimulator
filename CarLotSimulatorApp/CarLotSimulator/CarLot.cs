﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    class CarLot
    {
        public CarLot()
        {

        }


        // properties
        public List<Car> CarList { get; set; } = new List<Car>();

        // Field 
        public static int numberOfCars;
    }

}
