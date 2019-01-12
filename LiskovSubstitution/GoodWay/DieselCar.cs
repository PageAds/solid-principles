namespace LiskovSubstitution.GoodWay
{
    public class DieselCar : Car, IRefuelable
    {
        // Using dependency injection to share refuel code between Petrol/Diesel class
        private readonly IRefuelingSystem refuelingSystem;

        public DieselCar(IRefuelingSystem refuelingSystem)
        {
            this.refuelingSystem = refuelingSystem;
        }

        public void Refuel(double litres)
        {
            // Pickup diesel nozzle

            this.refuelingSystem.Refuel(litres);
;        }
    }
}
