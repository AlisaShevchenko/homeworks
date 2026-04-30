namespace howework_14._1;

public class Product
{
    protected decimal _basePrice;
    public Product(decimal basePrice)
    {
        _basePrice = basePrice;
    }
    public virtual decimal CalculatePrice()
    {
        return _basePrice;
    }

    public override string ToString()
    {
        return $"Product: {GetType().Name}, Price: {_basePrice}";
    }
}