using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleDealership.Vehicle
{
    public class Cars : VehicleType 
    {
        public bool Sunroof { get; set; }

       public Cars()
        {

        }

        public Cars(int bookValue, int millage, VehicleSpecs vehicleSpecs, VehicleColor vehicleColor, ServiceHistory serviceHistory, string vehicleSeries, int vehicleYearProduced, bool sunroof) : base ( bookValue,  millage,  vehicleSpecs,  vehicleColor,  serviceHistory,  vehicleSeries,  vehicleYearProduced)
        {
            Sunroof = sunroof;
        }

    }
}
