using _0._1Vehicles.Common;
using System;
using System.Collections.Generic;


namespace _0._1Vehicles.Models
{
   public class Bus:Vehicle
    {
        private const double FUEL_INCR = 1.4;
        public Bus(double fuelQuantity,double fuelConsumption,double tankCapacity)
            :base(fuelQuantity,fuelConsumption,tankCapacity)
        {
           
        }
        public override string Drive(double distance)
        {
            double fuelNeeded = (this.FuelConsumption+FUEL_INCR) * distance;
            if (this.FuelQuantity < fuelNeeded)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.NotEnoughFuel, this.GetType().Name));
            }
            this.FuelQuantity -= fuelNeeded;
            return String.Format(ExceptionMessages.SUCC_TRAVEL_MSG, this.GetType().Name, distance);
        }
        public override string DriveEmpty(double distance)
        {
            return base.Drive(distance);
        }

    }
}
