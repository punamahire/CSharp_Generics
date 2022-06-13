using System;
using System.Collections.Generic;

namespace Generics
{
    public class BatteryStation : IStation<IElectricVehicle>
    {
        // The number of vehicles that BatteryStation class can refuel at any one time.
        public int Capacity { get; set; }
        // The Refuel() method accepts a list of vehicles that only it can process.
        public void Refuel(List<IElectricVehicle> vehicles)
        {
            foreach (var v in vehicles)
            {
                v.ChargeBattery();
            }
        }
    }
}