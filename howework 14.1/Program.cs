namespace howework_14._1;

class Program
{
    static void Main(string[] args)
    {
        var products = new List<Product>()
        {
            new Carrot(15),
            new Potato(20, 4),
            new Cucumber(14, 2)
        };
        VegatableShop shop = new VegatableShop();
        shop.AddProduct(products);
        shop.PrintProductsInfo();
    }
}
