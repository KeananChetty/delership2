using System;
using System.Collections.Generic;
using System.Text;

namespace VehicleDealership
{
    public class VehicleType
    {
        public  int BookValue { get; set; }
        public  int Millage { get; set; }
        public VehicleSpecs VehicleSpecs { get; set; }
        public VehicleColor VehicleColor { get; set; }
        public ServiceHistory ServiceHistory { get; set; }
        public  string VehicleSeries { get; set; }
        public  int VehicleYearProduced{ get; set; }


        //public abstract void Milage();

        public VehicleType()
        {

        }
        public VehicleType(int bookValue, int millage, VehicleSpecs vehicleSpecs, VehicleColor vehicleColor, ServiceHistory serviceHistory, string vehicleSeries, int vehicleYearProduced)
        {
            BookValue = bookValue;
            Millage = millage;
            VehicleSpecs = vehicleSpecs;
            VehicleColor = vehicleColor;
            ServiceHistory = serviceHistory;
            VehicleSeries = vehicleSeries;
            VehicleYearProduced = vehicleYearProduced;
        }
    }
}
