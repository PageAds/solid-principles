namespace LiskovSubstitution.GoodWay
{
    public interface IRefuelingSystem
    {
        double RemainingFuel { get; set; }

        void Refuel(double litres);
    }
}