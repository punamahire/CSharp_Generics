using System;

namespace Generics
{
    public class Tesla : IElectricVehicle
    {
        public double CurrentChargePercentage { get; } = 100;
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            BatteryKWh = 50;
            Console.WriteLine("Tesla's battery has been charged to 50 KWh!");
        }
    }
}