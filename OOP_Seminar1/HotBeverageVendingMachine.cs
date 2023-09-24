namespace OOP_Seminar1;

public class HotBeverageVendingMachine : VendingMachine<HotBeverage>
{
    public Product GetProduct(string product, int volume, int temperature)
    {
        return Products.First(hb => hb.Name == product && hb.Volume == volume && hb.Temperature == temperature);
    }
}