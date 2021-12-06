using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpAssignment1
{
    public class FourWheelers : Vehicle , IBasicInformation
    {
        public override DateTime yearMake { get; set; }
        public override string ModelNo { get; set; }
        public override int NumberOfGear { get; set; }
        public override string EnergyCapacity { get; set; }
        public int MaxPower { get; set; }
        public int Milaege { get; set; }
        public int ForntBreak { get; set; }
        public int RearBreak { get; set; }
        // made it static for all
        private static int CarCount = 0;
        // empty constructor
        public FourWheelers() { }

        //constructor overloading
        public FourWheelers(DateTime yearMake , string ModelNo, int NumberOfGear , string Energycapacity , int Milage , int FrontBreak , int RearBreak)
        {
            this.yearMake = yearMake;
            this.ModelNo = ModelNo;
            this.NumberOfGear = NumberOfGear;
            this.EnergyCapacity = Energycapacity;
            this.Milaege = Milaege;
            this.ForntBreak = FrontBreak;
            this.RearBreak = RearBreak;
            CarCount++;
        }

        public override string StartingMethod()
        {
            if(NumberOfGear == 5)
            {
                Console.WriteLine("this is a mototr cycle");
            }
            return "this is a bike";
        }
        //polymorphic behaviour
        public void TotalVehiclaes()
        {
            Console.WriteLine($"Total Car is {CarCount}");
        }

        public void GetBasicInfo()
        {
            Console.WriteLine($"Model No: {ModelNo} Made year: {yearMake} , Gear : {NumberOfGear} Milage: {Milaege} Energy capacity {EnergyCapacity}");
        }
    }
}
