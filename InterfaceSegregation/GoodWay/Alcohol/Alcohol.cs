using System;

namespace InterfaceSegregation.GoodWay.Alcohol
{
    public class Alcohol : IAlcohol
    {
        public int ShoppingItemId { get; set; }

        public string ProductBrand { get; set; }

        public string ProductName { get; set; }

        public int StockCount { get; set; }

        public int LegalAge { get; set; } = 18;

        public DateTime ExpiryDate { get; set; }
    }
}
