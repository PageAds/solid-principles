namespace LiskovSubstitution.GoodWay
{
    public class PetrolCar : Car, IRefuelable
    {
        // Using dependency injection to share refuel code between Petrol/Diesel class
        private readonly IRefuelingSystem refuelingSystem;

        public PetrolCar(IRefuelingSystem refuelingSystem)
        {
            this.refuelingSystem = refuelingSystem;
        }

        public void Refuel(double litres)
        {
            // Pickup petrol nozzle

            this.refuelingSystem.Refuel(litres);
        }
    }
}
