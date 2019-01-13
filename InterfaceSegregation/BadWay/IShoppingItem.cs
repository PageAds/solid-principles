using System;

namespace InterfaceSegregation.BadWay
{
    public interface IShoppingItem
    {
        int ShoppingItemId { get; set; }

        string ProductBrand { get; set; }

        string ProductName { get; set; }

        int StockCount { get; set; }

        DateTime? ExpiryDate { get; set; }

        int LegalAge { get; set; }
    }
}
