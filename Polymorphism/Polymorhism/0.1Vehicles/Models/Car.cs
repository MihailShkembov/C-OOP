

namespace _0._1Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double FUEL_INCR = 0.9;
        public Car(double fuelQuantity,double fuelConsumption,double tankCapacity)
            :base(fuelQuantity,fuelConsumption, tankCapacity)
        {

        }
        public override double FuelConsumption => base.FuelConsumption+FUEL_INCR;
    }
}
