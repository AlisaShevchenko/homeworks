namespace howework_14._1;

public class Cucumber: Product
{
    private decimal _count;
    public Cucumber(decimal basePrice, decimal count):base(basePrice)
    {
        _count = count;
    }
    public override decimal CalculatePrice()
    {
        return _basePrice * _count;
    }
    public override string ToString()
    {
        return $"Product: {GetType().Name}, Price: {_basePrice}, Count: {_count}, Total price: {CalculatePrice()}";
    }
}