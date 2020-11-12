using _0._1Vehicles.Core.Interfaces;
using _0._1Vehicles.Factories;
using _0._1Vehicles.Models;
using System;
using System.Linq;

namespace _0._1Vehicles.Core
{
    class Engine : IEnginge
    {
        private readonly VehicleFactory vehicleFactory;
        public Engine()
        {
            this.vehicleFactory = new VehicleFactory();
        }
        public void Run()
        {
            Vehicle car = this.ProcessVehicleInfo();
            Vehicle truck = this.ProcessVehicleInfo();
            Vehicle bus = this.ProcessVehicleInfo();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cmdType = cmdArgs[0];
                string vehicleType = cmdArgs[1];
                double arg = double.Parse(cmdArgs[2]);
                try
                {
                    if (cmdType == "Drive")
                    {
                        if (vehicleType == "Car")
                        {
                            this.Drive(car, arg);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.Drive(truck, arg);
                        }
                        else if (vehicleType == "Bus")
                        {
                            this.Drive(bus, arg);
                        }
                    }
                    else if (cmdType == "Refuel")
                    {
                        if (vehicleType == "Car")
                        {
                            this.Refuel(car, arg);
                        }
                        else if (vehicleType == "Truck")
                        {
                            this.Refuel(truck, arg);
                        }
                        else if (vehicleType == "Bus")
                        {
                            this.Refuel(bus, arg);
                        }
                    }
                    else if (cmdType=="DriveEmpty")
                    {
                        this.DriveEmpty(bus, arg);
                    }
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);
        }
        public void DriveEmpty(Vehicle vehicle,double distance)
        {
            Console.WriteLine(vehicle.DriveEmpty(distance));
        }
        private void Refuel(Vehicle vehicle,double liters)
        {
            vehicle.Refuel(liters);
        }
        private void Drive(Vehicle vehicle,double kilometers)
        {
            Console.WriteLine(vehicle.Drive(kilometers));
        }
        private Vehicle ProcessVehicleInfo()
        {
            string[] vehicleArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            string vehicleType = vehicleArgs[0];
            double fuelQuantity = double.Parse(vehicleArgs[1]);
            double fuelConsumption = double.Parse(vehicleArgs[2]);
            double tankCapacity= double.Parse(vehicleArgs[3]);
            Vehicle currVehicle = this.vehicleFactory.CreateVehicle(vehicleType, fuelQuantity, fuelConsumption,tankCapacity);
            return currVehicle;

        }
    }
}
