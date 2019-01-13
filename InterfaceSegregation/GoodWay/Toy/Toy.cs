namespace InterfaceSegregation.GoodWay.Toy
{
    public class Toy : IShoppingItem
    {
        public int ShoppingItemId { get; set; }

        public string ProductBrand { get; set; }

        public string ProductName { get; set; }

        public int StockCount { get; set; }
    }
}
