using _0._1Vehicles.Common;
using _0._1Vehicles.Models;
using System;

namespace _0._1Vehicles.Factories
{
   public class VehicleFactory
    {
        public VehicleFactory()
        {

        }
        public Vehicle CreateVehicle(string vehicleType,double fuelQuantity,double fuelConsumption,double tankCapacity)
        {
            Vehicle vehicle;
            if (vehicleType=="Car")
            {
                vehicle = new Car(fuelQuantity, fuelConsumption,tankCapacity);
            }
            else if (vehicleType=="Truck")
            {
                vehicle = new Truck(fuelQuantity, fuelConsumption,tankCapacity);
            }
            else if (vehicleType=="Bus")
            {
                vehicle = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
            }
            else
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidVehicle);
            }
            return vehicle;
        }
    }
}
