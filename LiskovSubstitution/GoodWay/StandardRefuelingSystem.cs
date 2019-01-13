namespace LiskovSubstitution.GoodWay
{
    public class StandardRefuelingSystem : IRefuelingSystem
    {
        public double RemainingFuel { get; set; }

        public void Refuel(double litres)
        {
            //Filling up

            RemainingFuel += litres;
        }
    }
}
