namespace OOP_Seminar1;

public abstract class VendingMachine<T> : IVendingMachine where T : Product
{
    protected List<T> Products = new ();

    public void InitProducts(IEnumerable<Product> startProducts)
    {
        Products = startProducts
            .OfType<T>()
            .ToList();
    }

    public Product GetProduct(string product)
    {
        return Products.First(p => p.Name == product);
    }

    public void Add(Product product)
    {
        if (product.GetType() == typeof(T))
        {
            Products.Add((T)product);
        }
    }

    public void PrintProducts()
    {
        var text = string.Join("\n", Products.Select(p => p.ToString()));
        Console.WriteLine(text);
    }
}