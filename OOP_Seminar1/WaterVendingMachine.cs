namespace OOP_Seminar1;

public class WaterVendingMachine: VendingMachine<BottleOfWater>
{
    public Product GetProduct(string product, int volume)
    {
        return Products.First(wb => wb.Name == product && wb.Volume == volume);
    }
    
}