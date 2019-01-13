using System;

namespace InterfaceSegregation.BadWay
{
    public class Toy : IShoppingItem
    {
        public int ShoppingItemId { get; set; }

        public string ProductBrand { get; set; }

        public string ProductName { get; set; }

        public int StockCount { get; set; }

        public DateTime? ExpiryDate { get; set; } = null;

        public int LegalAge { get; set; } = 0;
    }
}
