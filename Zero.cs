using System;

namespace Generics
{
    public class Zero : IElectricVehicle
    {
        public double CurrentChargePercentage { get; } = 100;
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {
            BatteryKWh = 18;
            Console.WriteLine("Zero's battery has been charged to 18 KWh!");
        }
    }
}