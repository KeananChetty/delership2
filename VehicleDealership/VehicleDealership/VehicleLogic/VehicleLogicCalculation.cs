using System;
using System.Collections.Generic;
using System.Text;
using VehicleDealership.Vehicle;

namespace VehicleDealership.VehicleLogic
{
    public class VehicleLogicCalculation
    {
        Cars car = new Cars();
        const int fullPercentage = 100;
        public int newAmount { get; set; }
        const int LowMillage = 100000;
        const int LowMillegeAmount = 30000;
        const int MediamMillege = 150000;
        const int MediamMillegeAmount = 5000;
        const int YearLessThen20111 = 50000;
        const int yearBetween2011And2018 = 10000;
        const int YearGraterThen2019 = 30000;

        public int NewVehicleLogic(/*int millage, VehicleSpecs vehicleSpecs, ServiceHistory serviceHistory, int year*/)
        {
            int carNewValue;
            carNewValue = car.BookValue;
            if (car.Millage < LowMillage)
            {
                carNewValue += LowMillegeAmount;
            }
            else if (car.Millage > LowMillage && car.Millage < MediamMillege)
            {
                carNewValue += MediamMillegeAmount;
            }

            if(car.VehicleSpecs == VehicleSpecs.High)
            {
                carNewValue += (car.BookValue / fullPercentage) * (int)VehicleSpecs.High;
            }
            else if(car.VehicleSpecs == VehicleSpecs.Mediam)
            {
                carNewValue += (car.BookValue / fullPercentage) * (int)VehicleSpecs.Mediam;
            }

            if (car.ServiceHistory  == ServiceHistory.FullServiceHistory)
            {
                carNewValue += (car.BookValue / fullPercentage) * (int)ServiceHistory.FullServiceHistory;
            }
            else if (car.ServiceHistory == ServiceHistory.HalfServiceHistory)
            {
                carNewValue += (car.BookValue / fullPercentage) * (int)ServiceHistory.HalfServiceHistory;
            }

            if (car.VehicleYearProduced < 2011)
            {
                carNewValue += YearLessThen20111;
            }
            else if (car.VehicleYearProduced > 2011 && car.VehicleYearProduced < 2018)
            {
                carNewValue += yearBetween2011And2018;
            }
            else if (car.VehicleYearProduced > 2019)
            {
                carNewValue += YearGraterThen2019;
            }
            Console.WriteLine("Your new value is: " + carNewValue);
            return carNewValue;
        }
    }
}
