using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpAssignment1
{
    interface IBasicInformation
    {
        public int MaxPower { get; set; }
        public int Milaege { get; set; }
        public int ForntBreak { get; set; }
        public int RearBreak { get; set; }

        public void GetBasicInfo();

        public void TotalVehiclaes()
        {

        }
    }
}
