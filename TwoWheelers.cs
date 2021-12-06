using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpAssignment1
{
    class TwoWheelers : Vehicle, IBasicInformation
    {
        public TwoWheelers()
        {

        }
        public TwoWheelers(string modelNo, DateTime yearMake, int numberOfGear, string energyCapacity, int maxPower, int milaege, int forntBreak, int rearBreak)
        {
            ModelNo = modelNo;
            this.yearMake = yearMake;
            NumberOfGear = numberOfGear;
            EnergyCapacity = energyCapacity;
            MaxPower = maxPower;
            Milaege = milaege;
            ForntBreak = forntBreak;
            RearBreak = rearBreak;
            BikeCount++;
        }

        public override string ModelNo { get; set; }
        public override DateTime yearMake { get; set; }
        public override int NumberOfGear { get; set; }
        public override string EnergyCapacity { get; set; }
        public int MaxPower { get; set; }
        public int Milaege { get; set; }
        public int ForntBreak { get; set; }
        public int RearBreak { get; set; }
        public static int BikeCount = 0; 
        public override string StartingMethod()
        {
            if (NumberOfGear == 5)
            {
                Console.WriteLine("this is a mototr cycle");
            }
            return "this is a bike";
        }
        public void TotalVehiclaes()
        {
            Console.WriteLine($"Total Car is {BikeCount}");
        }

        public void GetBasicInfo()
        {
            Console.WriteLine($"Model No: {ModelNo} Made year: {yearMake} , Gear : {NumberOfGear} Milage: {Milaege} Energy capacity {EnergyCapacity}");
            
        }
    }
}
