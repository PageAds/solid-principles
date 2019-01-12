namespace LiskovSubstitution.GoodWay
{
    public interface IRefuelingSystem
    {
        double RemianingFuel { get; }

        void Refuel(double litres);
    }
}