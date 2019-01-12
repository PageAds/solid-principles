namespace LiskovSubstitution.BadWay
{
    public class DieselCar : Car
    {
        public override void Refuel(double litres)
        {
            // Pickup diesel nozzle

            base.Refuel(litres);
        }
    }
}
