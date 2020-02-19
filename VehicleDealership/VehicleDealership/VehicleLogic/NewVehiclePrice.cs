using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleDealership.VehicleLogic
{
    public static class NewVehiclePrice
    {
        const int fullPercentage = 100;
        const int LowMillage = 100000;
        const int LowMillegeAmount = 30000;
        const int MediamMillege = 150000;
        const int MediamMillegeAmount = 5000;
        const int YearLessThen20111 = 50000;
        const int yearBetween2011And2018 = 10000;
        const int YearGraterThen2019 = 30000;
       
        private static int MillageAmount { get; set; }
        private static int VehicleSpecAmount { get; set; }
        private static int VehicleYearAmount { get; set; }
        private static int ServiceAmount { get; set; }

        public static int Millage( int millage)
        {
            if (millage < LowMillage)
            {
                MillageAmount = LowMillegeAmount;
            }
            else if (millage > LowMillage && millage < MediamMillege)
            {
                MillageAmount = MediamMillegeAmount;
            }
            Console.WriteLine(MillageAmount);
            return MillageAmount;
        }

        public static int VehicleSpec(int Bookvalue, VehicleSpecs vehicleSpecs)
        {
            if (vehicleSpecs == VehicleSpecs.High)
            {
                VehicleSpecAmount = (Bookvalue / fullPercentage) * (int)VehicleSpecs.High;
            }
            else if (vehicleSpecs == VehicleSpecs.Mediam)
            {
                VehicleSpecAmount = (Bookvalue / fullPercentage) * (int)VehicleSpecs.Mediam;
            }
            Console.WriteLine(VehicleSpecAmount);
            return VehicleSpecAmount;
        }

        public static int ServiceHistoryOfVehicle(int Bookvalue, ServiceHistory serviceHistory)
        {
            if (serviceHistory == ServiceHistory.FullServiceHistory)
            {
                ServiceAmount = (Bookvalue / fullPercentage) * (int)ServiceHistory.FullServiceHistory;
            }
            else if (serviceHistory == ServiceHistory.HalfServiceHistory)
            {
                ServiceAmount = (Bookvalue / fullPercentage) * (int)ServiceHistory.HalfServiceHistory;
            }
            Console.WriteLine(ServiceAmount);
            return ServiceAmount;
        }

        public static int VehicleProductionYear(int Year)
        {
            if (Year < 2011)
            {
                VehicleYearAmount = YearLessThen20111;
            }
            else if (Year > 2011 && Year < 2018)
            {
                VehicleYearAmount = yearBetween2011And2018;
            }
            else if (Year > 2019)
            {
                VehicleYearAmount = YearGraterThen2019;
            }
            Console.WriteLine(VehicleYearAmount);
            return VehicleYearAmount;
        }

        public static void FullAmount(int BasePrice)
        {
            int amount = (MillageAmount + VehicleSpecAmount + VehicleYearAmount + ServiceAmount);
            BasePrice += amount;
            Console.WriteLine("Your new amount for selling the vehicle is: R" + BasePrice);
        }
    }
}
