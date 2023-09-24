namespace OOP_Seminar1;

public class HotBeverageVendingMachine : VendingMachine<HotBeverage>
{
    public Product GetProduct(string product, int volume, int temperature)
    {
        return Products.First(b => b.Name == product && b.Volume == volume && b.Temperature == temperature);
    }
}