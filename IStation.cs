using System;
using System.Collections.Generic;

namespace Generics
{
    public interface IStation<T>
    {
        // The number of vehicles that an implementing class can refuel at any one time.
        public int Capacity { get; set; }
        // A method to print a message to the terminal that the vehicle has been refueled. 
        // (e.g. "The Cessna has been refueled with 200 gallons of gas") Each refueling 
        // station's Refuel() method should accept a list of vehicles that only it can process.
        void Refuel(List<T> vehicles);

    }
}