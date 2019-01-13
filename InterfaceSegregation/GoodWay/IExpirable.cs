using System;

namespace InterfaceSegregation.GoodWay
{
    public interface IExpirable
    {
        DateTime ExpiryDate { get; set; }
    }
}
