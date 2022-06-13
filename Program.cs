using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IGasVehicle> gasVehicles = new List<IGasVehicle>();

            Cessna cs = new Cessna();
            Ram rm = new Ram();

            gasVehicles.Add(cs);
            gasVehicles.Add(rm);

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>();

            Tesla ts = new Tesla();
            Zero zr = new Zero();

            electricVehicles.Add(ts);
            electricVehicles.Add(zr);

            GasStation gs = new GasStation();
            BatteryStation bs = new BatteryStation();

            gs.Refuel(gasVehicles);
            bs.Refuel(electricVehicles);
        }
    }
}
