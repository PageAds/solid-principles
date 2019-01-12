namespace LiskovSubstitution.BadWay
{
    public class Car
    {
        private double remainingFuel;

        public string Make { get; set; }

        public string Model { get; set; }

        public virtual void Refuel(double litres)
        {
            // Filling up...
            
            remainingFuel += litres;
        }

        public decimal CalculateRoadTax(decimal roadTaxMultiplier)
        {
            decimal baseAmount = 10.00M;
            
            return baseAmount * roadTaxMultiplier;
        }
    }
}
