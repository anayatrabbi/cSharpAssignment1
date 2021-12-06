using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpAssignment1
{
    public abstract class Vehicle
    {
        public abstract string ModelNo { get; set; }
        public abstract DateTime yearMake { get; set; }
        public abstract int NumberOfGear { get; set; }
        public abstract string EnergyCapacity { get; set; }
        //abstract method body will created in derived class
        public abstract string StartingMethod();

    }
}
