using BadWay = LiskovSubstitution.BadWay;
using GoodWay = LiskovSubstitution.GoodWay;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            BadWayProgram();
            //GoodWayProgram();
        }

        private static void BadWayProgram()
        {
            // Car can be refueled without error...
            BadWay.Car car = new BadWay.Car();
            car.Make = "Suzuki";
            car.Model = "Swift";
            Console.WriteLine($"{car.Make} {car.Model} road tax: {car.CalculateRoadTax(2)}");
            Console.WriteLine($"Attempting to refuel {car.Make} {car.Model}...");
            car.Refuel(50);
            Console.WriteLine($"{car.Make} {car.Model} refueled!");

            // ...same with Petrol Car...
            BadWay.Car petrolCar = new BadWay.PetrolCar();
            petrolCar.Make = "Ford";
            petrolCar.Model = "Mustang";
            Console.WriteLine($"{petrolCar.Make} {petrolCar.Model} road tax: {petrolCar.CalculateRoadTax(2)}");
            Console.WriteLine($"Attempting to refuel {petrolCar.Make} {petrolCar.Model}...");
            petrolCar.Refuel(50);
            Console.WriteLine($"{petrolCar.Make} {petrolCar.Model} refueled!");

            // ...same with Diesel Car...
            BadWay.Car dieselCar = new BadWay.DieselCar();
            dieselCar.Make = "Land Rover";
            dieselCar.Model = "Discovery";
            Console.WriteLine($"{dieselCar.Make} {dieselCar.Model} road tax: {dieselCar.CalculateRoadTax(5)}");
            Console.WriteLine($"Attempting to refuel {dieselCar.Make} {dieselCar.Model}...");
            dieselCar.Refuel(50);
            Console.WriteLine($"{dieselCar.Make} {dieselCar.Model} refueled!");

            // ...ah, we have a problem.
            BadWay.Car electricCar = new BadWay.ElectricCar();
            electricCar.Make = "Nissan";
            electricCar.Model = "Leaf";
            Console.WriteLine($"{electricCar.Make} {electricCar.Model} road tax: {electricCar.CalculateRoadTax(0)}");
            Console.WriteLine($"Attempting to refuel {electricCar.Make} {electricCar.Model}...");
            // It does not make any sense to refuel an electric car, so an InvalidOperationException is thrown.
            // This violates LSP... "No new exceptions should be thrown by methods of the subtype".
            electricCar.Refuel(50);
            Console.WriteLine($"{electricCar.Make} {electricCar.Model} refueled!");
        }

        private static void GoodWayProgram()
        {
            // Car object cannot be refueled directly as it not safe to make the assumption that all cars can be refueled.
            GoodWay.Car car = new GoodWay.Car();
            car.Make = "Suzuki";
            car.Model = "Swift";
            Console.WriteLine($"{car.Make} {car.Model} road tax: {car.CalculateRoadTax(2)}");

            // PetrolCar object implements IRefuelable, so it can refuel.
            GoodWay.PetrolCar petrolCar = new GoodWay.PetrolCar(new GoodWay.StandardRefuelingSystem());
            petrolCar.Make = "Ford";
            petrolCar.Model = "Mustang";
            Console.WriteLine($"{petrolCar.Make} {petrolCar.Model} road tax: {petrolCar.CalculateRoadTax(2)}");
            Console.WriteLine($"Attempting to refuel {petrolCar.Make} {petrolCar.Model}...");
            petrolCar.Refuel(50);
            Console.WriteLine($"{petrolCar.Make} {petrolCar.Model} refueled!");

            // DieselCar object implements IRefuelable, so it can refuel.
            GoodWay.DieselCar dieselCar = new GoodWay.DieselCar(new GoodWay.StandardRefuelingSystem());
            dieselCar.Make = "Land Rover";
            dieselCar.Model = "Discovery";
            Console.WriteLine($"{dieselCar.Make} {dieselCar.Model} road tax: {dieselCar.CalculateRoadTax(5)}");
            Console.WriteLine($"Attempting to refuel {dieselCar.Make} {dieselCar.Model}...");
            dieselCar.Refuel(50);
            Console.WriteLine($"{dieselCar.Make} {dieselCar.Model} refueled!");

            // ElectricCar object Implements IRechargeable (since it cannot refuel), so it can recharge.
            GoodWay.ElectricCar electricCar = new GoodWay.ElectricCar();
            electricCar.Make = "Nissan";
            electricCar.Model = "Leaf";
            Console.WriteLine($"{electricCar.Make} {electricCar.Model} road tax: {electricCar.CalculateRoadTax(0)}");
            Console.WriteLine($"Attempting to recharge {electricCar.Make} {electricCar.Model}...");
            electricCar.Recharge(1000);
            Console.WriteLine($"{electricCar.Make} {electricCar.Model} recharge!");
        }
    }
}
