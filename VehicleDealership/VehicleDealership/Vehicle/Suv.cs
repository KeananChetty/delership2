using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleDealership.Vehicle
{
    public class Suv : VehicleType
    {
        public Suv()
        {

        }

        public Suv(int bookValue, int millage, VehicleSpecs vehicleSpecs, VehicleColor vehicleColor, ServiceHistory serviceHistory, string vehicleSeries, int vehicleYearProduced) : base(bookValue, millage, vehicleSpecs, vehicleColor, serviceHistory, vehicleSeries, vehicleYearProduced)
        {
            
        }

    }
}
