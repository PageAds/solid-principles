namespace LiskovSubstitution.GoodWay
{
    public class StandardRefuelingSystem : IRefuelingSystem
    {
        private double remainingFuel;

        public double RemianingFuel => RemianingFuel;

        public void Refuel(double litres)
        {
            //Filling up

            remainingFuel += litres;
        }
    }
}
