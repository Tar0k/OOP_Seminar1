namespace OOP_Seminar1;

public interface IVendingMachine
{
    public void InitProducts(List<Product> startProducts);
    public Product GetProduct(string product);
    public void Add(Product product);
    public void PrintProducts();
}