namespace InterfaceSegregation.GoodWay
{
    public interface IShoppingItem
    {
        int ShoppingItemId { get; set; }

        string ProductBrand { get; set; }

        string ProductName { get; set; }

        int StockCount { get; set; }
    }
}
