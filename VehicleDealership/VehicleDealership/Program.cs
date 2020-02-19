using System;
using VehicleDealership.VehicleLogic;

namespace VehicleDealership
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var carlogic = new CarLogic();

            var vechilelogic = new VehicleLogicCalculation();
            var userinput = new UserInput();
            userinput.CarInput();
            CarLogic.DisplayCars();
            //vechilelogic.NewVehicleLogic();
        }
    }
}
