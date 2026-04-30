namespace howework_14._1;

public class VegatableShop
{
    private List<Product> _allProducts = new List<Product>();

    public void AddProduct(List<Product> products)
    {
        _allProducts.AddRange(products);
    }

    public void PrintProductsInfo()
    { 
        decimal totalSum = 0;
        Console.WriteLine("Output:");
        foreach (var product in _allProducts)
        {
            Console.WriteLine(product.ToString());   
            totalSum += product.CalculatePrice();
        }
        

        Console.WriteLine("Total products price:" + totalSum); 
    }
}