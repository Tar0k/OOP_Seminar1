namespace OOP_Seminar1;

public class WaterVendingMachine: VendingMachine<BottleOfWater>
{
    public Product GetProduct(string product, int volume)
    {
        return Products.First(b => b.Name == product && b.Volume == volume);
    }
    
}