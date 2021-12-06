using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpAssignment1
{
    class Car : FourWheelers
    {
        public Car(DateTime yearMake, string ModelNo, int NumberOfGear, string Energycapacity, int Milage, int FrontBreak, int RearBreak) : base(yearMake, ModelNo, NumberOfGear, Energycapacity, Milage, FrontBreak, RearBreak)
        {
        }
      
    }
}
