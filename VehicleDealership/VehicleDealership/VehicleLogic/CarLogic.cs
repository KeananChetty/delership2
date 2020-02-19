using System;
using System.Collections.Generic;
using System.Text;
using VehicleDealership.Vehicle;

namespace VehicleDealership.VehicleLogic
{
    public class CarLogic
    {
        public static List<Cars> cars = GetCars();

        public static List <Cars> GetCars()
        {
            cars = new List<Cars>
            {
                /*new Cars (150000, 14569567, VehicleSpecs.High, VehicleColor.Flat , ServiceHistory.FullServiceHistory , "318i", 2014, true),
                new Cars (150000, 14569567, VehicleSpecs.High, VehicleColor.Flat , ServiceHistory.FullServiceHistory , "318i", 2014, true)*/
            };
            return cars;
        }

        public static void DisplayCars()
        {
            foreach (var item in cars)
            {
                Console.WriteLine(
                    
                    $"\n Book Value of the car is: {item.BookValue}" +
                    $"\n Millege On the Vehicle is: {item.Millage}" +
                    $"\n The Spec the Vehicle is: {item.VehicleSpecs}" +
                    $"\n The color the Vehicle is: {item.VehicleColor}" +
                    $"\n Service History: {item.ServiceHistory}" +
                    $"\n Vehicle Model: {item.VehicleSeries}" +
                    $"\n The Year it was Produced: {item.VehicleYearProduced}" +
                    $"\n-----------------------------------------------");
                
                Console.WriteLine("Your new price for milage is: ");
                NewVehiclePrice.Millage(item.Millage);
                Console.WriteLine("Vehicle Spec: ");
                NewVehiclePrice.VehicleSpec(item.BookValue, item.VehicleSpecs);
                Console.WriteLine("Service History: ");
                NewVehiclePrice.ServiceHistoryOfVehicle(item.BookValue, item.ServiceHistory);
                Console.WriteLine("Year produced: ");
                NewVehiclePrice.VehicleProductionYear(item.VehicleYearProduced);
                NewVehiclePrice.FullAmount(item.BookValue);
            }
        }
    }
}
