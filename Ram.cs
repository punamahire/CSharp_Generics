using System;

namespace Generics
{
    public class Ram : IGasVehicle
    {
        public double CurrentTankPercentage { get; } = 100;
        public double FuelCapacity { get; set; }

        public void RefuelTank()
        {
            FuelCapacity = 26;
            Console.WriteLine("Ram truck has be refuled with 26 gallons of gas!");
        }
    }
}