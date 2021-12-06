using System;

namespace cSharpAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car( new DateTime(2021,3,21) , "Toyota12" , 4 ,"200" , 300 , 4 , 5);
            car1.GetBasicInfo();
            car1.TotalVehiclaes();
            car1.StartingMethod();
            Bike bike1 = new Bike( new DateTime(2011, 4 , 23) , "sujki xr" , 5 , "150" , 120 , 3 , 6);
            bike1.GetBasicInfo();
            bike1.TotalVehiclaes();
            bike1.StartingMethod();
        }
    }
}
