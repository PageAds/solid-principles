namespace LiskovSubstitution.GoodWay
{
    public class Car
    {
        public string Make { get; set; }

        public string Model { get; set; }

        public decimal CalculateRoadTax(decimal roadTaxMultiplier)
        {
            decimal baseAmount = 10.00M;

            return baseAmount * roadTaxMultiplier;
        }
    }
}
