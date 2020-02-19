using System;
using System.Collections.Generic;
using System.Text;
using VehicleDealership.VehicleLogic;
using VehicleDealership.Vehicle;

namespace VehicleDealership
{
    public class UserInput 
    {
        public int UserInputBookValue;
        public int UserInputMillage;
        public VehicleSpecs VehicleSpecs;
        public string UserInputVehicleSpec;
        public VehicleColor VehicleColor;
        public string UserInputColor;
        public ServiceHistory ServiceHistory;
        public string UserInputServiceHistory;
        public string UserInputVehicleModel;
        public int UserInputVehicleYearProduced;

        public void CarInput()
        {
            Console.WriteLine("What is your BookValue?");
            UserInputBookValue = int.Parse(Console.ReadLine());

            Console.WriteLine("what is the Millage on the car?");
            UserInputMillage = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the Vehicle Spec? \nA) High \nB) Mediam \nC) Low");
            UserInputVehicleSpec = Console.ReadLine();
            if(UserInputVehicleSpec == "A" || UserInputVehicleSpec == "a")
            {
                 VehicleSpecs = VehicleSpecs.High;
            }
            else if(UserInputVehicleSpec == "B" || UserInputVehicleSpec == "b")
            {
                VehicleSpecs = VehicleSpecs.Mediam;
            }
            else if(UserInputVehicleSpec == "C" || UserInputVehicleSpec == "c")
            {
                VehicleSpecs = VehicleSpecs.Low;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("What Color is the Vehicle? \nA) Flat \nB) Metalic");
            UserInputColor = Console.ReadLine();
            if (UserInputColor == "A" || UserInputColor == "a")
            {
                VehicleColor = VehicleColor.Flat;
            }
            else if (UserInputColor == "B" || UserInputColor == "b")
            {
                VehicleColor = VehicleColor.Metalic;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("What is the service history on the car? \nA) Full Service History \nB) Part Service History \nC) No Service History");
            UserInputServiceHistory = Console.ReadLine();
            if (UserInputServiceHistory == "A" || UserInputServiceHistory == "a")
            {
                ServiceHistory = ServiceHistory.FullServiceHistory;
            }
            else if (UserInputServiceHistory == "B" || UserInputServiceHistory == "b")
            {
                ServiceHistory = ServiceHistory.HalfServiceHistory;
            }
            else if (UserInputServiceHistory == "C" || UserInputServiceHistory == "c")
            {
                ServiceHistory = ServiceHistory.NoServiceHistory;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }

            Console.WriteLine("What is the vehicle Model?");
            UserInputVehicleModel = Console.ReadLine();

            Console.WriteLine("What year was the vehicle Produced?");
            UserInputVehicleYearProduced = int.Parse(Console.ReadLine());
            if(UserInputVehicleYearProduced < 1885  || UserInputVehicleYearProduced > 2020)
            {
                Console.WriteLine("No Cars where produced in this Year" + UserInputVehicleYearProduced );
            }


            Cars car = new Cars();
            car.BookValue = UserInputBookValue;
            car.Millage = UserInputMillage;
            car.VehicleSpecs = VehicleSpecs;
            car.VehicleColor = VehicleColor;
            car.ServiceHistory = ServiceHistory;
            car.VehicleSeries = UserInputVehicleModel;
            car.VehicleYearProduced = UserInputVehicleYearProduced;
            car.Sunroof = true;

            CarLogic.cars.Add(car);
            Console.WriteLine(car);
        }
    }
}
