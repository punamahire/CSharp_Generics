using System;
using System.Collections.Generic;

namespace Generics
{
    public class GasStation : IStation<IGasVehicle>
    {
        // The number of vehicles that GasStation class can refuel at any one time.
        public int Capacity { get; set; }
        // The Refuel() method accepts a list of vehicles that only it can process.
        public void Refuel(List<IGasVehicle> vehicles)
        {
            foreach (var v in vehicles)
            {
                v.RefuelTank();
            }
        }

    }
}