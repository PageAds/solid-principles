namespace LiskovSubstitution.BadWay
{
    public class PetrolCar : Car
    {
        public override void Refuel(double litres)
        {
            // Pickup petrol nozzle

            base.Refuel(litres);
        }
    }
}
