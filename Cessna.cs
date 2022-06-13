using System;

namespace Generics
{
    public class Cessna : IGasVehicle
    {
        public double CurrentTankPercentage { get; } = 100;
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 50;
            Console.WriteLine("Cessna has be refuled with 50 gallons of gas!");
        }
    }
}