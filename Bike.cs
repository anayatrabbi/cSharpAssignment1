using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpAssignment1
{
    public class Bike : FourWheelers
    {
        public Bike()
        {
        }

        public Bike(DateTime yearMake, string ModelNo, int NumberOfGear, string Energycapacity, int Milage, int FrontBreak, int RearBreak) : base(yearMake, ModelNo, NumberOfGear, Energycapacity, Milage, FrontBreak, RearBreak)
        {
        }
    }
}
