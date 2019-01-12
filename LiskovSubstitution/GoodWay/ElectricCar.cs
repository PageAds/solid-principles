namespace LiskovSubstitution.GoodWay
{
    public class ElectricCar : Car, IRechargeable
    {
        public void Recharge(double kw)
        {
            // Pickup charging nozzle

            // ...Charging code...
        }
    }
}
