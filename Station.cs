using System;
using System.Collections.Generic;

namespace Generics
{
    public abstract class Station<T>
    {
        public abstract void Refuel(List<T> vehicles);
    }
}