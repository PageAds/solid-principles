using System;

namespace LiskovSubstitution.BadWay
{
    public class ElectricCar : Car
    {
        public override void Refuel(double litres)
        {
            throw new InvalidOperationException("Electric car has no fuel tank.");
        }
    }
}
