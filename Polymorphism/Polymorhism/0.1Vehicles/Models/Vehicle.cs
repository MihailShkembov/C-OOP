using _0._1Vehicles.Common;
using _0._1Vehicles.Models.Interfaces;
using System;

namespace _0._1Vehicles.Models
{
    public abstract class Vehicle : IDriveable, IRefuelable
    {
        private double fuelQuantity;
        protected Vehicle(double fuelQuantity,double fuelConsumption,double tankCapacity)
        {
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
        }
        public double FuelQuantity
        {
            get => this.fuelQuantity;
            protected set
            {
                if (value > this.TankCapacity)
                {
                    this.fuelQuantity = 0;
                }
                else
                {
                    this.fuelQuantity = value;
                }

            }
        }
        public virtual double FuelConsumption { get; internal set; }
        public double TankCapacity { get; set; }
        public virtual string Drive(double distance)
        {
            double fuelNeeded = this.FuelConsumption  * distance;
            if (this.FuelQuantity<fuelNeeded)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.NotEnoughFuel,this.GetType().Name));
            }
                this.FuelQuantity -= fuelNeeded;
            return String.Format(ExceptionMessages.SUCC_TRAVEL_MSG, this.GetType().Name, distance);
            
        }
        public virtual string DriveEmpty(double distance)
        {
            return  String.Format(ExceptionMessages.SUCC_TRAVEL_MSG,this.GetType(),distance);
        }
        public virtual void Refuel(double liters)
        {
            if (liters<=0)
            {
                throw new InvalidOperationException(ExceptionMessages.NegativeFuel);
            }
            if (this.FuelQuantity+liters>TankCapacity)
            {
                throw new InvalidOperationException(String.Format(ExceptionMessages.TooMuchFuel,liters));
            }
            this.FuelQuantity += liters;
        }
        public override string ToString()
        {
            return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
        }


    }
}
