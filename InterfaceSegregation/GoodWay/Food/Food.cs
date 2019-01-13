using System;

namespace InterfaceSegregation.GoodWay.Food
{
    public class Food : IFood
    {
        public int ShoppingItemId { get; set; }

        public string ProductBrand { get; set; }

        public string ProductName { get; set; }

        public int StockCount { get; set; }

        public DateTime ExpiryDate { get; set; }
    }
}
