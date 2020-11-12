
namespace _0._1Vehicles.Models
{
   public class Truck:Vehicle
    {
        private const double FUEL_INCR = 1.6;
        private const double REFUEL_CAPACITY_COEF = 0.95;
        public Truck(double fuelQuantity,double fuelConsumption, double tankCapacity)
            :base(fuelQuantity,fuelConsumption,tankCapacity)
        {

        }
        public override double FuelConsumption => base.FuelConsumption+FUEL_INCR;
        public override void Refuel(double liters)
        {
            base.Refuel(liters);
            this.FuelQuantity =(liters * REFUEL_CAPACITY_COEF);
        }
    }
}
